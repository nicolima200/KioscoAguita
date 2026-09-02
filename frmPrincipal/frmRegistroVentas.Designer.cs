using System.Drawing;
using System.Windows.Forms;

namespace frmPrincipal
{
    partial class frmRegistroVentas
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroVentas));
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblCantProductosLista = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.gbxFiltroFecha = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblTotalTransferencia = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTOTAL = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAppTitulo = new System.Windows.Forms.Label();
            this.pnlFiltroCard = new System.Windows.Forms.Panel();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftCard = new System.Windows.Forms.Panel();
            this.pnlLeftHeader = new System.Windows.Forms.Panel();
            this.pnlRightCard = new System.Windows.Forms.Panel();
            this.pnlRightHeader = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnlResumenCard = new System.Windows.Forms.Panel();
            this.pnlResumenSep = new System.Windows.Forms.Panel();
            this.lblResumenTitulo = new System.Windows.Forms.Label();
            this.pnlTotalCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.gbxFiltroFecha.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltroCard.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLeftCard.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlRightCard.SuspendLayout();
            this.pnlRightHeader.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlResumenCard.SuspendLayout();
            this.pnlTotalCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleVenta.ColumnHeadersHeight = 32;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.dgvDetalleVenta.Location = new System.Drawing.Point(12, 34);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalleVenta.RowTemplate.Height = 26;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(484, 246);
            this.dgvDetalleVenta.TabIndex = 43;
            this.dgvDetalleVenta.TabStop = false;
            this.dgvDetalleVenta.VirtualMode = true;
            this.dgvDetalleVenta.CurrentCellChanged += new System.EventHandler(this.dgvDetalleVenta_CurrentCellChanged);
            // 
            // lblCantProductosLista
            // 
            this.lblCantProductosLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCantProductosLista.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCantProductosLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblCantProductosLista.Location = new System.Drawing.Point(12, 280);
            this.lblCantProductosLista.Name = "lblCantProductosLista";
            this.lblCantProductosLista.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCantProductosLista.Size = new System.Drawing.Size(484, 22);
            this.lblCantProductosLista.TabIndex = 42;
            this.lblCantProductosLista.Text = "Cantidad de productos: 0";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(121, 13);
            this.lblDetalleVenta.TabIndex = 40;
            this.lblDetalleVenta.Text = "DETALLE DE VENTA —";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(522, 15);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(32, 26);
            this.btnLimpiarFiltro.TabIndex = 28;
            this.btnLimpiarFiltro.Text = "✕";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVentas.ColumnHeadersHeight = 32;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.dgvVentas.Location = new System.Drawing.Point(12, 34);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVentas.RowTemplate.Height = 26;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(484, 268);
            this.dgvVentas.TabIndex = 37;
            this.dgvVentas.TabStop = false;
            this.dgvVentas.CurrentCellChanged += new System.EventHandler(this.dgvVentas_CurrentCellChanged);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(16, 41);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(476, 63);
            this.lblMontoTotal.TabIndex = 45;
            this.lblMontoTotal.Text = "$ 0,00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "LISTA DE VENTAS";
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextoTotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTextoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblTextoTotal.Location = new System.Drawing.Point(16, 16);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblTextoTotal.Size = new System.Drawing.Size(112, 25);
            this.lblTextoTotal.TabIndex = 47;
            this.lblTextoTotal.Text = "TOTAL DE LA VENTA";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(62, 16);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 23);
            this.dtpDesde.TabIndex = 48;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblDesde.Location = new System.Drawing.Point(12, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(42, 13);
            this.lblDesde.TabIndex = 49;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblHasta.Location = new System.Drawing.Point(212, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 13);
            this.lblHasta.TabIndex = 50;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(260, 16);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(130, 23);
            this.dtpHasta.TabIndex = 51;
            // 
            // gbxFiltroFecha
            // 
            this.gbxFiltroFecha.Controls.Add(this.lblDesde);
            this.gbxFiltroFecha.Controls.Add(this.dtpDesde);
            this.gbxFiltroFecha.Controls.Add(this.lblHasta);
            this.gbxFiltroFecha.Controls.Add(this.dtpHasta);
            this.gbxFiltroFecha.Controls.Add(this.btnFiltrar);
            this.gbxFiltroFecha.Controls.Add(this.btnLimpiarFiltro);
            this.gbxFiltroFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gbxFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.gbxFiltroFecha.Location = new System.Drawing.Point(16, 10);
            this.gbxFiltroFecha.Name = "gbxFiltroFecha";
            this.gbxFiltroFecha.Padding = new System.Windows.Forms.Padding(8);
            this.gbxFiltroFecha.Size = new System.Drawing.Size(1028, 66);
            this.gbxFiltroFecha.TabIndex = 52;
            this.gbxFiltroFecha.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(420, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 26);
            this.btnFiltrar.TabIndex = 52;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblFecha.Location = new System.Drawing.Point(466, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(18, 13);
            this.lblFecha.TabIndex = 53;
            this.lblFecha.Text = "—";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblPeriodo.Location = new System.Drawing.Point(16, 36);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(160, 12);
            this.lblPeriodo.TabIndex = 54;
            this.lblPeriodo.Text = "Facturado en período seleccionado";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblEfectivo.Location = new System.Drawing.Point(16, 58);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(49, 15);
            this.lblEfectivo.TabIndex = 55;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTransferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTransferencia.Location = new System.Drawing.Point(16, 78);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(77, 15);
            this.lblTransferencia.TabIndex = 56;
            this.lblTransferencia.Text = "Transferencia";
            // 
            // lblTotalEfectivo
            // 
            this.lblTotalEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTotalEfectivo.Location = new System.Drawing.Point(340, 58);
            this.lblTotalEfectivo.Name = "lblTotalEfectivo";
            this.lblTotalEfectivo.Size = new System.Drawing.Size(150, 15);
            this.lblTotalEfectivo.TabIndex = 57;
            this.lblTotalEfectivo.Text = "$ 0,00";
            this.lblTotalEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTransferencia
            // 
            this.lblTotalTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTransferencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTransferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTotalTransferencia.Location = new System.Drawing.Point(340, 78);
            this.lblTotalTransferencia.Name = "lblTotalTransferencia";
            this.lblTotalTransferencia.Size = new System.Drawing.Size(150, 15);
            this.lblTotalTransferencia.TabIndex = 58;
            this.lblTotalTransferencia.Text = "$ 0,00";
            this.lblTotalTransferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTotal.Location = new System.Drawing.Point(16, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 15);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblTotalTOTAL
            // 
            this.lblTotalTOTAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTOTAL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTOTAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTotalTOTAL.Location = new System.Drawing.Point(340, 103);
            this.lblTotalTOTAL.Name = "lblTotalTOTAL";
            this.lblTotalTOTAL.Size = new System.Drawing.Size(150, 15);
            this.lblTotalTOTAL.TabIndex = 60;
            this.lblTotalTOTAL.Text = "$ 0,00";
            this.lblTotalTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblAppTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1060, 38);
            this.pnlHeader.TabIndex = 70;
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
            this.lblAppTitulo.Size = new System.Drawing.Size(259, 29);
            this.lblAppTitulo.TabIndex = 0;
            this.lblAppTitulo.Text = "KIOSCO26  •  REGISTRO DE VENTAS";
            // 
            // pnlFiltroCard
            // 
            this.pnlFiltroCard.BackColor = System.Drawing.Color.White;
            this.pnlFiltroCard.Controls.Add(this.lblFiltroTitulo);
            this.pnlFiltroCard.Controls.Add(this.gbxFiltroFecha);
            this.pnlFiltroCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroCard.Location = new System.Drawing.Point(0, 38);
            this.pnlFiltroCard.Name = "pnlFiltroCard";
            this.pnlFiltroCard.Padding = new System.Windows.Forms.Padding(16, 10, 16, 12);
            this.pnlFiltroCard.Size = new System.Drawing.Size(1060, 88);
            this.pnlFiltroCard.TabIndex = 71;
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltroTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFiltroTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblFiltroTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblFiltroTitulo.Size = new System.Drawing.Size(124, 19);
            this.lblFiltroTitulo.TabIndex = 0;
            this.lblFiltroTitulo.Text = "FILTRAR POR PERÍODO";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.pnlLeftCard, 0, 0);
            this.pnlMain.Controls.Add(this.pnlRightCard, 1, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 126);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16, 12, 16, 8);
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Size = new System.Drawing.Size(1060, 340);
            this.pnlMain.TabIndex = 72;
            // 
            // pnlLeftCard
            // 
            this.pnlLeftCard.BackColor = System.Drawing.Color.White;
            this.pnlLeftCard.Controls.Add(this.dgvVentas);
            this.pnlLeftCard.Controls.Add(this.pnlLeftHeader);
            this.pnlLeftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCard.Location = new System.Drawing.Point(19, 15);
            this.pnlLeftCard.Name = "pnlLeftCard";
            this.pnlLeftCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlLeftCard.Size = new System.Drawing.Size(508, 314);
            this.pnlLeftCard.TabIndex = 0;
            // 
            // pnlLeftHeader
            // 
            this.pnlLeftHeader.Controls.Add(this.label2);
            this.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlLeftHeader.Name = "pnlLeftHeader";
            this.pnlLeftHeader.Size = new System.Drawing.Size(484, 22);
            this.pnlLeftHeader.TabIndex = 0;
            // 
            // pnlRightCard
            // 
            this.pnlRightCard.BackColor = System.Drawing.Color.White;
            this.pnlRightCard.Controls.Add(this.dgvDetalleVenta);
            this.pnlRightCard.Controls.Add(this.lblCantProductosLista);
            this.pnlRightCard.Controls.Add(this.pnlRightHeader);
            this.pnlRightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCard.Location = new System.Drawing.Point(533, 15);
            this.pnlRightCard.Name = "pnlRightCard";
            this.pnlRightCard.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRightCard.Size = new System.Drawing.Size(508, 314);
            this.pnlRightCard.TabIndex = 1;
            // 
            // pnlRightHeader
            // 
            this.pnlRightHeader.Controls.Add(this.lblDetalleVenta);
            this.pnlRightHeader.Controls.Add(this.lblFecha);
            this.pnlRightHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlRightHeader.Name = "pnlRightHeader";
            this.pnlRightHeader.Size = new System.Drawing.Size(484, 22);
            this.pnlRightHeader.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.pnlBottom.ColumnCount = 2;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.Controls.Add(this.pnlResumenCard, 0, 0);
            this.pnlBottom.Controls.Add(this.pnlTotalCard, 1, 0);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 466);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBottom.Size = new System.Drawing.Size(1060, 150);
            this.pnlBottom.TabIndex = 73;
            // 
            // pnlResumenCard
            // 
            this.pnlResumenCard.BackColor = System.Drawing.Color.White;
            this.pnlResumenCard.Controls.Add(this.lblTotalTOTAL);
            this.pnlResumenCard.Controls.Add(this.lblTotal);
            this.pnlResumenCard.Controls.Add(this.pnlResumenSep);
            this.pnlResumenCard.Controls.Add(this.lblTotalTransferencia);
            this.pnlResumenCard.Controls.Add(this.lblTransferencia);
            this.pnlResumenCard.Controls.Add(this.lblTotalEfectivo);
            this.pnlResumenCard.Controls.Add(this.lblEfectivo);
            this.pnlResumenCard.Controls.Add(this.lblPeriodo);
            this.pnlResumenCard.Controls.Add(this.lblResumenTitulo);
            this.pnlResumenCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResumenCard.Location = new System.Drawing.Point(19, 11);
            this.pnlResumenCard.Name = "pnlResumenCard";
            this.pnlResumenCard.Padding = new System.Windows.Forms.Padding(16);
            this.pnlResumenCard.Size = new System.Drawing.Size(508, 120);
            this.pnlResumenCard.TabIndex = 0;
            // 
            // pnlResumenSep
            // 
            this.pnlResumenSep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumenSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.pnlResumenSep.Location = new System.Drawing.Point(16, 98);
            this.pnlResumenSep.Name = "pnlResumenSep";
            this.pnlResumenSep.Size = new System.Drawing.Size(476, 1);
            this.pnlResumenSep.TabIndex = 71;
            // 
            // lblResumenTitulo
            // 
            this.lblResumenTitulo.AutoSize = true;
            this.lblResumenTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResumenTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblResumenTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(133)))));
            this.lblResumenTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblResumenTitulo.Name = "lblResumenTitulo";
            this.lblResumenTitulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblResumenTitulo.Size = new System.Drawing.Size(133, 21);
            this.lblResumenTitulo.TabIndex = 70;
            this.lblResumenTitulo.Text = "RESUMEN DEL PERÍODO";
            // 
            // pnlTotalCard
            // 
            this.pnlTotalCard.BackColor = System.Drawing.Color.White;
            this.pnlTotalCard.Controls.Add(this.lblMontoTotal);
            this.pnlTotalCard.Controls.Add(this.lblTextoTotal);
            this.pnlTotalCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalCard.Location = new System.Drawing.Point(533, 11);
            this.pnlTotalCard.Name = "pnlTotalCard";
            this.pnlTotalCard.Padding = new System.Windows.Forms.Padding(16);
            this.pnlTotalCard.Size = new System.Drawing.Size(508, 120);
            this.pnlTotalCard.TabIndex = 1;
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1060, 616);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlFiltroCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 580);
            this.Name = "frmRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiosco26 — Registro de ventas";
            this.Load += new System.EventHandler(this.frmRegistroVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.gbxFiltroFecha.ResumeLayout(false);
            this.gbxFiltroFecha.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltroCard.ResumeLayout(false);
            this.pnlFiltroCard.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftCard.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlLeftHeader.PerformLayout();
            this.pnlRightCard.ResumeLayout(false);
            this.pnlRightHeader.ResumeLayout(false);
            this.pnlRightHeader.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlResumenCard.ResumeLayout(false);
            this.pnlResumenCard.PerformLayout();
            this.pnlTotalCard.ResumeLayout(false);
            this.pnlTotalCard.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label lblCantProductosLista;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox gbxFiltroFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Label lblTotalTransferencia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTOTAL;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAppTitulo;
        private System.Windows.Forms.Panel pnlFiltroCard;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlLeftCard;
        private System.Windows.Forms.Panel pnlLeftHeader;
        private System.Windows.Forms.Panel pnlRightCard;
        private System.Windows.Forms.Panel pnlRightHeader;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private System.Windows.Forms.Panel pnlResumenCard;
        private System.Windows.Forms.Label lblResumenTitulo;
        private System.Windows.Forms.Panel pnlResumenSep;
        private System.Windows.Forms.Panel pnlTotalCard;
    }
}
