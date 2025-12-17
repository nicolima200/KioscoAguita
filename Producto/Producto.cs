
using System.ComponentModel;

namespace dominio
{
    public class Producto
    {

        public int Id {get;set;}
        [DisplayName("Código de barras")]
        public string CodBarras {get;set;}
        public string Nombre {get;set;}
        [DisplayName("Descripción")]
        public string Descripcion {get;set;}
        [DisplayName("Precio en Kiosco")]
        public double PrecioKiosco {get;set;}
        [DisplayName("Precio mayorista")]
        public double PrecioMayorista {get;set;}
        public int Stock { get; set; }
        [DisplayName("Categoría")]
        public string Categoria {get;set;}

        public Producto() { }

        /*public override string ToString()
        {
            return $"{{{nameof(id)}={id}, {nameof(codBarras)}={codBarras}, {nameof(nombre)}={nombre}, {nameof(descripcion)}={descripcion}, {nameof(categoria)}={categoria}, {nameof(precioKiosco)}={precioKiosco.ToString()}, {nameof(precioMayorista)}={precioMayorista.ToString()}, {nameof(stock)}={stock.ToString()}}}";
        }*/
    }
}
