using System.Drawing;
using System.Windows.Forms;

namespace frmPrincipal
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnEliminarDefinitivo = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantProductosLista = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistroVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFondoTotal = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblTagPrecio = new System.Windows.Forms.Label();
            this.gbxNombre = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnLimpiarVenta = new System.Windows.Forms.Button();
            this.btnEliminarItemVenta = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.lblAtajos = new System.Windows.Forms.Label();
            this.lblAtajoEsc = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAppTitulo = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlTotalGroup = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftCard = new System.Windows.Forms.Panel();
            this.pnlRightCard = new System.Windows.Forms.Panel();
            this.pnlRightFooter = new System.Windows.Forms.Panel();
            this.pnlRightHeader = new System.Windows.Forms.Panel();
            this.pnlDetailCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTotalGroup.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLeftCard.SuspendLayout();
            this.pnlRightCard.SuspendLayout();
            this.pnlRightFooter.SuspendLayout();
            this.pnlRightHeader.SuspendLayout();
            this.pnlDetailCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToOrderColumns = true;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.ColumnHeadersHeight = 36;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.EnableHeadersVisualStyles = false;
            this.dgvPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.dgvPrincipal.Location = new System.Drawing.Point(10, 10);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.dgvPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrincipal.RowTemplate.Height = 28;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(605, 321);
            this.dgvPrincipal.TabIndex = 6;
            this.dgvPrincipal.TabStop = false;
            this.dgvPrincipal.CurrentCellChanged += new System.EventHandler(this.dgvPrincipal_CurrentCellChanged);
            this.dgvPrincipal.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_RowLeave);
            this.dgvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrincipal_KeyDown);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRecuperar.ForeColor = System.Drawing.Color.White;
            this.btnRecuperar.Location = new System.Drawing.Point(200, 80);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(160, 32);
            this.btnRecuperar.TabIndex = 1;
            this.btnRecuperar.Text = "↺  Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Visible = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 15);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "⌕  Buscar";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.BackColor = System.Drawing.Color.White;
            this.tbxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.tbxFiltro.Location = new System.Drawing.Point(112, 13);
            this.tbxFiltro.MaxLength = 50;
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(320, 25);
            this.tbxFiltro.TabIndex = 0;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            this.tbxFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxFiltro_KeyDown);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(432, 13);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(28, 25);
            this.btnLimpiarFiltro.TabIndex = 1;
            this.btnLimpiarFiltro.Text = "✕";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblNombre.Location = new System.Drawing.Point(8, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(462, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "—";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(320, 32);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "—";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPrecio.Location = new System.Drawing.Point(118, 92);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(180, 20);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "$ —";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarDefinitivo
            // 
            this.btnEliminarDefinitivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminarDefinitivo.FlatAppearance.BorderSize = 0;
            this.btnEliminarDefinitivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDefinitivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDefinitivo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDefinitivo.Location = new System.Drawing.Point(360, 80);
            this.btnEliminarDefinitivo.Name = "btnEliminarDefinitivo";
            this.btnEliminarDefinitivo.Size = new System.Drawing.Size(140, 32);
            this.btnEliminarDefinitivo.TabIndex = 14;
            this.btnEliminarDefinitivo.Text = "Borrar definitivo";
            this.btnEliminarDefinitivo.UseVisualStyleBackColor = false;
            this.btnEliminarDefinitivo.Visible = false;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblVenta.Location = new System.Drawing.Point(0, 0);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblVenta.Size = new System.Drawing.Size(118, 23);
            this.lblVenta.TabIndex = 17;
            this.lblVenta.Text = "🛒  Venta actual";
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(280, 34);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantProductosLista
            // 
            this.lblCantProductosLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCantProductosLista.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCantProductosLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblCantProductosLista.Location = new System.Drawing.Point(291, 0);
            this.lblCantProductosLista.Name = "lblCantProductosLista";
            this.lblCantProductosLista.Size = new System.Drawing.Size(200, 32);
            this.lblCantProductosLista.TabIndex = 19;
            this.lblCantProductosLista.Text = "0 productos";
            this.lblCantProductosLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.ColumnHeadersHeight = 32;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.dgvVenta.Location = new System.Drawing.Point(10, 42);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvVenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenta.RowTemplate.Height = 26;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(491, 257);
            this.dgvVenta.TabIndex = 20;
            this.dgvVenta.TabStop = false;
            this.dgvVenta.VirtualMode = true;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            this.dgvVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVenta_KeyDown);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.BackColor = System.Drawing.Color.White;
            this.tbxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbxCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.tbxCantidad.Location = new System.Drawing.Point(552, 13);
            this.tbxCantidad.MaxLength = 10;
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(64, 25);
            this.tbxCantidad.TabIndex = 0;
            this.tbxCantidad.Text = "1";
            this.tbxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxCantidad_MouseClick);
            this.tbxCantidad.Enter += new System.EventHandler(this.tbxCantidad_Enter);
            this.tbxCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCantidad_KeyDown);
            this.tbxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidad_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionar,
            this.tsmRegistroVentas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1180, 27);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmGestionar
            // 
            this.tsmGestionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.recuperarProductoToolStripMenuItem});
            this.tsmGestionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmGestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.tsmGestionar.Name = "tsmGestionar";
            this.tsmGestionar.Size = new System.Drawing.Size(140, 19);
            this.tsmGestionar.Text = "≡  Gestionar productos";
            this.tsmGestionar.Visible = false;
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarProductoToolStripMenuItem.Text = "＋  Agregar producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.modificarProductoToolStripMenuItem.Text = "✎  Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.eliminarProductoToolStripMenuItem.Text = "🗑  Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // recuperarProductoToolStripMenuItem
            // 
            this.recuperarProductoToolStripMenuItem.Name = "recuperarProductoToolStripMenuItem";
            this.recuperarProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.recuperarProductoToolStripMenuItem.Text = "↺  Recuperar producto";
            this.recuperarProductoToolStripMenuItem.Click += new System.EventHandler(this.recuperarProductoToolStripMenuItem_Click);
            // 
            // tsmRegistroVentas
            // 
            this.tsmRegistroVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.tsmRegistroVentas.Name = "tsmRegistroVentas";
            this.tsmRegistroVentas.Size = new System.Drawing.Size(131, 19);
            this.tsmRegistroVentas.Text = "▦  Registro de ventas";
            this.tsmRegistroVentas.Visible = false;
            this.tsmRegistroVentas.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCantidad.Location = new System.Drawing.Point(484, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFondoTotal
            // 
            this.lblFondoTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFondoTotal.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFondoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblFondoTotal.Location = new System.Drawing.Point(0, 0);
            this.lblFondoTotal.Name = "lblFondoTotal";
            this.lblFondoTotal.Size = new System.Drawing.Size(280, 14);
            this.lblFondoTotal.TabIndex = 24;
            this.lblFondoTotal.Text = "TOTAL";
            this.lblFondoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFondoTotal.Click += new System.EventHandler(this.lblFondoTotal_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(62)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(996, 14);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(168, 44);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.TabStop = false;
            this.btnCobrar.Text = "❚  COBRAR  —  F10";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblTagPrecio
            // 
            this.lblTagPrecio.AutoSize = true;
            this.lblTagPrecio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTagPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblTagPrecio.Location = new System.Drawing.Point(8, 96);
            this.lblTagPrecio.Name = "lblTagPrecio";
            this.lblTagPrecio.Size = new System.Drawing.Size(90, 13);
            this.lblTagPrecio.TabIndex = 26;
            this.lblTagPrecio.Text = "Precio x Unidad:";
            // 
            // gbxNombre
            // 
            this.gbxNombre.BackColor = System.Drawing.Color.White;
            this.gbxNombre.Controls.Add(this.lblNombre);
            this.gbxNombre.Controls.Add(this.lblMarca);
            this.gbxNombre.Controls.Add(this.lblDescripcion);
            this.gbxNombre.Controls.Add(this.lblTagPrecio);
            this.gbxNombre.Controls.Add(this.lblPrecio);
            this.gbxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNombre.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gbxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.gbxNombre.Location = new System.Drawing.Point(12, 12);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Padding = new System.Windows.Forms.Padding(8);
            this.gbxNombre.Size = new System.Drawing.Size(487, 118);
            this.gbxNombre.TabIndex = 2;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "DETALLE DEL PRODUCTO";
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblMarca.Location = new System.Drawing.Point(8, 40);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(462, 16);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "—";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // btnLimpiarVenta
            // 
            this.btnLimpiarVenta.BackColor = System.Drawing.Color.White;
            this.btnLimpiarVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnLimpiarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLimpiarVenta.Location = new System.Drawing.Point(359, 8);
            this.btnLimpiarVenta.Name = "btnLimpiarVenta";
            this.btnLimpiarVenta.Size = new System.Drawing.Size(132, 24);
            this.btnLimpiarVenta.TabIndex = 3;
            this.btnLimpiarVenta.Text = "✕  Cancelar venta";
            this.btnLimpiarVenta.UseVisualStyleBackColor = false;
            this.btnLimpiarVenta.Click += new System.EventHandler(this.btnLimpiarVenta_Click);
            // 
            // btnEliminarItemVenta
            // 
            this.btnEliminarItemVenta.BackColor = System.Drawing.Color.White;
            this.btnEliminarItemVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminarItemVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.btnEliminarItemVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarItemVenta.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEliminarItemVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnEliminarItemVenta.Location = new System.Drawing.Point(0, 8);
            this.btnEliminarItemVenta.Name = "btnEliminarItemVenta";
            this.btnEliminarItemVenta.Size = new System.Drawing.Size(132, 24);
            this.btnEliminarItemVenta.TabIndex = 4;
            this.btnEliminarItemVenta.Text = "🗑  Borrar item";
            this.btnEliminarItemVenta.UseVisualStyleBackColor = false;
            this.btnEliminarItemVenta.Click += new System.EventHandler(this.btnEliminarItemVenta_Click);
            // 
            // pbxProducto
            // 
            this.pbxProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pbxProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxProducto.Location = new System.Drawing.Point(499, 12);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(114, 118);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // lblAtajos
            // 
            this.lblAtajos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAtajos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAtajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblAtajos.Location = new System.Drawing.Point(860, 0);
            this.lblAtajos.Name = "lblAtajos";
            this.lblAtajos.Size = new System.Drawing.Size(304, 38);
            this.lblAtajos.TabIndex = 25;
            this.lblAtajos.Text = "F3  Buscar  •  F10  COBRAR  •  ＋/－  Cantidad";
            this.lblAtajos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAtajoEsc
            // 
            this.lblAtajoEsc.AutoSize = true;
            this.lblAtajoEsc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAtajoEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblAtajoEsc.Location = new System.Drawing.Point(190, 12);
            this.lblAtajoEsc.Name = "lblAtajoEsc";
            this.lblAtajoEsc.Size = new System.Drawing.Size(124, 13);
            this.lblAtajoEsc.TabIndex = 26;
            this.lblAtajoEsc.Text = "ESC  Limpiar búsqueda";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblAppTitulo);
            this.pnlHeader.Controls.Add(this.lblAtajos);
            this.pnlHeader.Controls.Add(this.lblAtajoEsc);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 27);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1180, 38);
            this.pnlHeader.TabIndex = 30;
            // 
            // lblAppTitulo
            // 
            this.lblAppTitulo.AutoSize = true;
            this.lblAppTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAppTitulo.Location = new System.Drawing.Point(16, 0);
            this.lblAppTitulo.Name = "lblAppTitulo";
            this.lblAppTitulo.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lblAppTitulo.Size = new System.Drawing.Size(152, 29);
            this.lblAppTitulo.TabIndex = 31;
            this.lblAppTitulo.Text = "KIOSCO26  •  VENTA";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.pnlToolbar.Controls.Add(this.lblTitulo);
            this.pnlToolbar.Controls.Add(this.tbxFiltro);
            this.pnlToolbar.Controls.Add(this.btnLimpiarFiltro);
            this.pnlToolbar.Controls.Add(this.lblCantidad);
            this.pnlToolbar.Controls.Add(this.tbxCantidad);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 65);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlToolbar.Size = new System.Drawing.Size(1180, 52);
            this.pnlToolbar.TabIndex = 31;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.pnlTotalGroup);
            this.pnlFooter.Controls.Add(this.btnCobrar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 628);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlFooter.Size = new System.Drawing.Size(1180, 72);
            this.pnlFooter.TabIndex = 32;
            // 
            // pnlTotalGroup
            // 
            this.pnlTotalGroup.BackColor = System.Drawing.Color.White;
            this.pnlTotalGroup.Controls.Add(this.lblTotal);
            this.pnlTotalGroup.Controls.Add(this.lblFondoTotal);
            this.pnlTotalGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTotalGroup.Location = new System.Drawing.Point(16, 12);
            this.pnlTotalGroup.Name = "pnlTotalGroup";
            this.pnlTotalGroup.Size = new System.Drawing.Size(280, 48);
            this.pnlTotalGroup.TabIndex = 34;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.pnlMain.Controls.Add(this.pnlLeftCard, 0, 0);
            this.pnlMain.Controls.Add(this.pnlRightCard, 1, 0);
            this.pnlMain.Controls.Add(this.pnlDetailCard, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 117);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.pnlMain.RowCount = 2;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.pnlMain.Size = new System.Drawing.Size(1180, 511);
            this.pnlMain.TabIndex = 33;
            // 
            // pnlLeftCard
            // 
            this.pnlLeftCard.BackColor = System.Drawing.Color.White;
            this.pnlLeftCard.Controls.Add(this.dgvPrincipal);
            this.pnlLeftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCard.Location = new System.Drawing.Point(19, 11);
            this.pnlLeftCard.Name = "pnlLeftCard";
            this.pnlLeftCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeftCard.Size = new System.Drawing.Size(625, 341);
            this.pnlLeftCard.TabIndex = 0;
            // 
            // pnlRightCard
            // 
            this.pnlRightCard.BackColor = System.Drawing.Color.White;
            this.pnlRightCard.Controls.Add(this.dgvVenta);
            this.pnlRightCard.Controls.Add(this.pnlRightFooter);
            this.pnlRightCard.Controls.Add(this.pnlRightHeader);
            this.pnlRightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCard.Location = new System.Drawing.Point(650, 11);
            this.pnlRightCard.Name = "pnlRightCard";
            this.pnlRightCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRightCard.Size = new System.Drawing.Size(511, 341);
            this.pnlRightCard.TabIndex = 1;
            // 
            // pnlRightFooter
            // 
            this.pnlRightFooter.Controls.Add(this.btnEliminarItemVenta);
            this.pnlRightFooter.Controls.Add(this.btnLimpiarVenta);
            this.pnlRightFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightFooter.Location = new System.Drawing.Point(10, 299);
            this.pnlRightFooter.Name = "pnlRightFooter";
            this.pnlRightFooter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlRightFooter.Size = new System.Drawing.Size(491, 32);
            this.pnlRightFooter.TabIndex = 1;
            // 
            // pnlRightHeader
            // 
            this.pnlRightHeader.Controls.Add(this.lblVenta);
            this.pnlRightHeader.Controls.Add(this.lblCantProductosLista);
            this.pnlRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlRightHeader.Name = "pnlRightHeader";
            this.pnlRightHeader.Size = new System.Drawing.Size(491, 32);
            this.pnlRightHeader.TabIndex = 0;
            // 
            // pnlDetailCard
            // 
            this.pnlDetailCard.BackColor = System.Drawing.Color.White;
            this.pnlDetailCard.Controls.Add(this.gbxNombre);
            this.pnlDetailCard.Controls.Add(this.pbxProducto);
            this.pnlDetailCard.Controls.Add(this.btnRecuperar);
            this.pnlDetailCard.Controls.Add(this.btnEliminarDefinitivo);
            this.pnlDetailCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailCard.Location = new System.Drawing.Point(19, 358);
            this.pnlDetailCard.Name = "pnlDetailCard";
            this.pnlDetailCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlDetailCard.Size = new System.Drawing.Size(625, 142);
            this.pnlDetailCard.TabIndex = 2;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco26 — Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmProductos_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductos_KeyDown);
            this.Resize += new System.EventHandler(this.frmProductos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxNombre.ResumeLayout(false);
            this.gbxNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlTotalGroup.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftCard.ResumeLayout(false);
            this.pnlRightCard.ResumeLayout(false);
            this.pnlRightFooter.ResumeLayout(false);
            this.pnlRightHeader.ResumeLayout(false);
            this.pnlRightHeader.PerformLayout();
            this.pnlDetailCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnEliminarDefinitivo;
        private Label lblVenta;
        private Label lblTotal;
        private Label lblCantProductosLista;
        private DataGridView dgvVenta;
        private TextBox tbxCantidad;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmGestionar;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem recuperarProductoToolStripMenuItem;
        private Label lblCantidad;
        private Label lblFondoTotal;
        private Button btnCobrar;
        private Label lblTagPrecio;
        private GroupBox gbxNombre;
        private Button btnLimpiarVenta;
        private Button btnEliminarItemVenta;
        private ToolStripMenuItem tsmRegistroVentas;
        private Label lblMarca;
        private Label lblAtajos;
        private Label lblAtajoEsc;
        private Panel pnlHeader;
        private Label lblAppTitulo;
        private Panel pnlToolbar;
        private Panel pnlFooter;
        private Panel pnlTotalGroup;
        private TableLayoutPanel pnlMain;
        private Panel pnlLeftCard;
        private Panel pnlRightCard;
        private Panel pnlRightHeader;
        private Panel pnlRightFooter;
        private Panel pnlDetailCard;
    }
}
