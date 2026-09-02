using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class FrmProductos : Form
    {
        private BindingList<Producto> listaProductos = new BindingList<Producto>();
        private BindingList<DetalleVenta> listaVenta = new BindingList<DetalleVenta>();

        private bool modoRecuperar = false;
        private Size tamanioInicialForm = new Size();
        private Size tamanioInicialDgvPrincipal = new Size();
        private Size tamanioInicialDgvVentas = new Size();

        //el atributo cargando evita que se ejecuten ciertos eventos mientras se está cargando la lista de productos
        private bool cargando = false;
        private Producto seleccionado = null;
        private decimal totalVenta;
        private double cantidadProductos;
        public FrmProductos()
        {
            InitializeComponent();
        }

        public FrmProductos(bool modoRecuperar = false) : this()
        {
            this.modoRecuperar = modoRecuperar;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            if (Sesion.UsuarioActual.TipoUsuario == TipoUsuario.Admin)
            {
                tsmGestionar.Visible = true;
                tsmRegistroVentas.Visible = true;
                lblAtajos.Text = "F3 - Buscar || F4 - Agregar producto || F10 - Cobrar";
            }
            else
            {
                menuStrip1.Items.Remove(tsmGestionar);
            }

            if (modoRecuperar)
            {
                modoRecuperarVisibles();
                MaximizeBox = false;

                cargarListaProductos(false);//False le indica al método que tiene que cargar los inactivos
            }
            else
            {
                obtenerTamañosFrmYDgv();

                this.Text = "Kiosco26 - VENTA | " + DateTime.Now.ToShortDateString();

                cargarListaProductos();
                dgvPrincipal_CurrentCellChanged(this, null);
                //seleccionado = productoSeleccionado();
                cargarImagen();
                lblCantProductosLista.Text = "Cantidad de productos: " + cantidadProductos.ToString();
                //tbxCantidad.Text = "1";
                configurarDgvVenta();
            }
        }

        private void obtenerTamañosFrmYDgv()
        {
            tamanioInicialForm = Size;
            tamanioInicialDgvPrincipal = dgvPrincipal.Size;
            tamanioInicialDgvVentas = dgvVenta.Size;
        }

        private void modoRecuperarVisibles()
        {
            Text = "Kiosco26 - Recuperar producto | " + DateTime.Now.ToShortDateString();
            AutoSize = false;
            Size = new Size(685, 650);

            btnLimpiarVenta.Visible = false;
            btnEliminarItemVenta.Visible = false;

            btnRecuperar.Visible = true;
            btnRecuperar.Location = new Point(240, 530);
            //btnEliminarDefinitivo.Visible = true;
            //btnEliminarDefinitivo.Location = new Point(389, 648);

            tsmGestionar.Visible = false;

            lblTitulo.Text = "Recuperar productos ";
            tbxFiltro.Location = new Point(160, 45);

            lblVenta.Visible = false;
            dgvVenta.Visible = false;
            lblCantProductosLista.Visible = false;
            lblTotal.Visible = false;
            lblFondoTotal.Visible = false;
            btnCobrar.Visible = false;
            lblCantidad.Visible = false;
            tbxCantidad.Visible = false;
            lblAtajos.Visible = false;
            gbxNombre.Visible = false;
            tsmRegistroVentas.Visible = false;
            dgvPrincipal.Size = new Size(650, 350);
            BackColor = System.Drawing.Color.Aquamarine;
            pbxProducto.Size = new Size(100, 100);
            pbxProducto.Location = new Point(280, 425);
            this.CenterToScreen();
        }

        private void cargarListaProductos(bool activo = true)
        {
            try
            {
                cargando = true;
                ProductoService productoService = new ProductoService();
                if (activo)
                    listaProductos = productoService.listar();
                else
                    listaProductos = productoService.listar(false);

                listaProductos = new BindingList<Producto>(listaProductos.OrderBy(p => p.Nombre).ToList());

                dgvPrincipal.DataSource = listaProductos;
                aplicarTemaDataGridView();
                //dgvPrincipal.Refresh();
                dgvPrincipal.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                // seteamos la primera fila como seleccionada
                if (dgvPrincipal.Rows.Count > 0)
                {
                    var primerColumnaVisible = dgvPrincipal.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Visible);

                    if (primerColumnaVisible != null)
                    {
                        dgvPrincipal.CurrentCell = dgvPrincipal.Rows[0].Cells[primerColumnaVisible.Index];
                    }

                }
                else
                {
                    seleccionado = null;
                    limpiarLabelsDetalle();
                }
                cargando = false;
            }
            catch (Exception ex)
            {
                cargando = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void colorearFilas(DataGridView dgvPrincipal)
        {
            foreach (DataGridViewRow fila in dgvPrincipal.Rows)
            {
                //    int posicion = listaProd.IndexOf(p);
                //if (dgvPrincipal.Rows.Count == 0 || dgvPrincipal.RowCount <= posicion) return;

                if (fila != null)
                {
                    double stockFila = (double)fila.Cells["stock"].Value;
                    double stockMinimoFila = (double)fila.Cells["stockminimo"].Value;

                    if (stockFila == 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.OrangeRed;

                        continue;
                    }
                    else if (stockFila <= stockMinimoFila)
                    {
                        fila.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFA3C2");
                        continue;
                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void ocultarMostrarColumnas(bool visibles = false)
        {
            dgvPrincipal.Columns["ID"].Visible = visibles;
            dgvPrincipal.Columns["Nombre"].Visible = visibles;
            dgvPrincipal.Columns["Marca"].Visible = visibles;
            dgvPrincipal.Columns["CodBarras"].Visible = visibles;
            dgvPrincipal.Columns["Activo"].Visible = visibles;
            dgvPrincipal.Columns["Eliminado"].Visible = visibles;
            dgvPrincipal.Columns["UrlImagen"].Visible = visibles;
            dgvPrincipal.RowHeadersVisible = visibles;
        }

        private Producto productoSeleccionado()
        {
            if (dgvPrincipal.CurrentRow == null) return null;

            return dgvPrincipal.CurrentRow.DataBoundItem as Producto;
        }

        //CARGAR/LIMPIAR IMAGEN Y DETALLE:
        private void cargarImagen()
        {
            if (seleccionado != null)
            {
                Helper.cargarImg(pbxProducto, seleccionado.UrlImagen);
            }
            //else
            //{
            //    Helper.cargarImg(pbxProducto, "");
            //}
        }
        private void cargarDetalle()
        {
            if (seleccionado != null)
            {
                lblNombre.Text = seleccionado.Nombre;
                lblMarca.Text = seleccionado.Marca;
                lblDescripcion.Text = seleccionado.Descripcion;
                lblPrecio.Text = "$ " + seleccionado.PrecioPublico.ToString();
                lblTagPrecio.Text = "Precio x " + seleccionado.TipoVenta.ToString();
            }
            else
            {
                limpiarLabelsDetalle();
            }
        }
        private void limpiarLabelsDetalle()
        {
            lblNombre.Text = "";
            lblMarca.Text = "";
            lblDescripcion.Text = "";
            lblPrecio.Text = "";
            lblTagPrecio.Text = "";
        }
        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tbxFiltro.Clear();
            tbxFiltro.Focus();
        }
        /****/
        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFiltro.Text))
            {
                dgvPrincipal.DataSource = listaProductos;
                aplicarTemaDataGridView();
                return;
            }

            if (tbxFiltro.Text.Length > 0)
            {
                List<Producto> listaAux;
                BindingList<Producto> listaFiltrada;

                string filtro = tbxFiltro.Text.ToLower();

                //Primero convierto la binding list a una lista normal para poder usar el FindAll

                listaAux = listaProductos.ToList();
                listaAux = listaAux.FindAll(x => x.Nombre.ToLower().Contains(filtro) || x.Marca.ToLower().Contains(filtro) || x.Descripcion.ToLower().Contains(filtro) || x.CodBarras.Contains(filtro));

                listaFiltrada = new BindingList<Producto>(listaAux.OrderBy(p => p.Nombre.Length).ToList()); //.ThenBy(p => p.Nombre).ToList());
                //listaProductos = new BindingList<Producto>(listaProductos.OrderBy(p => p.Nombre).ThenBy(p => p.Nombre.Length).ToList());

                dgvPrincipal.DataSource = listaFiltrada;
                aplicarTemaDataGridView();
            }

            if (dgvPrincipal.Rows.Count > 0)
            {
                //Asegurarse que el número de celda corresponda a una columna que no esté marcada como 'no visible'
                var primerColumnaVisible = dgvPrincipal.Columns.Cast<DataGridViewColumn>().ToList().FirstOrDefault(x => x.Visible);
                dgvPrincipal.CurrentCell = dgvPrincipal.Rows[0].Cells[primerColumnaVisible.Index];
                //dgvPrincipal.CurrentCell = dgvPrincipal.Rows[0].Cells[1];
                dgvPrincipal.Rows[0].Selected = true;
                Producto prueba = (Producto)dgvPrincipal.CurrentRow.DataBoundItem;
            }
            else
            {
                dgvPrincipal.ClearSelection();
                Helper.cargarImg(pbxProducto, "");
                limpiarLabelsDetalle();
            }
        }

        private void aplicarTemaDataGridView()
        {
            colorearFilas(dgvPrincipal);
            ocultarMostrarColumnas();
        }

        //ENTER agrega producto a la venta:
        private void tbxFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && seleccionado != null)
            {
                if (!modoRecuperar)
                    agregarProductoVenta();
                else
                    btnRecuperar.PerformClick();
            }
        }

        private void dgvPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (!modoRecuperar)
            {
                if (e.KeyCode == Keys.Enter && seleccionado != null)
                {
                    if (seleccionado.Stock <= 0)
                    {
                        e.Handled = true;
                        tbxFiltro.Focus();
                        return;
                    }

                    //Para evitar que la selección de vaya al siguiente registro luego de presionar enter
                    e.Handled = true;

                    agregarProductoVenta();
                }
            }
            else
            {
                e.Handled = true;
                btnRecuperar.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
                e.Handled = true;
        }
        private void tbxCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && seleccionado != null)
            {
                agregarProductoVenta();
            }
        }
        private void tbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //COMPROBAR EL TIPO DE VENTA DEL PRODUCTO SELECCIONADO PARA PERMITIR O NO EL USO DE DECIMALES
            if (seleccionado != null && seleccionado.TipoVenta.ToString() == "Unidad")
                Helper.soloNumerosKeyPress(e);
            else
            {
                Helper.soloDecimal(e, tbxCantidad);
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!tbxCantidad.Text.Contains(","))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        /****/

        //GESTIÓN DE PRODUCTOS:
        private void agregarProducto()
        {
            frmAltaProducto altaProducto = new frmAltaProducto();
            DialogResult resultado = altaProducto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                cargarListaProductos();
                agregarProducto();
            }
            cargarListaProductos();
            dgvPrincipal_CurrentCellChanged(this, null);
        }
        private void modificarProducto()
        {
            Producto productoSeleccionado;

            if (dgvPrincipal.SelectedRows != null && dgvPrincipal.RowCount > 0)
                productoSeleccionado = (Producto)dgvPrincipal.SelectedRows[0].DataBoundItem;
            else
                return;

            frmAltaProducto modificarProducto = new frmAltaProducto(productoSeleccionado);
            DialogResult resultado = modificarProducto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                cargarListaProductos();
                if (tbxFiltro.Text.Length > 0)
                    tbxFiltro_TextChanged(this, null);
            }
            cargarImagen();
            dgvPrincipal_CurrentCellChanged(this, null);
            tbxFiltro.Focus();
            tbxFiltro.SelectAll();
        }
        private void eliminarProducto()
        {
            ProductoService productoService = new ProductoService();
            Producto producto = productoSeleccionado();

            try
            {
                if (producto == null)
                    return;

                if (!modoRecuperar)
                {
                    string cadena = "¿Está seguro que desea eliminar " + producto.Nombre + " " + producto.Marca + " " + producto.Descripcion + " ?";

                    DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        productoService.eliminarRecuperar(producto.Id, modoRecuperar);
                        cargarListaProductos();
                    }
                }
                else
                {
                    string cadena = "¿Está seguro que desea recuperar " + producto.Nombre + " " + producto.Marca + " " + producto.Descripcion + " ?";
                    DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        productoService.eliminarRecuperar(producto.Id, modoRecuperar);
                        cargarListaProductos(false);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void menuRecuperarProducto()
        {
            FrmProductos menuRecuperarProducto = new FrmProductos(true);
            menuRecuperarProducto.ShowDialog();
            cargarListaProductos();
        }
        private void agregarProductoVenta()
        {
            if (dgvPrincipal.DisplayedRowCount(true) == 0) return;
            if (seleccionado == null) return;
            if (seleccionado.Stock == 0) {
                MessageBox.Show("No hay STOCK","ATENCIÓN");
                tbxFiltro.Focus();
                tbxFiltro.SelectAll();
                return;
            } 
            if (seleccionado.PrecioPublico <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.","ATENCIÓN");
                tbxFiltro.Focus();
                tbxFiltro.SelectAll();
                return;
            }
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

                if (cantNuevoItem > seleccionado.Stock)
                {
                    MessageBox.Show("La cantidad ingresada supera el stock disponible (" + seleccionado.Stock + "). Por favor, ingrese una cantidad válida.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxCantidad.Text = seleccionado.Stock.ToString();
                    tbxCantidad.SelectAll();
                    return;
                }

                seleccionado.Stock -= cantNuevoItem;

                DetalleVenta itemExistente = listaVenta.FirstOrDefault(x => x.IdProducto == seleccionado.Id);

                if (itemExistente != null)
                {
                    itemExistente.Cantidad += cantNuevoItem;
                    itemExistente.Subtotal = itemExistente.PrecioUnitario * (decimal)itemExistente.Cantidad;
                }
                else
                {
                    //string descNuevoItem = seleccionado.Nombre + " " + seleccionado.Descripcion;

                    DetalleVenta nuevoItem = new DetalleVenta
                    {
                        IdProducto = seleccionado.Id,
                        CodBarras = seleccionado.CodBarras,
                        Nombre = seleccionado.Nombre,
                        Marca = seleccionado.Marca,
                        Descripcion = seleccionado.Descripcion,
                        Cantidad = cantNuevoItem,
                        PrecioUnitario = seleccionado.PrecioPublico,
                        TipoVenta = seleccionado.TipoVenta,
                        Subtotal = seleccionado.PrecioPublico * (decimal)cantNuevoItem
                    };

                    listaVenta.Add(nuevoItem);
                }

                dgvPrincipal.Refresh();
                aplicarTemaDataGridView();
                dgvVenta.Refresh();

                actualizarLblTotalYCantidad();

                tbxCantidad.Text = "1";

                tbxFiltro.Focus();
                tbxFiltro.SelectAll();
            }
            else
            {
                tbxCantidad.Text = "1";
                return;
            }

        }

        private void actualizarLblTotalYCantidad()
        {
            sumaTotalYCantidadProd();
            lblCantProductosLista.Text = "Cantidad de productos: " + cantidadProductos.ToString();
            lblTotal.Text = "$ " + totalVenta.ToString();
        }
        private void sumaTotalYCantidadProd()
        {
            cantidadProductos = 0;
            totalVenta = 0;

            if (listaVenta.Count == 0)
            {
                return;
            }
            ///DISTINGUIR entre productos por cantidad y por peso
            foreach (DetalleVenta itemLista in listaVenta)
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


        }
        private void eliminarProductoVenta()
        {
            ////REVISAR ESTA LÓGICA (INDICE DE LISTA SIEMPRE CORRESPONDE CON INDICE DEL DGV?)
            if (dgvVenta.CurrentRow != null)
            {
                int indiceSeleccionado = dgvVenta.CurrentRow.Index;
                //if (dgvVenta.DisplayedRowCount(true) == 0)
                //    return;
                listaVenta.RemoveAt(indiceSeleccionado);
            }

            actualizarLblTotalYCantidad();
            dgvVenta.Refresh();
            aplicarTemaDataGridView();
        }


        //METODOS DEL MENÚ:
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
            menuRecuperarProducto();
        }
        /****/
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                frmCobro frmCobro = new frmCobro(totalVenta, listaVenta);
                DialogResult resultado = frmCobro.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    listaVenta.Clear();
                    actualizarLblTotalYCantidad();
                    dgvPrincipal.Refresh();
                }
                tbxFiltro.Focus();

            }
            else
            {
                tbxFiltro.Focus();
            }
        }
        private void frmProductos_Shown(object sender, EventArgs e)
        {
            tbxFiltro.Focus();
        }
        private void btnEliminarItemVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.DisplayedRowCount(true) == 0)
            {
                tbxFiltro.Focus();
                return;
            }

            DetalleVenta productoAEliminar = new DetalleVenta();

            if (dgvVenta.CurrentRow.DataBoundItem != null)
                productoAEliminar = dgvVenta.CurrentRow.DataBoundItem as DetalleVenta;
            else
                return;

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado de la venta actual?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                restaurarStock(productoAEliminar);
                eliminarProductoVenta();
                aplicarTemaDataGridView();
                dgvPrincipal.Refresh();
            }
            tbxFiltro.Focus();
        }

        private void restaurarStock(DetalleVenta productoAEliminar)
        {
            foreach (Producto producto in listaProductos)
            {
                if (producto.Id == productoAEliminar.IdProducto)
                {
                    producto.Stock += productoAEliminar.Cantidad;
                    break;
                }
            }
        }

        private void dgvVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                e.Handled = true;
        }
        private void frmProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                e.Handled = true;
                btnCobrar.PerformClick();
            }
            if (e.KeyCode == Keys.F4 && tsmRegistroVentas.Visible)
            {
                e.Handled = true;
                agregarProductoToolStripMenuItem.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
                tbxFiltro.Focus();
            if (e.KeyCode == Keys.Escape)
                tbxFiltro.Clear();
            
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
                if (double.TryParse(tbxCantidad.Text, out double valAdd))
                    tbxCantidad.Text = (valAdd + 1).ToString();
                else
                    tbxCantidad.Text = "1";
            }
            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                e.SuppressKeyPress = true;
                if (double.TryParse(tbxCantidad.Text, out double valSub) && valSub > 1)
                    tbxCantidad.Text = (valSub - 1).ToString();
                else if (!double.TryParse(tbxCantidad.Text, out _))
                    tbxCantidad.Text = "1";

            }

        }
        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!modoRecuperar)
            {
                DialogResult respuesta = MessageBox.Show("¿Está Seguro que desea salir?\n¡Perderá la venta actual!", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnLimpiarVenta_Click(object sender, EventArgs e)
        {
            listaVenta.Clear();
            cargarListaProductos();
            dgvPrincipal_CurrentCellChanged(this, null);
            //dgvVenta.Refresh();
            actualizarLblTotalYCantidad();
            tbxFiltro.Focus();
        }

        private void dgvPrincipal_CurrentCellChanged(object sender, EventArgs e)
        {
            if (cargando == true) return;
            seleccionado = productoSeleccionado();
            cargarImagen();
            cargarDetalle();

            if (seleccionado != null)
                if (seleccionado.Stock > 0)
                {
                    dgvPrincipal.DefaultCellStyle.SelectionForeColor = Color.Black;
                    //tbxCantidad.Text = "1";

                }
                else
                    dgvPrincipal.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
        }

        private void configurarDgvVenta()
        {

            dgvVenta.DataSource = listaVenta;


            dgvVenta.Columns["id"].Visible = false;
            dgvVenta.Columns["idVenta"].Visible = false;
            dgvVenta.Columns["idProducto"].Visible = false;
            dgvVenta.Columns["CodBarras"].Visible = false;
            dgvVenta.Columns["marca"].Visible = false;
            dgvVenta.Columns["CodBarras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvVenta.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvVenta.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void tbxCantidad_Enter(object sender, EventArgs e)
        {
            tbxCantidad.SelectionStart = tbxCantidad.Text.Length;
            tbxCantidad.SelectAll();
        }

        private void tbxCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            tbxCantidad.SelectionStart = tbxCantidad.Text.Length;
            tbxCantidad.SelectAll();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVentas registroVentas = new frmRegistroVentas();
            registroVentas.Show();
        }

        private void frmProductos_Resize(object sender, EventArgs e)
        {
            if (modoRecuperar) return;
            redimensionarItemsAlMaximizar();
        }

        private void redimensionarItemsAlMaximizar()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                double factorAncho = Size.Width / tamanioInicialForm.Width * 1.25;
                double factorAlto = (Size.Height / tamanioInicialForm.Height) * 1.5;

                dgvPrincipal.Size = new Size((int)(tamanioInicialDgvPrincipal.Width * factorAncho), (int)(tamanioInicialDgvPrincipal.Height * factorAlto));
                dgvVenta.Size = new Size((int)(tamanioInicialDgvVentas.Width * factorAncho * 0.8), (int)(tamanioInicialDgvVentas.Height * factorAlto * 0.8));
            }
            else
            {
                dgvPrincipal.Size = tamanioInicialDgvPrincipal;
                dgvVenta.Size = tamanioInicialDgvVentas;
            }
        }

        private void dgvPrincipal_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (seleccionado != null)
            {
                dgvPrincipal.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFondoTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        //private void FrmProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyValue == '-' || e.KeyValue == '+') return;
        //}
    }
    //BOTONES PRINCIPALES ------------ ELIMINAR???:
    //private void btnAgregar_Click(object sender, EventArgs e)
    //{
    //    agregarProducto();
    //}
    //private void btnModificar_Click(object sender, EventArgs e)
    //{
    //    modificarProducto();
    //}
    //private void btnEliminar_Click(object sender, EventArgs e)
    //{
    //    eliminarProducto();
    //}

    /****/
    //private void btnEliminarDefinitivo_Click(object sender, EventArgs e)
    //{
    //    ProductoService productoService = new ProductoService();
    //    Producto productoSeleccionado;

    //    try
    //    {
    //        if (dgvPrincipal.CurrentRow != null)
    //            productoSeleccionado = dgvPrincipal.CurrentRow.DataBoundItem as Producto;
    //        else
    //            return;

    //        string cadena = "¿Está seguro que desea ELIMINAR DEFINITIVAMENTE el producto " + productoSeleccionado.Nombre + " " + productoSeleccionado.Descripcion + " ?"
    //            + "\n¡NO PODRÁ RECUPERAR EL PRODUCTO!";

    //        DialogResult resultado = MessageBox.Show(cadena, "ADVERTENCIA: ELIMINACIÓN DEFINITIVA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

    //        if (resultado == DialogResult.Yes)
    //        {
    //            productoService.eliminarDefinitivo(productoSeleccionado.Id);
    //            cargarListaProductos(false);
    //        }
    //        if (dgvPrincipal.Rows.Count == 0)
    //        {
    //            dgvPrincipal.ClearSelection();
    //            Helper.cargarImg(pbxProducto, "");
    //            limpiarLabelsDetalle();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.ToString());
    //    }
    //}
    /***/
}

