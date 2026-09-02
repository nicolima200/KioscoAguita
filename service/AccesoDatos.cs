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

        private string DbPath= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBKiosco");
        
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
