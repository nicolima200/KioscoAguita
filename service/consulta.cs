using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consulta
    {
        
    private const string sqlAlta= "INSERT INTO Productos (id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock, stockMinimo,urlImagen,tipoVenta) VALUES (null, @cod, @nom, @desc, @cat, @may, @kio, @sto, @stockMin,@url,@tipo)";
    private const string sqlBuscarCodBarras= "SELECT id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock,stockMinimo, activo, urlImagen,tipoVenta FROM productos WHERE codBarras = @cod";
    private const string sqlBuscarCadena= "SELECT * FROM Productos WHERE nombre LIKE @nom";
    private const string sqlListarActivos = "SELECT id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock, stockMinimo, activo, urlImagen,tipoVenta FROM productos where activo=1";
    private const string sqlListarEliminados = "SELECT id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock,stockMinimo, activo, urlImagen,tipoVenta FROM productos where activo=0";
    private const string sqlActualizar = "UPDATE productos SET codBarras=@cod,nombre=@nom, descripcion=@desc, categoria=@cat,precioKiosco=@kio,precioMayorista=@may,stock=@sto, stockMinimo=@stockMin, activo=@activo, urlImagen=@url, tipoVenta=@tipo where id = @id";
    private const string sqlActualizarStock = "UPDATE productos SET stock=@sto where id = @id";

    private const string sqlEliminarLogicoId = "update productos set activo=0 WHERE id = @id";
    private const string sqlRestaurarLogicoId = "update productos set activo=1 WHERE id = @id";
    private const string sqlEliminarDefinitivo = "DELETE FROM productos WHERE id = @id";
    //private const string sqlBuscarId= "SELECT * FROM Productos WHERE id = @id";
    //private const string sqlEliminarCodBarras = "DELETE FROM productos WHERE codBarras = @cod";

        public static string SqlAlta => sqlAlta;

        public static string SqlBuscarCodBarras => sqlBuscarCodBarras;

        public static string SqlBuscarCadena => sqlBuscarCadena;

        public static string SqlListarActivos => sqlListarActivos;

        public static string SqlListarEliminados => sqlListarEliminados;

        public static string SqlEliminarLogicoId => sqlEliminarLogicoId;

        public static string SqlRestaurarLogicoId => sqlRestaurarLogicoId;

        public static string SqlActualizar => sqlActualizar;

        public static string SqlEliminarDefinitivo => sqlEliminarDefinitivo;

        public static string SqlActualizarStock => sqlActualizarStock;

        //public static string SqlBuscarId => sqlBuscarId;

        //public static string SqlEliminarId => sqlEliminarId;

        //public static string SqlEliminarCodBarras => sqlEliminarCodBarras;
    }
}
