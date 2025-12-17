using dominio;
using service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            DialogResult resultado = altaProducto.ShowDialog();

            if (resultado == DialogResult.OK)
                cargar();
        }

        private void cargar()
        {
            try
            {

                ProductoService productoService = new ProductoService();
                List<Producto> listaProductos = new List<Producto>();

                listaProductos = productoService.listar();

                dgvPrincipal.DataSource = listaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
