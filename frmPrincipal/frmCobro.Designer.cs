namespace frmPrincipal
{
    partial class frmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobro));
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxMontoEfectivo = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblClientePagaEfectivo = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblMontoVuelto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPagoEfectivo = new System.Windows.Forms.RadioButton();
            this.btnPagoTransferencia = new System.Windows.Forms.RadioButton();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.pnlPagoEfectivo = new System.Windows.Forms.Panel();
            this.pnlPagoTransferencia = new System.Windows.Forms.Panel();
            this.pnlReferencia = new System.Windows.Forms.Panel();
            this.tbxNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblAvisoEfectivo = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlFormaPago.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlPagoEfectivo.SuspendLayout();
            this.pnlReferencia.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cobrar";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(182, 13);
            this.lblSubtitulo.TabIndex = 17;
            this.lblSubtitulo.Text = "Revisá el total y elegí medio de pago";
            // 
            // pnlTotal - card total a pagar
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.Controls.Add(this.lblTotalCaption);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblMontoTotal);
            this.pnlTotal.Location = new System.Drawing.Point(24, 80);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Padding = new System.Windows.Forms.Padding(16);
            this.pnlTotal.Size = new System.Drawing.Size(432, 92);
            this.pnlTotal.TabIndex = 13;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 14);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(92, 13);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "TOTAL A PAGAR";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblTotal.Location = new System.Drawing.Point(16, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblMontoTotal.Location = new System.Drawing.Point(120, 28);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(296, 47);
            this.lblMontoTotal.TabIndex = 3;
            this.lblMontoTotal.Text = "$ 0,00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormaPago.Controls.Add(this.label1);
            this.pnlFormaPago.Controls.Add(this.btnPagoEfectivo);
            this.pnlFormaPago.Controls.Add(this.btnPagoTransferencia);
            this.pnlFormaPago.Location = new System.Drawing.Point(24, 188);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Size = new System.Drawing.Size(432, 76);
            this.pnlFormaPago.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MEDIO DE PAGO";
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPagoEfectivo.BackColor = System.Drawing.Color.White;
            this.btnPagoEfectivo.Checked = true;
            this.btnPagoEfectivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 219, 232);
            this.btnPagoEfectivo.FlatAppearance.BorderSize = 1;
            this.btnPagoEfectivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPagoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoEfectivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagoEfectivo.ForeColor = System.Drawing.Color.FromArgb(35, 39, 47);
            this.btnPagoEfectivo.Location = new System.Drawing.Point(0, 20);
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.Size = new System.Drawing.Size(208, 42);
            this.btnPagoEfectivo.TabIndex = 10;
            this.btnPagoEfectivo.TabStop = true;
            this.btnPagoEfectivo.Text = "◯  EFECTIVO";
            this.btnPagoEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPagoEfectivo.UseVisualStyleBackColor = false;
            // 
            // btnPagoTransferencia
            // 
            this.btnPagoTransferencia.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPagoTransferencia.BackColor = System.Drawing.Color.White;
            this.btnPagoTransferencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 219, 232);
            this.btnPagoTransferencia.FlatAppearance.BorderSize = 1;
            this.btnPagoTransferencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPagoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoTransferencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPagoTransferencia.ForeColor = System.Drawing.Color.FromArgb(35, 39, 47);
            this.btnPagoTransferencia.Location = new System.Drawing.Point(220, 20);
            this.btnPagoTransferencia.Name = "btnPagoTransferencia";
            this.btnPagoTransferencia.Size = new System.Drawing.Size(212, 42);
            this.btnPagoTransferencia.TabIndex = 11;
            this.btnPagoTransferencia.Text = "⇆  TRANSFERENCIA";
            this.btnPagoTransferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPagoTransferencia.UseVisualStyleBackColor = false;
            this.btnPagoTransferencia.CheckedChanged += new System.EventHandler(this.btnPagoTransferencia_CheckedChanged);
            // 
            // lblAvisoEfectivo
            // 
            this.lblAvisoEfectivo.AutoSize = true;
            this.lblAvisoEfectivo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvisoEfectivo.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblAvisoEfectivo.Location = new System.Drawing.Point(24, 268);
            this.lblAvisoEfectivo.Name = "lblAvisoEfectivo";
            this.lblAvisoEfectivo.Size = new System.Drawing.Size(154, 13);
            this.lblAvisoEfectivo.TabIndex = 7;
            this.lblAvisoEfectivo.Text = "⚠  Ingresá un monto válido";
            this.lblAvisoEfectivo.Visible = false;
            // 
            // pnlPagoEfectivo
            // 
            this.pnlPagoEfectivo.BackColor = System.Drawing.Color.White;
            this.pnlPagoEfectivo.Controls.Add(this.lblClientePagaEfectivo);
            this.pnlPagoEfectivo.Controls.Add(this.tbxMontoEfectivo);
            this.pnlPagoEfectivo.Controls.Add(this.lblVuelto);
            this.pnlPagoEfectivo.Controls.Add(this.lblMontoVuelto);
            this.pnlPagoEfectivo.Location = new System.Drawing.Point(24, 286);
            this.pnlPagoEfectivo.Name = "pnlPagoEfectivo";
            this.pnlPagoEfectivo.Padding = new System.Windows.Forms.Padding(16);
            this.pnlPagoEfectivo.Size = new System.Drawing.Size(432, 98);
            this.pnlPagoEfectivo.TabIndex = 14;
            // 
            // lblClientePagaEfectivo
            // 
            this.lblClientePagaEfectivo.AutoSize = true;
            this.lblClientePagaEfectivo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblClientePagaEfectivo.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblClientePagaEfectivo.Location = new System.Drawing.Point(16, 12);
            this.lblClientePagaEfectivo.Name = "lblClientePagaEfectivo";
            this.lblClientePagaEfectivo.Size = new System.Drawing.Size(126, 13);
            this.lblClientePagaEfectivo.TabIndex = 4;
            this.lblClientePagaEfectivo.Text = "EL CLIENTE PAGA CON";
            // 
            // tbxMontoEfectivo
            // 
            this.tbxMontoEfectivo.BackColor = System.Drawing.Color.White;
            this.tbxMontoEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMontoEfectivo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbxMontoEfectivo.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.tbxMontoEfectivo.Location = new System.Drawing.Point(184, 8);
            this.tbxMontoEfectivo.Name = "tbxMontoEfectivo";
            this.tbxMontoEfectivo.Size = new System.Drawing.Size(232, 32);
            this.tbxMontoEfectivo.TabIndex = 2;
            this.tbxMontoEfectivo.Text = "$ ";
            this.tbxMontoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMontoEfectivo.Click += new System.EventHandler(this.tbxMontoEfectivo_Click);
            this.tbxMontoEfectivo.TextChanged += new System.EventHandler(this.tbxMontoEfectivo_TextChanged);
            this.tbxMontoEfectivo.Enter += new System.EventHandler(this.tbxMontoEfectivo_Enter);
            this.tbxMontoEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMontoEfectivo_KeyDown);
            this.tbxMontoEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMontoEfectivo_KeyPress);
            this.tbxMontoEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxMontoEfectivo_KeyUp);
            this.tbxMontoEfectivo.Leave += new System.EventHandler(this.tbxMontoEfectivo_Leave);
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblVuelto.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblVuelto.Location = new System.Drawing.Point(16, 62);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(50, 13);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "VUELTO";
            // 
            // lblMontoVuelto
            // 
            this.lblMontoVuelto.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.lblMontoVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMontoVuelto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMontoVuelto.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblMontoVuelto.Location = new System.Drawing.Point(184, 54);
            this.lblMontoVuelto.Name = "lblMontoVuelto";
            this.lblMontoVuelto.Size = new System.Drawing.Size(232, 32);
            this.lblMontoVuelto.TabIndex = 6;
            this.lblMontoVuelto.Text = "$ 0,00";
            this.lblMontoVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPagoTransferencia
            // 
            this.pnlPagoTransferencia.Location = new System.Drawing.Point(24, 286);
            this.pnlPagoTransferencia.Name = "pnlPagoTransferencia";
            this.pnlPagoTransferencia.Size = new System.Drawing.Size(432, 0);
            this.pnlPagoTransferencia.TabIndex = 15;
            this.pnlPagoTransferencia.Visible = false;
            // 
            // pnlReferencia
            // 
            this.pnlReferencia.BackColor = System.Drawing.Color.White;
            this.pnlReferencia.Controls.Add(this.lblNombreCliente);
            this.pnlReferencia.Controls.Add(this.tbxNombreCliente);
            this.pnlReferencia.Location = new System.Drawing.Point(24, 400);
            this.pnlReferencia.Name = "pnlReferencia";
            this.pnlReferencia.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlReferencia.Size = new System.Drawing.Size(432, 58);
            this.pnlReferencia.TabIndex = 16;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(102, 112, 133);
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(56, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "NOMBRE";
            // 
            // tbxNombreCliente
            // 
            this.tbxNombreCliente.BackColor = System.Drawing.Color.White;
            this.tbxNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbxNombreCliente.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.tbxNombreCliente.Location = new System.Drawing.Point(96, 14);
            this.tbxNombreCliente.MaxLength = 30;
            this.tbxNombreCliente.Name = "tbxNombreCliente";
            this.tbxNombreCliente.Size = new System.Drawing.Size(320, 25);
            this.tbxNombreCliente.TabIndex = 7;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnVolver);
            this.pnlActions.Controls.Add(this.btnCobrar);
            this.pnlActions.Location = new System.Drawing.Point(24, 478);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(432, 52);
            this.pnlActions.TabIndex = 18;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 219, 232);
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnVolver.Location = new System.Drawing.Point(0, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(132, 40);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(264, 6);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(168, 40);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "❚  COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmCobro
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(233, 237, 243);
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(480, 550);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblAvisoEfectivo);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlPagoEfectivo);
            this.Controls.Add(this.pnlPagoTransferencia);
            this.Controls.Add(this.pnlReferencia);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobrar — Kiosco26";
            this.Shown += new System.EventHandler(this.frmCobro_Shown);
            this.pnlFormaPago.ResumeLayout(false);
            this.pnlFormaPago.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlPagoEfectivo.ResumeLayout(false);
            this.pnlPagoEfectivo.PerformLayout();
            this.pnlReferencia.ResumeLayout(false);
            this.pnlReferencia.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxMontoEfectivo;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblClientePagaEfectivo;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblMontoVuelto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RadioButton btnPagoEfectivo;
        private System.Windows.Forms.RadioButton btnPagoTransferencia;
        private System.Windows.Forms.Panel pnlFormaPago;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlPagoEfectivo;
        private System.Windows.Forms.Panel pnlPagoTransferencia;
        private System.Windows.Forms.Panel pnlReferencia;
        private System.Windows.Forms.TextBox tbxNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblAvisoEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlActions;
    }
}
