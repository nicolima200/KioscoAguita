using dominio;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmProductos : Form
    {
        private List<Producto> listaProductos;
        private bool modoRecuperar = false;
        private BindingList<ItemVenta> listaVenta = new BindingList<ItemVenta>();
        private Producto seleccionado = null;
        private double totalVenta = 0;
        private double cantidadProductos = 0;
        public frmProductos()
        {
            InitializeComponent();
            this.modoRecuperar = false;
        }

        public frmProductos(bool modoRecuperar)
        {
            InitializeComponent();
            this.modoRecuperar = modoRecuperar;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (modoRecuperar)
            {
                this.Text = "Gestor Kiosco - Recuperar producto | " + DateTime.Now.ToShortDateString();
                btnFrmRecuperar.Visible = false;
                btnAgregar.Visible = false;
                btnModificar.Visible = false;

                btnRecuperar.Visible = true;
                btnEliminarDefinitivo.Visible = true;

                lblTitulo.Text = "Recuperar productos ";
                lblRecuperar.Visible = false;

                lblVenta.Visible = false;
                dgvVenta.Visible = false;
                lblCantProductosLista.Visible = false;
                lblTotal.Visible = false;

                cargar(false);//False le indica al método que tiene que cargar los inactivos
            }
            else
            {
                this.Text = "Gestor Kiosco - Vender | " + DateTime.Now.ToShortDateString();
                cargar();
                lblCantProductosLista.Text = "Cantidad de productos: 0";
                tbxCantidad.Text = "1";
                dgvVenta.DataSource = listaVenta;
                //limpiarLabelsDetalle();
            }
        }

        private void cargar(bool activo = true)
        {
            try
            {

                ProductoService productoService = new ProductoService();
                listaProductos = new List<Producto>();
                if (activo)
                    listaProductos = productoService.listar();
                else
                    listaProductos = productoService.listar(false);

                dgvPrincipal.DataSource = listaProductos;
                ocultarMostrarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ocultarMostrarColumnas(bool visibles = false)
        {
            dgvPrincipal.Columns["ID"].Visible = visibles;
            dgvPrincipal.Columns["Activo"].Visible = visibles;
            dgvPrincipal.Columns["UrlImagen"].Visible = visibles;
            dgvPrincipal.RowHeadersVisible = visibles;
        }

        //BOTONES PRINCIPALES ------------ ELIMINAR???:
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarProducto();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            recuperarProducto();

        }
        /****/

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            cargarImagen();
            cargarDetalle();
            seleccionado = productoSeleccionado();
        }
        private void btnEliminarDefinitivo_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            Producto productoSeleccionado;

            try
            {
                if (dgvPrincipal.CurrentRow != null)
                    productoSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Producto;
                else
                    return;

                string cadena = "¿Está seguro que desea eliminar DEFINITIVAMENTE el producto " + productoSeleccionado.Nombre + " " + productoSeleccionado.Descripcion + " ?"
                    + "\n¡NO PODRÁ RECUPERAR EL PRODUCTO!";

                DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA: ELIMINACIÓN DEFINITIVA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    productoService.eliminarDefinitivo(productoSeleccionado.Id);
                    cargar(false);
                }
                if (dgvPrincipal.Rows.Count == 0)
                {
                    dgvPrincipal.ClearSelection();
                    Helper.cargarImg(pbxProducto, "");
                    limpiarLabelsDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Producto productoSeleccionado()
        {
            Producto productoSeleccionado = null;
            if (dgvPrincipal.CurrentRow != null)
            {
                return productoSeleccionado = (Producto)dgvPrincipal.CurrentRow.DataBoundItem;
            }
            return productoSeleccionado;
        }

        //CARGAR/LIMPIAR IMAGEN Y DETALLE:
        private void cargarImagen()
        {
            if (productoSeleccionado() != null)
            {
                Helper.cargarImg(pbxProducto, productoSeleccionado().UrlImagen);
            }
            //else
            //{
            //    Helper.cargarImg(pbxProducto, "");
            //}
        }
        private void cargarDetalle()
        {
            Producto productoSeleccionado;
            if (dgvPrincipal.CurrentRow.DataBoundItem != null)
            {
                productoSeleccionado = (Producto)dgvPrincipal.CurrentRow.DataBoundItem;
                lblNombre.Text = productoSeleccionado.Nombre;
                lblDescripcion.Text = productoSeleccionado.Descripcion;
                lblPrecio.Text = "$ " + productoSeleccionado.PrecioKiosco.ToString();
            }
            else
            {
                limpiarLabelsDetalle();
            }
        }
        private void limpiarLabelsDetalle()
        {
            lblNombre.Text = "";
            lblDescripcion.Text = "";
            lblPrecio.Text = "";
        }
        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tbxFiltro.Clear();
        }
        /****/
        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFiltro.Text))
            {
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = listaProductos;
                //DgvPrincipal.CurrentCell = DgvPrincipal.Rows[0].Cells[1];
            }

            if (tbxFiltro.Text.Length > 0)
            {
                List<Producto> listaFiltrada;
                string filtro = tbxFiltro.Text.ToLower();

                listaFiltrada = listaProductos.FindAll(x => x.Nombre.ToLower().Contains(filtro) || x.Categoria.ToLower().Contains(filtro) || x.Descripcion.ToLower().Contains(filtro) || x.CodBarras.Contains(filtro));

                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = listaFiltrada;

            }
            if (dgvPrincipal.Rows.Count > 0)
            {
                dgvPrincipal.CurrentCell = dgvPrincipal.Rows[0].Cells[1];
                dgvPrincipal.Rows[0].Selected = true;
                Producto prueba = (Producto)dgvPrincipal.CurrentRow.DataBoundItem;
            }
            else
            {
                dgvPrincipal.ClearSelection();
                Helper.cargarImg(pbxProducto, "");
                limpiarLabelsDetalle();
            }
            ocultarMostrarColumnas();
        }

        //ENTER agrega producto a la venta:
        private void tbxFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && seleccionado != null)
                agregarProductoVenta();
        }
        private void dgvPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && seleccionado != null)
            {
                //Para evitar que la selección de vaya al siguiente registro luego de presionar enter
                e.Handled = true;

                agregarProductoVenta();
            }
        }
        private void tbxCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && seleccionado != null)
            {
                agregarProductoVenta();
            }
        }
        /****/

        //GESTIÓN DE PRODUCTOS:
        private void agregarProducto()
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            DialogResult resultado = altaProducto.ShowDialog();

            if (resultado == DialogResult.OK)
                cargar();
        }
        private void modificarProducto()
        {
            Producto productoSeleccionado;
            if (dgvPrincipal.CurrentRow != null)
                productoSeleccionado = (Producto)dgvPrincipal.CurrentRow.DataBoundItem;
            else
                return;

            frmAltaProducto modificarProducto = new frmAltaProducto(productoSeleccionado);
            DialogResult resultado = modificarProducto.ShowDialog();

            if (resultado == DialogResult.OK)
                cargar();
        }
        private void eliminarProducto()
        {
            ProductoService productoService = new ProductoService();
            Producto productoSeleccionado;

            try
            {
                if (dgvPrincipal.CurrentRow != null)
                    productoSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Producto;
                else
                    return;

                if (!modoRecuperar)
                {
                    string cadena = "¿Está seguro que desea eliminar " + productoSeleccionado.Nombre + " " + productoSeleccionado.Descripcion + " ?";

                    DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        productoService.eliminarRecuperar(productoSeleccionado.Id, modoRecuperar);
                        cargar();
                    }
                }
                else
                {
                    string cadena = "¿Está seguro que desea recuperar " + productoSeleccionado.Nombre + " " + productoSeleccionado.Descripcion + " ?";
                    DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        productoService.eliminarRecuperar(productoSeleccionado.Id, modoRecuperar);
                        cargar(false);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void recuperarProducto()
        {
            frmProductos recuperarProducto = new frmProductos(true);
            recuperarProducto.ShowDialog();
            cargar();
        }
        private void agregarProductoVenta()
        {
            //Validamos valor decimal del textbox cantidad
            if (Helper.validarTxbNumericos(tbxCantidad, false))
            {
                double cantNuevoItem = double.Parse(tbxCantidad.Text);
                if (cantNuevoItem <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero. Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxCantidad.Text = "1";
                    return;
                }

                ItemVenta existente = null;
                int indice = 0;

                //Cantidad a agregar al listado de la venta actual
                string descNuevoItem = seleccionado.Nombre + " " + seleccionado.Descripcion;

                //Item a agregar al listado de la venta actual
                ItemVenta nuevoItem = new ItemVenta
                {
                    CodBarras = seleccionado.CodBarras,
                    Descripcion = descNuevoItem,
                    Cantidad = cantNuevoItem,
                    PrecioUnitario = seleccionado.PrecioKiosco,
                    TipoVenta = seleccionado.TipoVenta,
                    Subtotal = seleccionado.PrecioKiosco * cantNuevoItem
                };


                foreach (ItemVenta itemLista in listaVenta)
                {
                    if (nuevoItem.CodBarras.Equals(itemLista.CodBarras))
                    {
                        existente = itemLista;
                        indice = listaVenta.IndexOf(itemLista);
                        break;
                    }
                }

                //Si el producto ya existe en la lista de venta, sumamos la cantidad
                if (existente != null)
                {
                    double nuevaCantTotal = existente.Cantidad + nuevoItem.Cantidad;

                    if ((nuevaCantTotal) > seleccionado.Stock)
                    {
                        MessageBox.Show("La cantidad ingresada supera el stock disponible (" + seleccionado.Stock + "). Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (seleccionado.Stock - existente.Cantidad >= 0)
                            tbxCantidad.Text = (seleccionado.Stock - existente.Cantidad).ToString();
                        //else
                        //    tbxCantidad.Text = seleccionado.Stock.ToString();
                        return;
                    }
                    else
                    {
                        //deducimos del stock
                        double nuevoStock = seleccionado.Stock - nuevaCantTotal;

                        //Agregamos la cantidad al prod ya existente
                        listaVenta[indice].Cantidad = nuevaCantTotal;
                        listaVenta[indice].Subtotal = listaVenta[indice].PrecioUnitario * listaVenta[indice].Cantidad;
                    }

                }
                //Si no existe, lo agregamos a la lista
                else if (nuevoItem.Cantidad > seleccionado.Stock)
                {
                    MessageBox.Show("La cantidad ingresada supera el stock disponible (" + seleccionado.Stock + "). Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (seleccionado.Stock >= 0)
                        tbxCantidad.Text = seleccionado.Stock.ToString();
                    
                    return;
                }
                else
                {
                    double nuevaCantTotal = nuevoItem.Cantidad;

                    listaVenta.Add(nuevoItem);
                    //deducimos del stock
                    double nuevoStock = seleccionado.Stock - nuevaCantTotal;

                }
                //DialogResult realizarVenta si OK actualizar stock en BD y recargar DGV
                //Actualizamos el stock en BD
                //modificarStockProducto(seleccionado.Id, nuevoStock);
            }
            else { 
                tbxCantidad.Text = "1";
                return; 
            }

            //dgvVenta.DataSource = null;
            //dgvVenta.DataSource = listaVenta;
            dgvVenta.RowHeadersVisible = false;

            tbxCantidad.Text = "1";

            

            ///DISTINGUIR entre productos por cantidad y por peso
            foreach (ItemVenta itemLista in listaVenta)
            {
                //Si el producto se vende por fraccion (kg, lt, mt, etc)
                //En la lista se cuenta como 1 producto
                //Crear los atributos correspondientes (en Producto y ItemVenta),modificar service y frm de alta
                //para poder especificar el tipo de venta.
                if (itemLista.TipoVenta.ToString() != "Unidad")
                {
                    cantidadProductos += 1;
                }
                else
                {
                    cantidadProductos += itemLista.Cantidad;
                }
                totalVenta += itemLista.Subtotal;
            }

            lblCantProductosLista.Text = "Cantidad de productos: " + cantidadProductos.ToString();
            lblTotal.Text = "$ " + totalVenta.ToString();

            dgvVenta.Refresh();
            tbxFiltro.Focus();
        }
        /***/

        //METODOS DE LOS MENÚS CONTEXTUALES:
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarProducto();
        }

        private void recuperarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recuperarProducto();
        }
        /****/
        private void tbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.soloDecimal(e, tbxCantidad);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

        }
    }
}
