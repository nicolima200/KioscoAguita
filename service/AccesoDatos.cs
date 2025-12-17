using Microsoft.Data.Sqlite;

namespace service
{
    public class AccesoDatos
    {
        private SqliteConnection conexion;
        private SqliteCommand comando;
        private SqliteDataReader lector;

        private string DbPath= "C:\\Users\\nicol\\Documents\\1.Proyecto KioscoH\\DBKiosco";
        public SqliteDataReader Lector => lector;

        public AccesoDatos()
        {
            conexion = new SqliteConnection($"Data Source ={DbPath}");
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
            catch (SqliteException e)
            {
                
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
            catch (System.Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
