using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace service
{
    public class AccesoDatos
    {
        private SqliteConnection conexion;
        private SqliteCommand comando;
        private SqliteDataReader lector;

        private static readonly string DbPath = RutaDbGarantizada();

        /// <summary>
        /// La DB vive en %ProgramData%\KioscoAguita para sobrevivir a updates del MSI.
        /// Orden de seed: DB vieja junto al exe (migra datos) → seed embebido en Resources.
        /// </summary>
        private static string RutaDbGarantizada()
        {
            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "KioscoAguita");
            string ruta = Path.Combine(dir, "DBKiosco");

            if (!File.Exists(ruta))
            {
                Directory.CreateDirectory(dir);

                string vieja = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBKiosco");

                if (File.Exists(vieja))
                    File.Copy(vieja, ruta);
                else
                    File.WriteAllBytes(ruta, Properties.Resources.DBKiosco);
            }

            AplicarMigraciones(ruta);

            return ruta;
        }

        private static void AplicarMigraciones(string ruta)
        {
            using (SqliteConnection conexion = new SqliteConnection($"Data Source={ruta};Foreign Keys=True"))
            {
                conexion.Open();

                bool existeColumna = false;

                using (SqliteCommand cmd = new SqliteCommand("PRAGMA table_info(usuarios)", conexion))
                using (SqliteDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        if (string.Equals(lector.GetString(1), "debeConfigurarPassword", StringComparison.OrdinalIgnoreCase))
                        {
                            existeColumna = true;
                            break;
                        }
                    }
                }

                // Primera ejecucion con el esquema nuevo: forzar reset de la cuenta admin.
                // Solo corre cuando se agrega la columna, nunca en cada arranque.
                if (!existeColumna)
                {
                    using (SqliteCommand cmd = new SqliteCommand(
                        "ALTER TABLE usuarios ADD COLUMN debeConfigurarPassword INTEGER NOT NULL DEFAULT 0", conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    ForzarResetAdmin(conexion);
                }
            }
        }

        private static void ForzarResetAdmin(SqliteConnection conexion)
        {
            int idAdmin = 0;

            using (SqliteCommand cmd = new SqliteCommand(
                "SELECT id FROM usuarios WHERE nombre = 'admin' COLLATE NOCASE LIMIT 1", conexion))
            using (SqliteDataReader lector = cmd.ExecuteReader())
            {
                if (lector.Read())
                    idAdmin = lector.GetInt32(0);
            }

            if (idAdmin > 0)
            {
                using (SqliteCommand cmd = new SqliteCommand(
                    "UPDATE usuarios SET pass = '', debeConfigurarPassword = 1 WHERE id = @id", conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idAdmin);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                try
                {
                    using (SqliteCommand cmd = new SqliteCommand(
                        "INSERT INTO usuarios (nombre, tipousuario, pass, debeConfigurarPassword) VALUES ('admin', 'Admin', '', 1)", conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqliteException)
                {
                    // Esquema con columnas NOT NULL adicionales: no se puede insertar sin conocerlas.
                    // La proxima ejecucion reintenta; si no existe admin el login queda bloqueado a proposito.
                }
            }
        }
        
        public SqliteDataReader Lector => lector;

        public AccesoDatos()
        {
            conexion = new SqliteConnection($"Data Source ={DbPath};Foreign Keys=True");
            comando = new SqliteCommand();
        }

        public void setConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            comando.Parameters.Clear();
        }

        public void setParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarConsulta()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (SqliteException)
            {
                conexion.Close();
                throw;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int ejecutarAccionGetId()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }catch
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public string getConnectionString()
        {
            return DbPath;
        }
    }
}
