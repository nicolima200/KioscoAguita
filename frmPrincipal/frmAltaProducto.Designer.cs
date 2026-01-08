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
            this.lblAvisoCodBarras = new System.Windows.Forms.Label();
            this.lblAvisoNombre = new System.Windows.Forms.Label();
            this.lblAvisoDescripcion = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(69, 107);
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
            this.lblNombre.Location = new System.Drawing.Point(111, 150);
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
            this.lblDescripcion.Location = new System.Drawing.Point(94, 193);
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
            this.lblCategoria.Location = new System.Drawing.Point(104, 268);
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
            this.lblPrecioMayorista.Location = new System.Drawing.Point(72, 304);
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
            this.lblPrecioKiosco.Location = new System.Drawing.Point(86, 340);
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
            this.lblStock.Location = new System.Drawing.Point(122, 376);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // txbCodBarras
            // 
            this.txbCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodBarras.Location = new System.Drawing.Point(160, 102);
            this.txbCodBarras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txbNombre.Location = new System.Drawing.Point(160, 145);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(190, 20);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Tag = "Nombre";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescripcion.Location = new System.Drawing.Point(160, 193);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDescripcion.MaxLength = 150;
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(190, 53);
            this.txbDescripcion.TabIndex = 2;
            this.txbDescripcion.Tag = "Descripcion";
            this.txbDescripcion.Enter += new System.EventHandler(this.txbDescripcion_Enter);
            // 
            // txbPrecioMayorista
            // 
            this.txbPrecioMayorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecioMayorista.Location = new System.Drawing.Point(160, 302);
            this.txbPrecioMayorista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrecioMayorista.Name = "txbPrecioMayorista";
            this.txbPrecioMayorista.Size = new System.Drawing.Size(190, 20);
            this.txbPrecioMayorista.TabIndex = 4;
            this.txbPrecioMayorista.Tag = "Precio Mayorista";
            this.txbPrecioMayorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioMayorista_KeyPress);
            // 
            // txbPrecioKiosco
            // 
            this.txbPrecioKiosco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPrecioKiosco.Location = new System.Drawing.Point(160, 338);
            this.txbPrecioKiosco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrecioKiosco.Name = "txbPrecioKiosco";
            this.txbPrecioKiosco.Size = new System.Drawing.Size(190, 20);
            this.txbPrecioKiosco.TabIndex = 5;
            this.txbPrecioKiosco.Tag = "Precio Kiosco";
            this.txbPrecioKiosco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioKiosco_KeyPress);
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStock.Location = new System.Drawing.Point(160, 374);
            this.txbStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(190, 20);
            this.txbStock.TabIndex = 6;
            this.txbStock.Tag = "Stock";
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStock_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(160, 535);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(273, 535);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 8;
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
            this.cboCategoria.Location = new System.Drawing.Point(160, 265);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(190, 21);
            this.cboCategoria.TabIndex = 3;
            this.cboCategoria.Tag = "Categoría";
            // 
            // lblAvisoCodBarras
            // 
            this.lblAvisoCodBarras.AutoSize = true;
            this.lblAvisoCodBarras.ForeColor = System.Drawing.Color.Crimson;
            this.lblAvisoCodBarras.Location = new System.Drawing.Point(119, 84);
            this.lblAvisoCodBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvisoCodBarras.Name = "lblAvisoCodBarras";
            this.lblAvisoCodBarras.Size = new System.Drawing.Size(241, 13);
            this.lblAvisoCodBarras.TabIndex = 17;
            this.lblAvisoCodBarras.Text = "El código de barras sólo puede contener números";
            this.lblAvisoCodBarras.Visible = false;
            // 
            // lblAvisoNombre
            // 
            this.lblAvisoNombre.AutoSize = true;
            this.lblAvisoNombre.ForeColor = System.Drawing.Color.Crimson;
            this.lblAvisoNombre.Location = new System.Drawing.Point(139, 130);
            this.lblAvisoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvisoNombre.Name = "lblAvisoNombre";
            this.lblAvisoNombre.Size = new System.Drawing.Size(225, 13);
            this.lblAvisoNombre.TabIndex = 18;
            this.lblAvisoNombre.Text = "El nombre sólo puede contener punto o guión.";
            this.lblAvisoNombre.Visible = false;
            // 
            // lblAvisoDescripcion
            // 
            this.lblAvisoDescripcion.AutoSize = true;
            this.lblAvisoDescripcion.ForeColor = System.Drawing.Color.Crimson;
            this.lblAvisoDescripcion.Location = new System.Drawing.Point(102, 177);
            this.lblAvisoDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvisoDescripcion.Name = "lblAvisoDescripcion";
            this.lblAvisoDescripcion.Size = new System.Drawing.Size(263, 13);
            this.lblAvisoDescripcion.TabIndex = 19;
            this.lblAvisoDescripcion.Text = "La descripción sólo puede contener puntos o guiones.";
            this.lblAvisoDescripcion.Visible = false;
            // 
            // lblTituloAltaProd
            // 
            this.lblTituloAltaProd.AutoSize = true;
            this.lblTituloAltaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTituloAltaProd.Location = new System.Drawing.Point(23, 20);
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
            this.txbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblUrlImagen.Location = new System.Drawing.Point(114, 448);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(45, 13);
            this.lblUrlImagen.TabIndex = 23;
            this.lblUrlImagen.Text = "Imagen:";
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUrlImagen.Location = new System.Drawing.Point(159, 446);
            this.txbUrlImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(190, 20);
            this.txbUrlImagen.TabIndex = 24;
            this.txbUrlImagen.Tag = "Imagen";
            this.txbUrlImagen.TextChanged += new System.EventHandler(this.txbUrlImagen_TextChanged);
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(386, 442);
            this.btnAgregarImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(75, 26);
            this.btnAgregarImg.TabIndex = 25;
            this.btnAgregarImg.Text = "Agregar";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // pbxAlta
            // 
            this.pbxAlta.Location = new System.Drawing.Point(364, 324);
            this.pbxAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnLimpiarImagen.Location = new System.Drawing.Point(352, 444);
            this.btnLimpiarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblStockMinimo.Location = new System.Drawing.Point(53, 412);
            this.lblStockMinimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(107, 13);
            this.lblStockMinimo.TabIndex = 28;
            this.lblStockMinimo.Text = "Avisar cuando stock:";
            // 
            // txbStockMinimo
            // 
            this.txbStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStockMinimo.Location = new System.Drawing.Point(159, 410);
            this.txbStockMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txbStockMinimo.Name = "txbStockMinimo";
            this.txbStockMinimo.Size = new System.Drawing.Size(190, 20);
            this.txbStockMinimo.TabIndex = 29;
            this.txbStockMinimo.Tag = "Stock";
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
            this.cboTipoVenta.Location = new System.Drawing.Point(159, 482);
            this.cboTipoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(190, 21);
            this.cboTipoVenta.TabIndex = 30;
            this.cboTipoVenta.Tag = "Categoría";
            // 
            // lblVentaPorFraccion
            // 
            this.lblVentaPorFraccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentaPorFraccion.AutoSize = true;
            this.lblVentaPorFraccion.Location = new System.Drawing.Point(83, 484);
            this.lblVentaPorFraccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentaPorFraccion.Name = "lblVentaPorFraccion";
            this.lblVentaPorFraccion.Size = new System.Drawing.Size(76, 13);
            this.lblVentaPorFraccion.TabIndex = 31;
            this.lblVentaPorFraccion.Text = "Tipo de venta:";
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 631);
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
            this.Controls.Add(this.lblAvisoDescripcion);
            this.Controls.Add(this.lblAvisoNombre);
            this.Controls.Add(this.lblAvisoCodBarras);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
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
        private System.Windows.Forms.Label lblAvisoCodBarras;
        private System.Windows.Forms.Label lblAvisoNombre;
        private System.Windows.Forms.Label lblAvisoDescripcion;
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
    }
}