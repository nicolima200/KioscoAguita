using dominio;
using dominio.enums;
using System;
using System.Collections.Generic;

namespace service
{
    public class ProductoService
    {

        public List<Producto> listar(bool activo =true)
        {
            List<Producto> listaProductos = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (activo)
                {
                    datos.setConsulta(consulta.SqlListarActivos);
                }else {
                    datos.setConsulta(consulta.SqlListarEliminados);
                }

                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    listaProductos.Add(getProductosLector(datos));
                }

                return listaProductos;
            }
            catch (Exception)
            {
               throw ;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Producto producto)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.setConsulta(consulta.SqlAlta);
                setearParametros(datos,producto);

                datos.ejecutarAccion();

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

        public void modificar(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(consulta.SqlActualizar);
                datos.setParametro("@id", producto.Id);
                setearParametros( datos,producto);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally {datos.cerrarConexion();}
        }

        public void actualizarStock(int id, int nuevoStock)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(consulta.SqlActualizarStock);
                datos.setParametro("@id", id);
                datos.setParametro("@sto", nuevoStock);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public void eliminarDefinitivo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(consulta.SqlEliminarDefinitivo);
                datos.setParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        //Este método sirve para eliminación o recuperación logica. Cambia el atributo 'activo'.
        public void eliminarRecuperar(int id,bool modoRecuperar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (!modoRecuperar)
                    datos.setConsulta(consulta.SqlEliminarLogicoId);
                else
                    datos.setConsulta(consulta.SqlRestaurarLogicoId);
                    datos.setParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
        }

        public Producto buscarCodBarras(string codBarras)
        {
            AccesoDatos datos= new AccesoDatos();
            datos.setConsulta(consulta.SqlBuscarCodBarras);
            datos.setParametro("@cod", codBarras);

            try
            {
                datos.ejecutarConsulta();
                if (datos.Lector.Read())
                {    
                    return getProductosLector(datos);
                }
                else
                {
                    return null;
                }
                
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

        public Producto getProductosLector(AccesoDatos datos)
        {
            // sqlListarActivos = "SELECT id,codBarras, nombre, descripcion, categoria,
            // precioMayorista, precioKiosco, stock, stockMinimo, activo, urlImagen,
            // ventaPorFraccion FROM productos where activo=1"
            Producto producto = new Producto();

            producto.Id = datos.Lector.GetInt32(0);
            producto.CodBarras = (string)datos.Lector["codBarras"];
            producto.Nombre = (string)datos.Lector["nombre"];
            producto.Descripcion = (string)datos.Lector["descripcion"];
            producto.Categoria = (string)datos.Lector["categoria"];
            producto.PrecioMayorista = datos.Lector.GetDouble(5);
            producto.PrecioKiosco = datos.Lector.GetDouble(6);
            producto.Stock = datos.Lector.GetDouble(7);
            producto.StockMinimo = datos.Lector.GetInt32(8);
            producto.Activo = datos.Lector.GetInt32(9);
            if (!(datos.Lector.IsDBNull(10)))
                producto.UrlImagen = (string)datos.Lector["urlImagen"];

            if (Enum.TryParse(datos.Lector["tipoVenta"].ToString(), out TipoVenta tipo)){
                producto.TipoVenta = tipo;
            }
            else
            {
                producto.TipoVenta = TipoVenta.Unidad; // Valor por defecto si no se puede parsear
            }

            return producto;
        }

        private void setearParametros(AccesoDatos datos, Producto producto)
        {
            datos.setParametro("@cod", producto.CodBarras);
            datos.setParametro("@nom", producto.Nombre);
            datos.setParametro("@desc", producto.Descripcion);
            datos.setParametro("@cat", producto.Categoria);
            datos.setParametro("@may", producto.PrecioMayorista);
            datos.setParametro("@kio", producto.PrecioKiosco);
            datos.setParametro("@sto", producto.Stock);
            datos.setParametro("@stockMin", producto.StockMinimo);
            datos.setParametro("@tipo", producto.TipoVenta);
            // Cuando agregamos o modificamos un producto, por defecto se envía activo=1
            // sea un producto nuevo, activo o que esté en la papelera
            datos.setParametro("@activo", 1);
            if (producto.UrlImagen == null)
                datos.setParametro("@url", DBNull.Value);
            else
                datos.setParametro("@url", producto.UrlImagen);
            
        }

    }
}
