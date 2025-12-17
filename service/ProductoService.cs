using dominio;
using System;
using System.Collections.Generic;

namespace service
{
    public class ProductoService
    {

        public List<Producto> listar()
        {
            List<Producto> listaProductos = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock FROM productos");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.CodBarras = (string)datos.Lector["codBarras"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.PrecioMayorista = datos.Lector.GetDouble(5);
                    aux.PrecioKiosco = datos.Lector.GetDouble(6);
                    aux.Stock = datos.Lector.GetInt32(7);
                    aux.Categoria = (string)datos.Lector["categoria"];

                    listaProductos.Add(aux);
                }

                return listaProductos;
            }
            catch (Exception ex)
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
                datos.setParametro("@cod", producto.CodBarras);
                datos.setParametro("@nom", producto.Nombre);
                datos.setParametro("@desc", producto.Descripcion);
                datos.setParametro("@cat", producto.Categoria);
                datos.setParametro("@may", producto.PrecioMayorista);
                datos.setParametro("@kio", producto.PrecioKiosco);
                datos.setParametro("@sto", producto.Stock);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
                throw;
            }
            finally
            {
                datos.cerrarConexion(); 
            }
        }
    }
}
