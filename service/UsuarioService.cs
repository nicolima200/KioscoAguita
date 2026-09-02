using System;
using dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio.enums;

namespace service
{
    public class UsuarioService
    {
        public Usuario login(string usuario, string password)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta(consultasUsuario.SqlBuscarUsuario);
                datos.setParametro("@usuario", usuario);
                datos.ejecutarConsulta();

                if (!datos.Lector.Read())
                {
                    datos.cerrarConexion();
                    return null;
                }

                Usuario usuarioEncontrado = new Usuario();
                usuarioEncontrado.Id = datos.Lector.GetInt32(0);
                usuarioEncontrado.Nombre = (string)datos.Lector["nombre"];

                string passAlmacenada = (string)datos.Lector["pass"];

                if (Enum.TryParse<TipoUsuario>(datos.Lector["tipoUsuario"].ToString(), out TipoUsuario e))
                    usuarioEncontrado.TipoUsuario = e;

                datos.cerrarConexion();

                if (!Seguridad.VerificarPassword(password, passAlmacenada))
                    return null;

                if (Seguridad.EsHashLegado(passAlmacenada))
                    RehashearPass(datos, usuarioEncontrado.Id, password);

                return usuarioEncontrado;
            }
            catch (Exception)
            {
                datos.cerrarConexion();
                throw;
            }
        }

        private void RehashearPass(AccesoDatos datos, int idUsuario, string password)
        {
            try
            {
                datos.setConsulta(consultasUsuario.SqlActualizarPass);
                datos.setParametro("@pass", Seguridad.HashPassword(password));
                datos.setParametro("@id", idUsuario);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
