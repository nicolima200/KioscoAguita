using System.ComponentModel;
using dominio.enums;

namespace dominio
{
    public class Producto
    {

        public int Id { get; set; }
        [DisplayName("Código de barras")]
        public string CodBarras { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("PRECIO AL \nPÚBLICO")]
        public decimal PrecioPublico { get; set; }
        [DisplayName("Precio mayorista")]
        public decimal PrecioMayorista { get; set; }
        [DisplayName("STOCK")]
        public double Stock { get; set; }
        public double StockMinimo { get; set; }
        [DisplayName("Categoría")]
        public string Categoria { get; set; }
        public int Activo { get; set; }
        public string UrlImagen { get; set; }
        // Indica si el producto se puede vender por fracciones (ejemplo: 0.5 kg de manzana)
        // Valores posibles: 1 = true, 0 = false
        public TipoVenta TipoVenta { get; set; }
        public Producto() { }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(CodBarras)}={CodBarras}, {nameof(Nombre)}={Nombre}, {nameof(Descripcion)}={Descripcion}, {nameof(PrecioPublico)}={PrecioPublico.ToString()}, {nameof(PrecioMayorista)}={PrecioMayorista.ToString()}, {nameof(Stock)}={Stock.ToString()}, {nameof(StockMinimo)}={StockMinimo.ToString()}, {nameof(Categoria)}={Categoria}, {nameof(Activo)}={Activo.ToString()}, {nameof(UrlImagen)}={UrlImagen}, {nameof(TipoVenta)}={TipoVenta.ToString()}, {nameof(Marca)}={Marca}}}";
        }
    }
}
