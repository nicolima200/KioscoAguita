using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class consulta
    {
        
    private const string sqlAlta="INSERT INTO Productos (id,codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock) VALUES (null, @cod, @nom, @desc, @cat, @may, @kio, @sto)";
    private const string sqlBuscarId= "SELECT * FROM Productos WHERE id = @id";
    private const string sqlBuscarCodBarras= "SELECT * FROM Productos WHERE codBarras = @cod";
    private const string sqlBuscarCadena= "SELECT * FROM Productos WHERE nombre LIKE @nom";
    private const string sqlListar = "SELECT * FROM productos";
    private const string sqlActualizar = "UPDATE productos SET codBarras=@cod,nombre=@nom, descripcion=@desc, categoria=@cat,precioKiosco=@kio,precioMayorista=@may,stock=@sto";
    private const string sqlEliminarId = "DELETE FROM productos WHERE id = @id";
    private const string sqlEliminarCodBarras = "DELETE FROM productos WHERE codBarras = @cod";

        public static string SqlAlta => sqlAlta;

        public static string SqlBuscarId => sqlBuscarId;

        public static string SqlBuscarCodBarras => sqlBuscarCodBarras;

        public static string SqlBuscarCadena => sqlBuscarCadena;

        public static string SqlListar => sqlListar;

        public static string SqlActualizar => sqlActualizar;

        public static string SqlEliminarId => sqlEliminarId;

        public static string SqlEliminarCodBarras => sqlEliminarCodBarras;
    }
}
