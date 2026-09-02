using dominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class CategoriaService
    {
        public List<string> listar()
        {
            List<string> listaCategorias = new List<string>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT descripcion FROM categorias");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    string aux = (string)datos.Lector["descripcion"];
                    listaCategorias.Add(aux);
                }

                return listaCategorias;
            }
            catch (Exception ex)
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
