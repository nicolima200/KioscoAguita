using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace frmPrincipal
{
    public partial class frmVentas : Form
    {
        List<Producto> listaProductos;
        List<Producto> productosVenta;
        public frmVentas()
        {
            InitializeComponent();
        }
    }
}
