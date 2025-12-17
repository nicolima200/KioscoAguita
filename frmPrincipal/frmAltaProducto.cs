using dominio;
using System;
using System.Windows.Forms;
using dominio;
using service;

namespace frmPrincipal
{
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoService productoService = new ProductoService();
            
            try
            {
                producto.CodBarras = txbCodBarras.Text;
                producto.Nombre = txbNombre.Text;
                producto.Descripcion = txbDescripcion.Text;
                producto.Categoria = (string)cboCategoria.SelectedValue;
                producto.PrecioMayorista = double.Parse(txbPrecioMayorista.Text);
                producto.PrecioKiosco= double.Parse(txbPrecioKiosco.Text);
                producto.Stock = int.Parse(txbStock.Text);

                productoService.agregar(producto);
                MessageBox.Show("Producto agregado exitosamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService();
            
            try
            {
                cboCategoria.DataSource = categoriaService.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
