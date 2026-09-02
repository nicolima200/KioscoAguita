using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class MarcaService
    {
        public List<string> listar()
        {
            List<string> listaMarcas = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT DISTINCT marca FROM productos");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    string aux = (string)datos.Lector["marca"];
                    listaMarcas.Add(aux);
                }

                return listaMarcas;
            }
            catch
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
