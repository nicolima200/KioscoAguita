using System.Windows.Forms;

namespace frmPrincipal
{
    partial class FrmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToOrderColumns = true;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPrincipal.Location = new System.Drawing.Point(6, 68);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(510, 206);
            this.dgvPrincipal.TabIndex = 6;
            this.dgvPrincipal.TabStop = false;
            this.dgvPrincipal.CurrentCellChanged += new System.EventHandler(this.dgvPrincipal_CurrentCellChanged);
            this.dgvPrincipal.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_RowLeave);
            this.dgvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrincipal_KeyDown);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecuperar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRecuperar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecuperar.Location = new System.Drawing.Point(385, 335);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(173, 48);
            this.btnRecuperar.TabIndex = 1;
            this.btnRecuperar.Text = "Recuperar producto";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Visible = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 16);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Buscar productos:";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltro.Location = new System.Drawing.Point(133, 45);
            this.tbxFiltro.MaxLength = 50;
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(180, 22);
            this.tbxFiltro.TabIndex = 0;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            this.tbxFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxFiltro_KeyDown);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.AutoSize = true;
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(315, 45);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(21, 21);
            this.btnLimpiarFiltro.TabIndex = 1;
            this.btnLimpiarFiltro.Text = "X";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(6, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(255, 19);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Navy;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 71);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(254, 34);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.Location = new System.Drawing.Point(113, 106);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 20);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Tag = "Precio";
            this.lblPrecio.Text = "            ";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEliminarDefinitivo
            // 
            this.btnEliminarDefinitivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarDefinitivo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarDefinitivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEliminarDefinitivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarDefinitivo.Location = new System.Drawing.Point(444, 161);
            this.btnEliminarDefinitivo.Name = "btnEliminarDefinitivo";
            this.btnEliminarDefinitivo.Size = new System.Drawing.Size(173, 48);
            this.btnEliminarDefinitivo.TabIndex = 14;
            this.btnEliminarDefinitivo.Text = "Borrar definitivo";
            this.btnEliminarDefinitivo.UseVisualStyleBackColor = false;
            this.btnEliminarDefinitivo.Visible = false;
            // 
            // lblVenta
            // 
            this.lblVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVenta.AutoSize = true;
            this.lblVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVenta.Location = new System.Drawing.Point(518, 49);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(97, 16);
            this.lblVenta.TabIndex = 17;
            this.lblVenta.Text = "Venta actual:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Lime;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(664, 386);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 31);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantProductosLista
            // 
            this.lblCantProductosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantProductosLista.AutoSize = true;
            this.lblCantProductosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantProductosLista.Location = new System.Drawing.Point(517, 323);
            this.lblCantProductosLista.Name = "lblCantProductosLista";
            this.lblCantProductosLista.Size = new System.Drawing.Size(167, 17);
            this.lblCantProductosLista.TabIndex = 19;
            this.lblCantProductosLista.Text = "Cantidad de productos: 0";
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.Location = new System.Drawing.Point(521, 68);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(503, 245);
            this.dgvVenta.StandardTab = true;
            this.dgvVenta.TabIndex = 20;
            this.dgvVenta.TabStop = false;
            this.dgvVenta.VirtualMode = true;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            this.dgvVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVenta_KeyDown);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tbxCantidad.Location = new System.Drawing.Point(444, 44);
            this.tbxCantidad.MaxLength = 10;
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(28, 23);
            this.tbxCantidad.TabIndex = 0;
            this.tbxCantidad.Text = "1";
            this.tbxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxCantidad_MouseClick);
            this.tbxCantidad.Enter += new System.EventHandler(this.tbxCantidad_Enter);
            this.tbxCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCantidad_KeyDown);
            this.tbxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidad_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionar,
            this.tsmRegistroVentas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
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
            this.tsmGestionar.Name = "tsmGestionar";
            this.tsmGestionar.Size = new System.Drawing.Size(126, 20);
            this.tsmGestionar.Text = "Gestionar productos";
            this.tsmGestionar.Visible = false;
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // recuperarProductoToolStripMenuItem
            // 
            this.recuperarProductoToolStripMenuItem.Name = "recuperarProductoToolStripMenuItem";
            this.recuperarProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.recuperarProductoToolStripMenuItem.Text = "Recuperar producto";
            this.recuperarProductoToolStripMenuItem.Click += new System.EventHandler(this.recuperarProductoToolStripMenuItem_Click);
            // 
            // tsmRegistroVentas
            // 
            this.tsmRegistroVentas.Name = "tsmRegistroVentas";
            this.tsmRegistroVentas.Size = new System.Drawing.Size(115, 20);
            this.tsmRegistroVentas.Text = "Registro de ventas";
            this.tsmRegistroVentas.Visible = false;
            this.tsmRegistroVentas.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCantidad.Location = new System.Drawing.Point(369, 48);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 16);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFondoTotal
            // 
            this.lblFondoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFondoTotal.AutoSize = true;
            this.lblFondoTotal.BackColor = System.Drawing.Color.Lime;
            this.lblFondoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoTotal.ForeColor = System.Drawing.Color.White;
            this.lblFondoTotal.Location = new System.Drawing.Point(514, 386);
            this.lblFondoTotal.Name = "lblFondoTotal";
            this.lblFondoTotal.Size = new System.Drawing.Size(236, 31);
            this.lblFondoTotal.TabIndex = 24;
            this.lblFondoTotal.Text = "TOTAL:                  ";
            this.lblFondoTotal.Click += new System.EventHandler(this.lblFondoTotal_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCobrar.BackColor = System.Drawing.Color.Lime;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCobrar.Location = new System.Drawing.Point(901, 385);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(123, 32);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.TabStop = false;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblTagPrecio
            // 
            this.lblTagPrecio.AutoSize = true;
            this.lblTagPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblTagPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagPrecio.ForeColor = System.Drawing.Color.Navy;
            this.lblTagPrecio.Location = new System.Drawing.Point(7, 112);
            this.lblTagPrecio.Name = "lblTagPrecio";
            this.lblTagPrecio.Size = new System.Drawing.Size(85, 13);
            this.lblTagPrecio.TabIndex = 26;
            this.lblTagPrecio.Tag = "lblPrecio";
            this.lblTagPrecio.Text = "Precio x Unidad:";
            this.lblTagPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbxNombre
            // 
            this.gbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxNombre.Controls.Add(this.lblPrecio);
            this.gbxNombre.Controls.Add(this.lblMarca);
            this.gbxNombre.Controls.Add(this.lblTagPrecio);
            this.gbxNombre.Controls.Add(this.lblNombre);
            this.gbxNombre.Controls.Add(this.lblDescripcion);
            this.gbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNombre.Location = new System.Drawing.Point(6, 280);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Size = new System.Drawing.Size(267, 137);
            this.gbxNombre.TabIndex = 2;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "DETALLES";
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Navy;
            this.lblMarca.Location = new System.Drawing.Point(6, 45);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(221, 20);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // btnLimpiarVenta
            // 
            this.btnLimpiarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarVenta.AutoSize = true;
            this.btnLimpiarVenta.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarVenta.Location = new System.Drawing.Point(899, 319);
            this.btnLimpiarVenta.Name = "btnLimpiarVenta";
            this.btnLimpiarVenta.Size = new System.Drawing.Size(125, 30);
            this.btnLimpiarVenta.TabIndex = 3;
            this.btnLimpiarVenta.Text = "Cancelar venta";
            this.btnLimpiarVenta.UseVisualStyleBackColor = false;
            this.btnLimpiarVenta.Click += new System.EventHandler(this.btnLimpiarVenta_Click);
            // 
            // btnEliminarItemVenta
            // 
            this.btnEliminarItemVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarItemVenta.AutoSize = true;
            this.btnEliminarItemVenta.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarItemVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarItemVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEliminarItemVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarItemVenta.Location = new System.Drawing.Point(690, 318);
            this.btnEliminarItemVenta.Name = "btnEliminarItemVenta";
            this.btnEliminarItemVenta.Size = new System.Drawing.Size(105, 23);
            this.btnEliminarItemVenta.TabIndex = 4;
            this.btnEliminarItemVenta.Text = "Borrar producto";
            this.btnEliminarItemVenta.UseVisualStyleBackColor = false;
            this.btnEliminarItemVenta.Click += new System.EventHandler(this.btnEliminarItemVenta_Click);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxProducto.Location = new System.Drawing.Point(276, 280);
            this.pbxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(136, 137);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // lblAtajos
            // 
            this.lblAtajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtajos.CausesValidation = false;
            this.lblAtajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtajos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAtajos.Location = new System.Drawing.Point(643, 24);
            this.lblAtajos.Name = "lblAtajos";
            this.lblAtajos.Size = new System.Drawing.Size(381, 27);
            this.lblAtajos.TabIndex = 25;
            this.lblAtajos.Text = "F3: Ir a Buscar     F10: COBRAR";
            this.lblAtajos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAtajoEsc
            // 
            this.lblAtajoEsc.AutoSize = true;
            this.lblAtajoEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtajoEsc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAtajoEsc.Location = new System.Drawing.Point(184, 28);
            this.lblAtajoEsc.Name = "lblAtajoEsc";
            this.lblAtajoEsc.Size = new System.Drawing.Size(117, 13);
            this.lblAtajoEsc.TabIndex = 26;
            this.lblAtajoEsc.Text = "ESC: Limpiar búsqueda";
            // 
            // FrmProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1036, 429);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.lblAtajoEsc);
            this.Controls.Add(this.lblAtajos);
            this.Controls.Add(this.btnEliminarItemVenta);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiarVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblCantProductosLista);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnEliminarDefinitivo);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxNombre);
            this.Controls.Add(this.lblFondoTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco26 - Venta";
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
    }
}

