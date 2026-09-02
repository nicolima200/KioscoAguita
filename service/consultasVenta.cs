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
        private const string sqlActualizarStock = "UPDATE productos set stock = stock-@cantidad where id = @idProd";
        private const string sqlListarVentasPorFecha = "SELECT id, fecha, montoTotal, montoPago, vuelto, formaPago, referencia FROM ventas WHERE date(fecha) BETWEEN date(@fechaDesde) AND date(@fechaHasta) ORDER BY fecha DESC";
        private const string sqlListarVentas = "SELECT id, fecha, montoTotal, montoPago, vuelto, formaPago, referencia FROM ventas ORDER BY fecha DESC";

        /******/
        /******/
        public static string SqlListarVentasPorFecha => sqlListarVentasPorFecha;
        public static string SqlInsertarVenta => sqlInsertarVenta;
        public static string SqlActualizarStock => sqlActualizarStock;
        public static string SqlListarVentas => sqlListarVentas;
    }
}
