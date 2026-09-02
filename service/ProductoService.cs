using dominio;
using dominio.enums;
using System;
using System.ComponentModel;

namespace service
{
    public class ProductoService
    {

        public BindingList<Producto> listar(bool activo =true)
        {
            BindingList<Producto> listaProductos = new BindingList<Producto>();
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

        //public void eliminarDefinitivo(int id)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setConsulta(consulta.SqlEliminarDefinitivo);
        //        datos.setParametro("@id", id);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally { datos.cerrarConexion(); }
        //}

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
            Producto producto = new Producto();
            try
            {
                producto.Id = datos.Lector.GetInt32(0);
                producto.CodBarras = (string)datos.Lector["codBarras"];
                producto.Nombre = (string)datos.Lector["nombre"];
                producto.Descripcion = (string)datos.Lector["descripcion"];
                producto.Categoria = (string)datos.Lector["categoria"];
                producto.PrecioMayorista = datos.Lector.GetDecimal(5);
                producto.PrecioPublico = datos.Lector.GetDecimal(6);
                producto.Stock = datos.Lector.GetDouble(7);
                producto.StockMinimo = datos.Lector.GetInt32(8);
                producto.Activo = datos.Lector.GetInt32(9);

                string tipoVenta = (string)datos.Lector["tipoventa"];

                if (Enum.TryParse<TipoVenta>(tipoVenta, out TipoVenta e))
                    producto.TipoVenta = e;

                if (!(datos.Lector.IsDBNull(10)))
                    producto.UrlImagen = (string)datos.Lector["urlImagen"];

                producto.Marca = (string)datos.Lector["marca"];

                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + producto.Id.ToString());
            }
            
        }

        private void setearParametros(AccesoDatos datos, Producto producto)
        {
            datos.setParametro("@cod", producto.CodBarras);
            datos.setParametro("@nom", producto.Nombre);
            datos.setParametro("@desc", producto.Descripcion);
            datos.setParametro("@cat", producto.Categoria);
            datos.setParametro("@may", producto.PrecioMayorista);
            datos.setParametro("@kio", producto.PrecioPublico);
            datos.setParametro("@sto", producto.Stock);
            datos.setParametro("@stockMin", producto.StockMinimo);
            datos.setParametro("@tipo", producto.TipoVenta.ToString());
            datos.setParametro("@marca", producto.Marca);

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
