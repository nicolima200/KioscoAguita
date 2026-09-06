using LicenciasApi;
using Microsoft.Data.Sqlite;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Jwt.AsegurarClaves();
Db.Inicializar();

app.MapPost("/registrar", (RegistroRequest datos) =>
{
    var (hash, salt) = Seguridad.HashearPassword(datos.Password);

    using var conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    var comando = conexion.CreateCommand();
    comando.CommandText = @"
        INSERT INTO Licencias (Nombre, Apellido, Telefono, NombreKiosco, Direccion, Email, PasswordHash, Salt, Estado, FechaVencimiento)
        VALUES (@nombre, @apellido, @telefono, @nombreKiosco, @direccion, @email, @hash, @salt, 'activa', @vencimiento);
";
    comando.Parameters.AddWithValue("@nombre", datos.Nombre);
    comando.Parameters.AddWithValue("@apellido", datos.Apellido);
    comando.Parameters.AddWithValue("@telefono", datos.Telefono);
    comando.Parameters.AddWithValue("@nombreKiosco", datos.NombreKiosco);
    comando.Parameters.AddWithValue("@direccion", datos.Direccion);
    comando.Parameters.AddWithValue("@email", datos.Email);
    comando.Parameters.AddWithValue("@hash", hash);
    comando.Parameters.AddWithValue("@salt", salt);
    comando.Parameters.AddWithValue("@vencimiento", DateTime.UtcNow.AddDays(30).ToString("O"));

    try
    {
        comando.ExecuteNonQuery();
        return Results.Created();
    }
    catch (SqliteException ex) when (ex.SqliteErrorCode == 19)
    {
        return Results.Conflict("Ya existe una licencia con ese email");
    }
});

app.MapPost("/activar", (ActivarRequest datos) =>
{
    using var conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    var comando = conexion.CreateCommand();
    comando.CommandText = "SELECT PasswordHash, Salt, Estado, FechaVencimiento FROM Licencias WHERE Email = @Email;";
    comando.Parameters.AddWithValue("@Email", datos.Email);

    using var lector = comando.ExecuteReader();

    if (!lector.Read())
        return Results.Unauthorized();

    string hashGuardado = (string)lector["PasswordHash"];
    string saltGuardado = (string)lector["Salt"];
    string estado = (string)lector["Estado"];
    string vencimiento = (string)lector["FechaVencimiento"];

    if (!Seguridad.VerificarPassword(datos.Password, hashGuardado, saltGuardado))
        return Results.Unauthorized();

    DateTime vencimientoFecha = DateTime.Parse(vencimiento,null,DateTimeStyles.RoundtripKind);

    return ResponderConToken(datos.Email, estado, vencimientoFecha);

});

app.MapPost("/estado", (HttpRequest request) =>
{
    string encabezado = request.Headers["Authorization"];

    if (string.IsNullOrEmpty(encabezado) || !encabezado.StartsWith("Bearer "))
        return Results.Unauthorized();

    string tokenViejo = encabezado.Substring("Bearer ".Length);

    string email;
    try
    {
        email = Jwt.ObtenerEmailDeToken(tokenViejo);
    }
    catch (Exception)
    {
        return Results.Unauthorized();
    }

    using SqliteConnection conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    SqliteCommand comando = conexion.CreateCommand();
    comando.CommandText = "SELECT Estado, FechaVencimiento FROM Licencias WHERE Email = @email;";
    comando.Parameters.AddWithValue("@email", email);

    using SqliteDataReader lector = comando.ExecuteReader();

    if (!lector.Read())
        return Results.Unauthorized();

    string estado = (string)lector["Estado"];
    DateTime vencimientoFecha = DateTime.Parse((string)lector["FechaVencimiento"], null, DateTimeStyles.RoundtripKind);

    return ResponderConToken(email,estado, vencimientoFecha);
});

IResult ResponderConToken(string email, string estado, DateTime vencimientoFecha)
{
    if (estado != "activa")
        return Results.Json(new { error = "licencia_inactiva", estado }, statusCode: 402);

    if (vencimientoFecha < DateTime.UtcNow)
        return Results.Json(new { error = "licencia_vencida" }, statusCode: 402);

    return Results.Ok(new { token = Jwt.GenerarToken(email, estado, vencimientoFecha) });
}

// ---------------------------------------------------------------------------
// Restablecimiento de contraseña de administrador por código temporal
// ---------------------------------------------------------------------------

app.MapPost("/soporte/codigos-restablecimiento", (HttpRequest request, RestablecimientoRequest datos) =>
{
    string claveSoporte = Environment.GetEnvironmentVariable("SOPORTE_KEY");

    if (string.IsNullOrEmpty(claveSoporte))
        return Results.Json(new { error = "soporte_no_configurado" }, statusCode: 503);

    if (datos.Operador == null || request.Headers["X-Soporte-Key"] != claveSoporte)
        return Results.Unauthorized();

    using var conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    var buscar = conexion.CreateCommand();
    buscar.CommandText = "SELECT Id FROM Licencias WHERE Email = @email;";
    buscar.Parameters.AddWithValue("@email", datos.Email);
    object idObj = buscar.ExecuteScalar();

    if (idObj == null)
        return Results.NotFound();

    int licenciaId = Convert.ToInt32(idObj);

    // Revocar códigos pendientes anteriores de la misma licencia
    var revocar = conexion.CreateCommand();
    revocar.CommandText = @"
        UPDATE CodigosRestablecimientoAdmin
           SET UsadoEnUtc = @ahora
         WHERE LicenciaId = @licenciaId AND UsadoEnUtc IS NULL;";
    revocar.Parameters.AddWithValue("@ahora", DateTime.UtcNow.ToString("O"));
    revocar.Parameters.AddWithValue("@licenciaId", licenciaId);
    revocar.ExecuteNonQuery();

    string codigo = GenerarCodigoNumerico(6);

    var insertar = conexion.CreateCommand();
    insertar.CommandText = @"
        INSERT INTO CodigosRestablecimientoAdmin
            (LicenciaId, CodigoHash, CreadoEnUtc, VenceEnUtc, CreadoPor)
        VALUES (@licenciaId, @hash, @creado, @vence, @operador);";
    insertar.Parameters.AddWithValue("@licenciaId", licenciaId);
    insertar.Parameters.AddWithValue("@hash", FirmarCodigo(codigo, claveSoporte));
    insertar.Parameters.AddWithValue("@creado", DateTime.UtcNow.ToString("O"));
    insertar.Parameters.AddWithValue("@vence", DateTime.UtcNow.AddMinutes(15).ToString("O"));
    insertar.Parameters.AddWithValue("@operador", datos.Operador);
    insertar.ExecuteNonQuery();

    return Results.Ok(new { codigo });
});

app.MapPost("/restablecimientos/autorizar", (HttpRequest request, ValidarCodigoRequest datos) =>
{
    if (string.IsNullOrEmpty(datos.Codigo))
        return Results.Json(new { error = "codigo_invalido" }, statusCode: 400);

    string email;
    try
    {
        email = Jwt.ObtenerEmailDeToken(ExtraerBearer(request));
    }
    catch (Exception)
    {
        return Results.Json(new { error = "codigo_invalido" }, statusCode: 400);
    }

    using var conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    if (!LicenciaActiva(conexion, email))
        return Results.Unauthorized();

    string claveSoporte = Environment.GetEnvironmentVariable("SOPORTE_KEY") ?? "";

    var buscar = conexion.CreateCommand();
    buscar.CommandText = @"
        SELECT Id, CodigoHash, VenceEnUtc, IntentosFallidos
          FROM CodigosRestablecimientoAdmin
         WHERE LicenciaId = (SELECT Id FROM Licencias WHERE Email = @email)
           AND UsadoEnUtc IS NULL
         ORDER BY Id DESC LIMIT 1;";
    buscar.Parameters.AddWithValue("@email", email);
    using var lector = buscar.ExecuteReader();

    if (!lector.Read())
        return Results.Json(new { error = "codigo_invalido" }, statusCode: 400);

    int idCodigo = lector.GetInt32(0);
    string hashGuardado = lector.GetString(1);
    DateTime vence = DateTime.Parse(lector.GetString(2), null, DateTimeStyles.RoundtripKind);
    int intentos = lector.GetInt32(3);
    lector.Close();

    if (vence < DateTime.UtcNow || intentos >= 5)
        return Results.Json(new { error = "codigo_invalido" }, statusCode: 400);

    if (!CompararFirma(hashGuardado, FirmarCodigo(datos.Codigo, claveSoporte)))
    {
        RegistrarIntentoFallido(conexion, idCodigo);
        return Results.Json(new { error = "codigo_invalido" }, statusCode: 400);
    }

    string ticket = Convert.ToBase64String(RandomBytes(32))
        .TrimEnd('=').Replace('+', '-').Replace('/', '_');

    var usar = conexion.CreateCommand();
    usar.CommandText = @"
        UPDATE CodigosRestablecimientoAdmin
           SET AutorizadoEnUtc = @ahora,
               TicketHash = @ticketHash,
               TicketVenceEnUtc = @venceTicket
         WHERE Id = @id;";
    usar.Parameters.AddWithValue("@ahora", DateTime.UtcNow.ToString("O"));
    usar.Parameters.AddWithValue("@ticketHash", FirmarCodigo(ticket, claveSoporte));
    usar.Parameters.AddWithValue("@venceTicket", DateTime.UtcNow.AddMinutes(5).ToString("O"));
    usar.Parameters.AddWithValue("@id", idCodigo);
    usar.ExecuteNonQuery();

    return Results.Ok(new { ticket });
});

app.MapPost("/restablecimientos/confirmar", (HttpRequest request, ConfirmarTicketRequest datos) =>
{
    if (string.IsNullOrEmpty(datos.Ticket))
        return Results.NotFound();

    string email;
    try
    {
        email = Jwt.ObtenerEmailDeToken(ExtraerBearer(request));
    }
    catch (Exception)
    {
        return Results.NotFound();
    }

    using var conexion = new SqliteConnection(Db.ConnectionString);
    conexion.Open();

    string claveSoporte = Environment.GetEnvironmentVariable("SOPORTE_KEY") ?? "";
    string firmaTicket = FirmarCodigo(datos.Ticket, claveSoporte);

    var buscar = conexion.CreateCommand();
    buscar.CommandText = @"
        SELECT TicketVenceEnUtc, UsadoEnUtc
          FROM CodigosRestablecimientoAdmin
         WHERE LicenciaId = (SELECT Id FROM Licencias WHERE Email = @email)
           AND TicketHash = @firma
         LIMIT 1;";
    buscar.Parameters.AddWithValue("@email", email);
    buscar.Parameters.AddWithValue("@firma", firmaTicket);
    using var lector = buscar.ExecuteReader();

    if (!lector.Read())
        return Results.NotFound();

    string vence = lector.IsDBNull(0) ? null : lector.GetString(0);
    bool yaUsado = !lector.IsDBNull(1);
    lector.Close();

    // Ticket ya consumido: idempotente para que el cliente pueda reintentar.
    if (yaUsado)
        return Results.Ok();

    if (vence == null || DateTime.Parse(vence, null, DateTimeStyles.RoundtripKind) < DateTime.UtcNow)
        return Results.NotFound();

    var consumir = conexion.CreateCommand();
    consumir.CommandText = @"
        UPDATE CodigosRestablecimientoAdmin
           SET UsadoEnUtc = @ahora
         WHERE TicketHash = @firma;";
    consumir.Parameters.AddWithValue("@ahora", DateTime.UtcNow.ToString("O"));
    consumir.Parameters.AddWithValue("@firma", firmaTicket);
    consumir.ExecuteNonQuery();

    return Results.Ok();
});

string ExtraerBearer(HttpRequest request)
{
    string encabezado = request.Headers["Authorization"];
    if (string.IsNullOrEmpty(encabezado) || !encabezado.StartsWith("Bearer "))
        throw new UnauthorizedAccessException();
    return encabezado.Substring("Bearer ".Length);
}

bool LicenciaActiva(SqliteConnection conexion, string email)
{
    var comando = conexion.CreateCommand();
    comando.CommandText = "SELECT Estado, FechaVencimiento FROM Licencias WHERE Email = @email;";
    comando.Parameters.AddWithValue("@email", email);
    using var lector = comando.ExecuteReader();

    if (!lector.Read())
        return false;

    string estado = lector.GetString(0);
    DateTime vencimiento = DateTime.Parse(lector.GetString(1), null, DateTimeStyles.RoundtripKind);
    return estado == "activa" && vencimiento >= DateTime.UtcNow;
}

string GenerarCodigoNumerico(int digitos)
{
    byte[] buffer = RandomBytes(digitos);
    var sb = new StringBuilder(digitos);
    foreach (byte b in buffer)
        sb.Append((char)('0' + (b % 10)));
    return sb.ToString();
}

byte[] RandomBytes(int cantidad)
{
    using var rng = RandomNumberGenerator.Create();
    byte[] buffer = new byte[cantidad];
    rng.GetBytes(buffer);
    return buffer;
}

string FirmarCodigo(string valor, string clave)
{
    using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(clave));
    byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(valor));
    var sb = new StringBuilder(hash.Length * 2);
    foreach (byte b in hash)
        sb.Append(b.ToString("x2"));
    return sb.ToString();
}

bool CompararFirma(string a, string b)
{
    if (a == null || b == null || a.Length != b.Length)
        return false;

    int diferencia = 0;
    for (int i = 0; i < a.Length; i++)
        diferencia |= a[i] ^ b[i];
    return diferencia == 0;
}

void RegistrarIntentoFallido(SqliteConnection conexion, int idCodigo)
{
    var comando = conexion.CreateCommand();
    comando.CommandText = @"
        UPDATE CodigosRestablecimientoAdmin
           SET IntentosFallidos = IntentosFallidos + 1,
               UsadoEnUtc = CASE WHEN IntentosFallidos + 1 >= 5 THEN @ahora ELSE UsadoEnUtc END
         WHERE Id = @id;";
    comando.Parameters.AddWithValue("@ahora", DateTime.UtcNow.ToString("O"));
    comando.Parameters.AddWithValue("@id", idCodigo);
    comando.ExecuteNonQuery();
}

app.Run();

record RegistroRequest(string Nombre, string Apellido, string Telefono, string NombreKiosco, string Direccion, string Email, string Password);
record ActivarRequest(string Email, string Password);
record RestablecimientoRequest(string Email, string Operador);
record ValidarCodigoRequest(string Codigo);
record ConfirmarTicketRequest(string Ticket);