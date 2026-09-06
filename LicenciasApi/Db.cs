using Microsoft.Data.Sqlite;

namespace LicenciasApi;

public static class Db
{
    public const string ConnectionString = "Data Source=licencias.db";

    public static void Inicializar()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();
        var comando = connection.CreateCommand();
        comando.CommandText = @"
            CREATE TABLE IF NOT EXISTS Licencias (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Apellido TEXT NOT NULL,
            Telefono TEXT,
            NombreKiosco TEXT NOT NULL,
            Direccion TEXT,
            Email TEXT NOT NULL UNIQUE,
            PasswordHash TEXT NOT NULL,
            Salt TEXT NOT NULL,
            MercadoPagoSubscriptionId TEXT,
            Estado TEXT NOT NULL DEFAULT 'activa',
            FechaVencimiento TEXT NOT NULL);
        CREATE TABLE IF NOT EXISTS CodigosRestablecimientoAdmin (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            LicenciaId INTEGER NOT NULL,
            CodigoHash TEXT NOT NULL,
            CreadoEnUtc TEXT NOT NULL,
            VenceEnUtc TEXT NOT NULL,
            AutorizadoEnUtc TEXT,
            TicketHash TEXT,
            TicketVenceEnUtc TEXT,
            UsadoEnUtc TEXT,
            CreadoPor TEXT NOT NULL,
            IntentosFallidos INTEGER NOT NULL DEFAULT 0);
        ";
        comando.ExecuteNonQuery();

        var indice = connection.CreateCommand();
        indice.CommandText = @"
            CREATE INDEX IF NOT EXISTS idx_codigos_licencia
            ON CodigosRestablecimientoAdmin (LicenciaId, UsadoEnUtc, VenceEnUtc);
        ";
        indice.ExecuteNonQuery();
    }
}