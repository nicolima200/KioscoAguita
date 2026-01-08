
using dominio.enums;
using System.ComponentModel;

namespace dominio
{
    public class ItemVenta
    {
        public string CodBarras { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }
        public TipoVenta TipoVenta { get; set; }

    }
}
