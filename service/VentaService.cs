using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using Microsoft.Data.Sqlite;

namespace service
{
    public class VentaService
    {
        public VentaService() { }

        public void guardarVentaCompleta(Venta venta, List<DetalleVenta> listaVenta)
        {
            AccesoDatos datos = new AccesoDatos();
            int idVenta = 0;

            using (SqliteConnection conexion = new SqliteConnection("Data Source ="+datos.getConnectionString()))
            {
                conexion.Open();

                using (SqliteTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        idVenta = insertarVenta(transaccion, conexion, venta, idVenta);

                        foreach (DetalleVenta detalleVenta in listaVenta)
                        {
                            insertarDetalleVenta(transaccion,conexion,detalleVenta, idVenta);

                            actualizarStock(transaccion,conexion,detalleVenta);
                            autoActivarSiDormido(transaccion,conexion,detalleVenta);
                        }

                        transaccion.Commit();
                    }
                    catch (Exception)
                    {
                        try { transaccion.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }

        private int insertarVenta(SqliteTransaction transaccion, SqliteConnection conexion, Venta venta, int idVenta)
        {
            using (SqliteCommand comandoVenta = conexion.CreateCommand())
            {
                comandoVenta.Transaction = transaccion;
                comandoVenta.CommandText = consultasVenta.SqlInsertarVenta;
                comandoVenta.Parameters.AddWithValue("@fecha", venta.Fecha);
                comandoVenta.Parameters.AddWithValue("@montototal", venta.MontoTotal);
                comandoVenta.Parameters.AddWithValue("@montopago", venta.MontoPago);
                comandoVenta.Parameters.AddWithValue("@vuelto", venta.Vuelto);
                comandoVenta.Parameters.AddWithValue("@formapago", venta.FormaPago.ToString());
                comandoVenta.Parameters.AddWithValue("@referencia", venta.referencia);

                return Convert.ToInt32(comandoVenta.ExecuteScalar());
            }
        }

        private void actualizarStock(SqliteTransaction transaccion, SqliteConnection conexion, DetalleVenta detalleVenta)
        {
            using (SqliteCommand comandoUpdateStock = conexion.CreateCommand())
            {
                comandoUpdateStock.Transaction = transaccion;

                comandoUpdateStock.CommandText = consultasVenta.SqlActualizarStock;
                comandoUpdateStock.Parameters.AddWithValue("@cantidad", detalleVenta.Cantidad);
                comandoUpdateStock.Parameters.AddWithValue("@idProd", detalleVenta.IdProducto);

                comandoUpdateStock.ExecuteNonQuery();

            }
        }

        private void autoActivarSiDormido(SqliteTransaction transaccion, SqliteConnection conexion, DetalleVenta detalleVenta)
        {
            using (SqliteCommand comando = conexion.CreateCommand())
            {
                comando.Transaction = transaccion;
                comando.CommandText = consultasVenta.SqlAutoActivar;
                comando.Parameters.AddWithValue("@idProd", detalleVenta.IdProducto);
                comando.ExecuteNonQuery();
            }
        }

        private void insertarDetalleVenta(SqliteTransaction transaccion, SqliteConnection conexion, DetalleVenta detalleVenta, int idVenta)
        {
            using (SqliteCommand comandoDetalle = conexion.CreateCommand())
            {
                comandoDetalle.Transaction = transaccion;

                comandoDetalle.CommandText = consultasDetalleVenta.SqlInsertarDetalleVenta;
                comandoDetalle.Parameters.AddWithValue("@idventa", idVenta);
                comandoDetalle.Parameters.AddWithValue("@idproducto", detalleVenta.IdProducto);
                comandoDetalle.Parameters.AddWithValue("@cantidad", detalleVenta.Cantidad);
                comandoDetalle.Parameters.AddWithValue("@preciounitario", detalleVenta.PrecioUnitario);
                comandoDetalle.Parameters.AddWithValue("@subtotal", detalleVenta.Subtotal);

                comandoDetalle.ExecuteNonQuery();
            }
        }
    }
}
