using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio.enums
{
    public enum TipoVenta
    {
        Unidad,
        Kilo,
        Litro,
        Metro
    }

    public enum FormaPago
    {
        Efectivo,
        TarjetaCredito,
        TarjetaDebito,
        Transferencia
    }

    public enum TipoUsuario
    {
        Admin = 1,
        Empleado = 2,
    }
}
