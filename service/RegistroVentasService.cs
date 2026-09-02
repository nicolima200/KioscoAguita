using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class RegistroVentasService
    {
        //Listar Ventas
        public BindingList<Venta> listar(bool activo = true)
        {
            BindingList<Venta> listaVentas = new BindingList<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setConsulta(consultasVenta.SqlListarVentas);


                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    listaVentas.Add(getVentasLector(datos));
                }

                return listaVentas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public BindingList<Venta> listarPorFecha(DateTime desde, DateTime hasta)
        {
            BindingList<Venta> listaFiltrada = new BindingList<Venta>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(consultasVenta.SqlListarVentasPorFecha);
                datos.setParametro("@fechaDesde", desde.ToString("yyyy-MM-dd"));
                datos.setParametro("@fechaHasta", hasta.ToString("yyyy-MM-dd"));

                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    listaFiltrada.Add(getVentasLector(datos));
                }

                return listaFiltrada;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Venta getVentasLector(AccesoDatos datos)
        {
            Venta venta = new Venta();

            venta.Id = datos.Lector.GetInt32(0);
            if (DateTime.TryParse(datos.Lector["fecha"].ToString(), out DateTime fecha))
                venta.Fecha = fecha;
            //venta.Fecha = (DateTime)datos.Lector["fecha"];
            venta.MontoTotal = datos.Lector.GetDecimal(2);
            venta.MontoPago = datos.Lector.GetDecimal(3);
            venta.Vuelto = datos.Lector.GetDecimal(4);
            if (Enum.TryParse<FormaPago>(datos.Lector["FormaPago"].ToString(), out FormaPago fp))
                venta.FormaPago = fp;
            venta.referencia = datos.Lector["referencia"].ToString();

            return venta;
        }

        //Listar Detalle Venta por IdVenta
        public List<DetalleVenta> listarDetalleVentaPorIdVenta(int idVenta)
        {
            List<DetalleVenta> listaDetalleVentas = new List<DetalleVenta>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(consultasDetalleVenta.SqlListarDetalleVentaPorIdVentaCompleto);
                datos.setParametro("@idventa", idVenta);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    listaDetalleVentas.Add(getDetalleVentasLector(datos));
                }
                return listaDetalleVentas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private DetalleVenta getDetalleVentasLector(AccesoDatos datos)
        {
            DetalleVenta detalleVenta = new DetalleVenta();

            detalleVenta.CodBarras = (string)datos.Lector["codbarras"];
            detalleVenta.Nombre = (string)datos.Lector["nombre"];
            detalleVenta.Marca = (string)datos.Lector["marca"];
            detalleVenta.Descripcion = (string)datos.Lector["descripcion"];

            if (Enum.TryParse<TipoVenta>(datos.Lector["tipoventa"].ToString(), out TipoVenta e))
                detalleVenta.TipoVenta = e;

            detalleVenta.Cantidad = datos.Lector.GetDouble(5);
            detalleVenta.PrecioUnitario = datos.Lector.GetDecimal(6);
            detalleVenta.Subtotal = datos.Lector.GetDecimal(7);

            return detalleVenta;
        }

        //private DetalleVenta getDetalleVentasLector(AccesoDatos datos)
        //{
        //    DetalleVenta detalleVenta = new DetalleVenta();
        //    detalleVenta.Id = datos.Lector.GetInt32(0);
        //    detalleVenta.IdVenta = datos.Lector.GetInt32(1);
        //    detalleVenta.IdProducto = datos.Lector.GetInt32(2);
        //    detalleVenta.Cantidad = datos.Lector.GetDouble(3);
        //    detalleVenta.PrecioUnitario = datos.Lector.GetDecimal(4);
        //    detalleVenta.Subtotal = datos.Lector.GetDecimal(5);
        //    return detalleVenta;
        //}
    }
}