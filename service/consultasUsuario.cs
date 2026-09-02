using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consultasUsuario
    {
        private const string sqlBuscarUsuario = "SELECT id, nombre, tipousuario, pass from usuarios WHERE nombre = @usuario";

        private const string sqlActualizarPass = "UPDATE usuarios SET pass = @pass WHERE id = @id";

        public static string SqlBuscarUsuario => sqlBuscarUsuario;

        public static string SqlActualizarPass => sqlActualizarPass;
    }
}
