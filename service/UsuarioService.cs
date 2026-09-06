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
        private const string NombreAdmin = "admin";

        public bool RequiereConfigurarPassword()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta(consultasUsuario.SqlRequiereConfigurar);
                datos.setParametro("@usuario", NombreAdmin);
                datos.ejecutarConsulta();

                if (!datos.Lector.Read())
                {
                    datos.cerrarConexion();
                    return false;
                }

                bool flag = Convert.ToInt32(datos.Lector["debeConfigurarPassword"]) == 1;
                string pass = datos.Lector["pass"] as string ?? string.Empty;

                datos.cerrarConexion();

                return flag || string.IsNullOrEmpty(pass);
            }
            catch (Exception)
            {
                datos.cerrarConexion();
                throw;
            }
        }

        public Usuario LoginAdmin(string password)
        {
            if (string.IsNullOrEmpty(password))
                return null;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta(consultasUsuario.SqlBuscarAdmin);
                datos.setParametro("@usuario", NombreAdmin);
                datos.ejecutarConsulta();

                if (!datos.Lector.Read())
                {
                    datos.cerrarConexion();
                    return null;
                }

                Usuario admin = new Usuario();
                admin.Id = datos.Lector.GetInt32(0);
                admin.Nombre = (string)datos.Lector["nombre"];

                if (Enum.TryParse<TipoUsuario>(datos.Lector["tipousuario"].ToString(), out TipoUsuario tipo))
                    admin.TipoUsuario = tipo;

                string passAlmacenada = (string)datos.Lector["pass"];
                admin.DebeConfigurarPassword = Convert.ToInt32(datos.Lector["debeConfigurarPassword"]) == 1;

                datos.cerrarConexion();

                if (admin.DebeConfigurarPassword || string.IsNullOrEmpty(passAlmacenada))
                    return null;

                if (!Seguridad.VerificarPassword(password, passAlmacenada))
                    return null;

                if (Seguridad.EsHashLegado(passAlmacenada))
                    ConfigurarPassword(password);

                return admin;
            }
            catch (Exception)
            {
                datos.cerrarConexion();
                throw;
            }
        }

        public void ConfigurarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.");

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta(consultasUsuario.SqlConfigurarPassword);
                datos.setParametro("@pass", Seguridad.HashPassword(password));
                datos.setParametro("@flag", 0);
                datos.setParametro("@usuario", NombreAdmin);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void PrepararRestablecimiento()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta(consultasUsuario.SqlPrepararRestablecimiento);
                datos.setParametro("@usuario", NombreAdmin);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
