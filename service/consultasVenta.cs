using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consultasVenta
    {
        private const string sqlInsertarVenta = "INSERT INTO Ventas (id, fecha, montoTotal, montoPago, vuelto, formaPago, referencia) VALUES (null, @fecha, @montototal, @montopago, @vuelto, @formapago, @referencia);SELECT last_insert_rowid();";
        private const string sqlActualizarStock = "UPDATE productos_inventario set stock = stock-@cantidad where idProducto = @idProd";
        private const string sqlAutoActivar = "UPDATE productos_inventario SET activo=1 WHERE idProducto=@idProd AND activo=0 AND eliminado=0";
        private const string sqlListarVentasPorFecha = "SELECT id, fecha, montoTotal, montoPago, vuelto, formaPago, referencia FROM ventas WHERE fecha >= @fechaDesde AND fecha < date(@fechaHasta, '+1 day') ORDER BY fecha DESC";
        private const string sqlListarVentas = "SELECT id, fecha, montoTotal, montoPago, vuelto, formaPago, referencia FROM ventas ORDER BY fecha DESC";

        /******/
        /******/
        public static string SqlListarVentasPorFecha => sqlListarVentasPorFecha;
        public static string SqlInsertarVenta => sqlInsertarVenta;
        public static string SqlActualizarStock => sqlActualizarStock;
        public static string SqlAutoActivar => sqlAutoActivar;
        public static string SqlListarVentas => sqlListarVentas;
    }
}
