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
        ";
        comando.ExecuteNonQuery();
    }
}