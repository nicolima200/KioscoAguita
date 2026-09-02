namespace frmPrincipal
{
    partial class frmAltaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaProducto));
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecioMayorista = new System.Windows.Forms.Label();
            this.lblPrecioKiosco = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbCodBarras = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecioMayorista = new System.Windows.Forms.TextBox();
            this.txbPrecioKiosco = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblTituloAltaProd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.pbxAlta = new System.Windows.Forms.PictureBox();
            this.btnLimpiarImagen = new System.Windows.Forms.Button();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txbStockMinimo = new System.Windows.Forms.TextBox();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.lblVentaPorFraccion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(69, 87);
            this.lblCodBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(90, 13);
            this.lblCodBarras.TabIndex = 0;
            this.lblCodBarras.Text = "Codigo de barras:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(111, 111);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(94, 159);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(104, 218);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecioMayorista
            // 
            this.lblPrecioMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioMayorista.AutoSize = true;
            this.lblPrecioMayorista.Location = new System.Drawing.Point(73, 253);
            this.lblPrecioMayorista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMayorista.Name = "lblPrecioMayorista";
            this.lblPrecioMayorista.Size = new System.Drawing.Size(87, 13);
            this.lblPrecioMayorista.TabIndex = 4;
            this.lblPrecioMayorista.Text = "Precio mayorista:";
            // 
            // lblPrecioKiosco
            // 
            this.lblPrecioKiosco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioKiosco.AutoSize = true;
            this.lblPrecioKiosco.Location = new System.Drawing.Point(86, 277);
            this.lblPrecioKiosco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioKiosco.Name = "lblPrecioKiosco";
            this.lblPrecioKiosco.Size = new System.Drawing.Size(74, 13);
            this.lblPrecioKiosco.TabIndex = 5;
            this.lblPrecioKiosco.Text = "Precio kiosco:";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(120, 301);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // txbCodBarras
            // 
            this.txbCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodBarras.Location = new System.Drawing.Point(160, 82);
            this.txbCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txbCodBarras.MaxLength = 13;
            this.txbCodBarras.Name = "txbCodBarras";
            this.txbCodBarras.Size = new System.Drawing.Size(190, 20);
            this.txbCodBarras.TabIndex = 0;
            this.txbCodBarras.Tag = "Código de barras";
            this.txbCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodBarras_KeyPress);
            this.txbCodBarras.Leave += new System.EventHandler(this.txbCodBarras_Leave);
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.Location = new System.Drawing.Point(160, 106);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txbNombre.MaxLength = 40;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(190, 20);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Tag = "Nombre";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.Location = new System.Drawing.Point(160, 158);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescripcion.MaxLength = 60;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(190, 53);
            this.txbDescripcion.TabIndex = 3;
            this.txbDescripcion.Tag = "Descripcion";
            this.txbDescripcion.Enter += new System.EventHandler(this.txbDescripcion_Enter);
            // 
            // txbPrecioMayorista
            // 
            this.txbPrecioMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecioMayorista.Location = new System.Drawing.Point(160, 249);
            this.txbPrecioMayorista.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrecioMayorista.Name = "txbPrecioMayorista";
            this.txbPrecioMayorista.Size = new System.Drawing.Size(190, 20);
            this.txbPrecioMayorista.TabIndex = 5;
            this.txbPrecioMayorista.Tag = "Precio Mayorista";
            this.txbPrecioMayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioMayorista_KeyPress);
            // 
            // txbPrecioKiosco
            // 
            this.txbPrecioKiosco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecioKiosco.Location = new System.Drawing.Point(160, 273);
            this.txbPrecioKiosco.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrecioKiosco.Name = "txbPrecioKiosco";
            this.txbPrecioKiosco.Size = new System.Drawing.Size(190, 20);
            this.txbPrecioKiosco.TabIndex = 6;
            this.txbPrecioKiosco.Tag = "Precio Kiosco";
            this.txbPrecioKiosco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioKiosco_KeyPress);
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.Location = new System.Drawing.Point(160, 297);
            this.txbStock.Margin = new System.Windows.Forms.Padding(2);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(190, 20);
            this.txbStock.TabIndex = 7;
            this.txbStock.Tag = "Stock";
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStock_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(160, 417);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 26);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(273, 417);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(160, 215);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(190, 21);
            this.cboCategoria.TabIndex = 4;
            this.cboCategoria.Tag = "Categoría";
            // 
            // lblTituloAltaProd
            // 
            this.lblTituloAltaProd.AutoSize = true;
            this.lblTituloAltaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTituloAltaProd.Location = new System.Drawing.Point(91, 21);
            this.lblTituloAltaProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloAltaProd.Name = "lblTituloAltaProd";
            this.lblTituloAltaProd.Size = new System.Drawing.Size(302, 26);
            this.lblTituloAltaProd.TabIndex = 20;
            this.lblTituloAltaProd.Text = "Ingrese los datos del producto";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(139, 63);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // txbId
            // 
            this.txbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbId.Location = new System.Drawing.Point(160, 58);
            this.txbId.Margin = new System.Windows.Forms.Padding(2);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(190, 20);
            this.txbId.TabIndex = 22;
            this.txbId.TabStop = false;
            this.txbId.Tag = "Id";
            this.txbId.Visible = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(112, 349);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(45, 13);
            this.lblUrlImagen.TabIndex = 23;
            this.lblUrlImagen.Text = "Imagen:";
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrlImagen.Location = new System.Drawing.Point(160, 345);
            this.txbUrlImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(190, 20);
            this.txbUrlImagen.TabIndex = 24;
            this.txbUrlImagen.Tag = "Imagen";
            this.txbUrlImagen.TextChanged += new System.EventHandler(this.txbUrlImagen_TextChanged);
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(391, 341);
            this.btnAgregarImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(75, 26);
            this.btnAgregarImg.TabIndex = 25;
            this.btnAgregarImg.Text = "Agregar";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // pbxAlta
            // 
            this.pbxAlta.Location = new System.Drawing.Point(369, 223);
            this.pbxAlta.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAlta.Name = "pbxAlta";
            this.pbxAlta.Size = new System.Drawing.Size(104, 113);
            this.pbxAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlta.TabIndex = 26;
            this.pbxAlta.TabStop = false;
            // 
            // btnLimpiarImagen
            // 
            this.btnLimpiarImagen.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLimpiarImagen.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarImagen.Location = new System.Drawing.Point(357, 343);
            this.btnLimpiarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarImagen.Name = "btnLimpiarImagen";
            this.btnLimpiarImagen.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarImagen.TabIndex = 27;
            this.btnLimpiarImagen.Text = "X";
            this.btnLimpiarImagen.UseVisualStyleBackColor = false;
            this.btnLimpiarImagen.Click += new System.EventHandler(this.btnLimpiarImagen_Click);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(53, 325);
            this.lblStockMinimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(107, 13);
            this.lblStockMinimo.TabIndex = 28;
            this.lblStockMinimo.Text = "Avisar cuando stock:";
            // 
            // txbStockMinimo
            // 
            this.txbStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStockMinimo.Location = new System.Drawing.Point(160, 321);
            this.txbStockMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockMinimo.Name = "txbStockMinimo";
            this.txbStockMinimo.Size = new System.Drawing.Size(190, 20);
            this.txbStockMinimo.TabIndex = 8;
            this.txbStockMinimo.Tag = "Stock Mínimo";
            this.txbStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStockMinimo_KeyPress);
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoVenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoVenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(160, 369);
            this.cboTipoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(190, 21);
            this.cboTipoVenta.TabIndex = 8;
            this.cboTipoVenta.Tag = "Categoría";
            // 
            // lblVentaPorFraccion
            // 
            this.lblVentaPorFraccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaPorFraccion.AutoSize = true;
            this.lblVentaPorFraccion.Location = new System.Drawing.Point(83, 373);
            this.lblVentaPorFraccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentaPorFraccion.Name = "lblVentaPorFraccion";
            this.lblVentaPorFraccion.Size = new System.Drawing.Size(76, 13);
            this.lblVentaPorFraccion.TabIndex = 31;
            this.lblVentaPorFraccion.Text = "Tipo de venta:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(111, 135);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(160, 131);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboMarca.MaxLength = 50;
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(190, 21);
            this.cboMarca.TabIndex = 2;
            this.cboMarca.Tag = "Categoría";
            this.cboMarca.Text = "Sin marca";
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 453);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblVentaPorFraccion);
            this.Controls.Add(this.cboTipoVenta);
            this.Controls.Add(this.txbStockMinimo);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.btnLimpiarImagen);
            this.Controls.Add(this.pbxAlta);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.txbUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTituloAltaProd);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPrecioKiosco);
            this.Controls.Add(this.txbPrecioMayorista);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodBarras);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecioKiosco);
            this.Controls.Add(this.lblPrecioMayorista);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco26 - Agregar producto";
            this.Load += new System.EventHandler(this.frmAltaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecioMayorista;
        private System.Windows.Forms.Label lblPrecioKiosco;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txbCodBarras;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecioMayorista;
        private System.Windows.Forms.TextBox txbPrecioKiosco;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblTituloAltaProd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.PictureBox pbxAlta;
        private System.Windows.Forms.Button btnLimpiarImagen;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txbStockMinimo;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.Label lblVentaPorFraccion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
    }
}