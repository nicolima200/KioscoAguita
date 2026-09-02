using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consulta
    {

    private const string sqlAlta= "BEGIN; " +
        "INSERT INTO categorias (descripcion) SELECT @cat WHERE @cat IS NOT NULL AND @cat <> '' AND NOT EXISTS (SELECT 1 FROM categorias WHERE descripcion = @cat); " +
        "INSERT INTO productos (codBarras, nombre, descripcion, categoriaId, marca, urlImagen, tipoVenta) " +
        "VALUES (@cod, @nom, @desc, (SELECT id FROM categorias WHERE descripcion = @cat), @marca, @url, @tipo); " +
        "INSERT INTO productos_inventario (idProducto, stock, stockMinimo, precioKiosco, precioMayorista, activo) " +
        "VALUES (last_insert_rowid(), @sto, @stockMin, @kio, @may, @activo); " +
        "COMMIT;";

    private const string columnasJoin = "p.id, p.codBarras, p.nombre, p.descripcion, COALESCE(c.descripcion,'') AS categoria, i.precioMayorista, i.precioKiosco, i.stock, i.stockMinimo, i.activo, p.urlImagen, p.tipoVenta, p.marca FROM productos p INNER JOIN productos_inventario i ON i.idProducto = p.id LEFT JOIN categorias c ON c.id = p.categoriaId";

    private const string sqlBuscarCodBarras= "SELECT " + columnasJoin + " WHERE p.codBarras = @cod";
    private const string sqlBuscarCadena= "SELECT " + columnasJoin + " WHERE p.nombre LIKE @nom";

    private const string sqlListarActivos = "SELECT " + columnasJoin + " WHERE i.activo = 1";
    private const string sqlListarEliminados = "SELECT " + columnasJoin + " WHERE i.activo = 0";

    private const string sqlActualizar = "BEGIN; " +
        "INSERT INTO categorias (descripcion) SELECT @cat WHERE @cat IS NOT NULL AND @cat <> '' AND NOT EXISTS (SELECT 1 FROM categorias WHERE descripcion = @cat); " +
        "UPDATE productos SET codBarras=@cod, nombre=@nom, descripcion=@desc, categoriaId=(SELECT id FROM categorias WHERE descripcion = @cat), urlImagen=@url, tipoVenta=@tipo, marca=@marca WHERE id = @id; " +
        "UPDATE productos_inventario SET stock=@sto, stockMinimo=@stockMin, precioKiosco=@kio, precioMayorista=@may, activo=@activo WHERE idProducto = @id; " +
        "COMMIT;";

    private const string sqlActualizarStock = "UPDATE productos_inventario SET stock=@sto WHERE idProducto = @id";

    private const string sqlEliminarLogicoId = "UPDATE productos_inventario SET activo=0 WHERE idProducto = @id";
    private const string sqlRestaurarLogicoId = "UPDATE productos_inventario SET activo=1 WHERE idProducto = @id";
    private const string sqlEliminarDefinitivo = "BEGIN; DELETE FROM productos_inventario WHERE idProducto = @id; DELETE FROM productos WHERE id = @id; COMMIT;";
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
