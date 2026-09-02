using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consultasDetalleVenta
    {
        private const string sqlInsertarDetalleVenta = "INSERT INTO detalleVentas (idVenta,idProducto,cantidad,precioUnitario,subtotal) VALUES (@idventa, @idproducto, @cantidad, @preciounitario, @subtotal)";
        private const string sqlListarDetalleVentaPorIdVenta = "SELECT id, idVenta, idProducto, cantidad, precioUnitario, subtotal FROM detalleVentas WHERE idVenta = @idventa";
        private const string sqlListarDetalleVentaPorIdVentaCompleto = "SELECT p.codbarras, p.nombre , p.marca, p.descripcion, p.tipoVenta, cantidad, precioUnitario, subtotal FROM detalleVentas inner join productos p on idProducto = p.id where idVenta = @idventa";

        public static string SqlInsertarDetalleVenta => sqlInsertarDetalleVenta;

        public static string SqlListarDetalleVentaPorIdVenta => sqlListarDetalleVentaPorIdVenta;

        public static string SqlListarDetalleVentaPorIdVentaCompleto => sqlListarDetalleVentaPorIdVentaCompleto;
    }
}
