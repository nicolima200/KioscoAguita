using LicenciasApi;
using Microsoft.Data.Sqlite;
using System.Globalization;

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

app.Run();

record RegistroRequest(string Nombre, string Apellido, string Telefono, string NombreKiosco, string Direccion, string Email, string Password);
record ActivarRequest(string Email, string Password);