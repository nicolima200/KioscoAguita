using System.Windows.Forms;

namespace frmPrincipal
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnEliminarDefinitivo = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantProductosLista = new System.Windows.Forms.Label();
            this.btnFrmRecuperar = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFondoTotal = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPrincipal.Location = new System.Drawing.Point(13, 115);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrincipal.MaximumSize = new System.Drawing.Size(937, 388);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(710, 227);
            this.dgvPrincipal.TabIndex = 0;
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            this.dgvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrincipal_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 661);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(212, 661);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(142, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecuperar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRecuperar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecuperar.Location = new System.Drawing.Point(399, 664);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(144, 29);
            this.btnRecuperar.TabIndex = 4;
            this.btnRecuperar.Text = "Recuperar producto";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Visible = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoEllipsis = true;
            this.lblRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecuperar.Location = new System.Drawing.Point(754, 670);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(78, 32);
            this.lblRecuperar.TabIndex = 6;
            this.lblRecuperar.Text = "Recuperar producto";
            this.lblRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecuperar.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Buscar productos:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(32, 89);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(43, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Buscar:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(77, 86);
            this.tbxFiltro.MaxLength = 50;
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(201, 20);
            this.tbxFiltro.TabIndex = 9;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            this.tbxFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxFiltro_KeyDown);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(284, 84);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(95, 26);
            this.btnLimpiarFiltro.TabIndex = 10;
            this.btnLimpiarFiltro.Text = "Limpiar filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombre.Location = new System.Drawing.Point(299, 350);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(158, 39);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDescripcion.Location = new System.Drawing.Point(299, 396);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(165, 31);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPrecio.Location = new System.Drawing.Point(299, 457);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(107, 37);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Tag = "Precio";
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEliminarDefinitivo
            // 
            this.btnEliminarDefinitivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarDefinitivo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarDefinitivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEliminarDefinitivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarDefinitivo.Location = new System.Drawing.Point(587, 664);
            this.btnEliminarDefinitivo.Name = "btnEliminarDefinitivo";
            this.btnEliminarDefinitivo.Size = new System.Drawing.Size(144, 29);
            this.btnEliminarDefinitivo.TabIndex = 14;
            this.btnEliminarDefinitivo.Text = "Borrar definitivo";
            this.btnEliminarDefinitivo.UseVisualStyleBackColor = false;
            this.btnEliminarDefinitivo.Visible = false;
            this.btnEliminarDefinitivo.Click += new System.EventHandler(this.btnEliminarDefinitivo_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblVenta.Location = new System.Drawing.Point(724, 74);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(85, 31);
            this.lblVenta.TabIndex = 17;
            this.lblVenta.Text = "Venta";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Lime;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTotal.Location = new System.Drawing.Point(1047, 585);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(371, 55);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "                  ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCantProductosLista
            // 
            this.lblCantProductosLista.AutoSize = true;
            this.lblCantProductosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCantProductosLista.Location = new System.Drawing.Point(724, 553);
            this.lblCantProductosLista.Name = "lblCantProductosLista";
            this.lblCantProductosLista.Size = new System.Drawing.Size(131, 31);
            this.lblCantProductosLista.TabIndex = 19;
            this.lblCantProductosLista.Text = "Cantidad:";
            // 
            // btnFrmRecuperar
            // 
            this.btnFrmRecuperar.BackColor = System.Drawing.Color.LightGreen;
            this.btnFrmRecuperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrmRecuperar.BackgroundImage")));
            this.btnFrmRecuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrmRecuperar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFrmRecuperar.Location = new System.Drawing.Point(757, 602);
            this.btnFrmRecuperar.Name = "btnFrmRecuperar";
            this.btnFrmRecuperar.Size = new System.Drawing.Size(67, 65);
            this.btnFrmRecuperar.TabIndex = 5;
            this.btnFrmRecuperar.UseVisualStyleBackColor = false;
            this.btnFrmRecuperar.Visible = false;
            this.btnFrmRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(13, 350);
            this.pbxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(265, 265);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 1;
            this.pbxProducto.TabStop = false;
            // 
            // dgvVenta
            // 
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVenta.Location = new System.Drawing.Point(731, 115);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVenta.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVenta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(687, 435);
            this.dgvVenta.TabIndex = 20;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tbxCantidad.Location = new System.Drawing.Point(460, 506);
            this.tbxCantidad.MaxLength = 10;
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(83, 44);
            this.tbxCantidad.TabIndex = 21;
            this.tbxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCantidad_KeyDown);
            this.tbxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidad_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1442, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.recuperarProductoToolStripMenuItem});
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar productos";
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
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCantidad.Location = new System.Drawing.Point(299, 509);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(155, 37);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFondoTotal
            // 
            this.lblFondoTotal.AutoSize = true;
            this.lblFondoTotal.BackColor = System.Drawing.Color.Lime;
            this.lblFondoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFondoTotal.ForeColor = System.Drawing.Color.White;
            this.lblFondoTotal.Location = new System.Drawing.Point(848, 585);
            this.lblFondoTotal.Name = "lblFondoTotal";
            this.lblFondoTotal.Size = new System.Drawing.Size(449, 55);
            this.lblFondoTotal.TabIndex = 24;
            this.lblFondoTotal.Text = "TOTAL:                  ";
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.AutoSize = true;
            this.btnCobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCobrar.Location = new System.Drawing.Point(1160, 648);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(258, 65);
            this.btnCobrar.TabIndex = 25;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1442, 725);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.lblCantProductosLista);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnEliminarDefinitivo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRecuperar);
            this.Controls.Add(this.btnFrmRecuperar);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblFondoTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Kiosco";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnFrmRecuperar;
        private System.Windows.Forms.Label lblRecuperar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltro;
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
        private ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem recuperarProductoToolStripMenuItem;
        private Label lblCantidad;
        private Label lblFondoTotal;
        private Button btnCobrar;
    }
}

