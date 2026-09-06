using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consultasUsuario
    {
        private const string sqlBuscarAdmin = "SELECT id, nombre, tipousuario, pass, debeConfigurarPassword FROM usuarios WHERE nombre = @usuario COLLATE NOCASE LIMIT 1";

        private const string sqlRequiereConfigurar = "SELECT debeConfigurarPassword, pass FROM usuarios WHERE nombre = @usuario COLLATE NOCASE LIMIT 1";

        private const string sqlConfigurarPassword = "UPDATE usuarios SET pass = @pass, debeConfigurarPassword = @flag WHERE nombre = @usuario COLLATE NOCASE";

        private const string sqlPrepararRestablecimiento = "UPDATE usuarios SET pass = '', debeConfigurarPassword = 1 WHERE nombre = @usuario COLLATE NOCASE";

        public static string SqlBuscarAdmin => sqlBuscarAdmin;

        public static string SqlRequiereConfigurar => sqlRequiereConfigurar;

        public static string SqlConfigurarPassword => sqlConfigurarPassword;

        public static string SqlPrepararRestablecimiento => sqlPrepararRestablecimiento;
    }
}
