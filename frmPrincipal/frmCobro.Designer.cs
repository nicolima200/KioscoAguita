namespace frmPrincipal
{
    partial class frmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobro));
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxMontoEfectivo = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblClientePagaEfectivo = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblMontoVuelto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPagoEfectivo = new System.Windows.Forms.RadioButton();
            this.btnPagoTransferencia = new System.Windows.Forms.RadioButton();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pnlPagoEfectivo = new System.Windows.Forms.Panel();
            this.pnlPagoTransferencia = new System.Windows.Forms.Panel();
            this.pnlReferencia = new System.Windows.Forms.Panel();
            this.tbxNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblAvisoEfectivo = new System.Windows.Forms.Label();
            this.pnlFormaPago.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlPagoEfectivo.SuspendLayout();
            this.pnlReferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(48, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL:";
            // 
            // tbxMontoEfectivo
            // 
            this.tbxMontoEfectivo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMontoEfectivo.Location = new System.Drawing.Point(279, 3);
            this.tbxMontoEfectivo.Name = "tbxMontoEfectivo";
            this.tbxMontoEfectivo.Size = new System.Drawing.Size(227, 45);
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
            // lblMontoTotal
            // 
            this.lblMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoTotal.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblMontoTotal.Location = new System.Drawing.Point(209, 17);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(259, 47);
            this.lblMontoTotal.TabIndex = 3;
            this.lblMontoTotal.Text = "Monto";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClientePagaEfectivo
            // 
            this.lblClientePagaEfectivo.AutoSize = true;
            this.lblClientePagaEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientePagaEfectivo.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePagaEfectivo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClientePagaEfectivo.Location = new System.Drawing.Point(9, 8);
            this.lblClientePagaEfectivo.Name = "lblClientePagaEfectivo";
            this.lblClientePagaEfectivo.Size = new System.Drawing.Size(251, 34);
            this.lblClientePagaEfectivo.TabIndex = 4;
            this.lblClientePagaEfectivo.Text = "El cliente paga con:";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVuelto.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVuelto.Location = new System.Drawing.Point(158, 71);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(102, 34);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "Vuelto:";
            // 
            // lblMontoVuelto
            // 
            this.lblMontoVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontoVuelto.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoVuelto.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMontoVuelto.Location = new System.Drawing.Point(279, 65);
            this.lblMontoVuelto.Name = "lblMontoVuelto";
            this.lblMontoVuelto.Size = new System.Drawing.Size(227, 47);
            this.lblMontoVuelto.TabIndex = 6;
            this.lblMontoVuelto.Text = "MontoVuelto";
            this.lblMontoVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(197, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 77);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cobrar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCobrar
            // 
            this.btnCobrar.AutoSize = true;
            this.btnCobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Cambria", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCobrar.Location = new System.Drawing.Point(239, 540);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(165, 53);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVolver.Location = new System.Drawing.Point(544, 600);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 38);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPagoEfectivo.AutoSize = true;
            this.btnPagoEfectivo.Checked = true;
            this.btnPagoEfectivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPagoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoEfectivo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPagoEfectivo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPagoEfectivo.Location = new System.Drawing.Point(3, 35);
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.Size = new System.Drawing.Size(173, 49);
            this.btnPagoEfectivo.TabIndex = 10;
            this.btnPagoEfectivo.TabStop = true;
            this.btnPagoEfectivo.Text = "EFECTIVO";
            this.btnPagoEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPagoTransferencia
            // 
            this.btnPagoTransferencia.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPagoTransferencia.AutoSize = true;
            this.btnPagoTransferencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPagoTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoTransferencia.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPagoTransferencia.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPagoTransferencia.Location = new System.Drawing.Point(228, 35);
            this.btnPagoTransferencia.Name = "btnPagoTransferencia";
            this.btnPagoTransferencia.Size = new System.Drawing.Size(276, 49);
            this.btnPagoTransferencia.TabIndex = 11;
            this.btnPagoTransferencia.Text = "TRANSFERENCIA";
            this.btnPagoTransferencia.UseVisualStyleBackColor = true;
            this.btnPagoTransferencia.CheckedChanged += new System.EventHandler(this.btnPagoTransferencia_CheckedChanged);
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.Controls.Add(this.label1);
            this.pnlFormaPago.Controls.Add(this.btnPagoEfectivo);
            this.pnlFormaPago.Controls.Add(this.btnPagoTransferencia);
            this.pnlFormaPago.Location = new System.Drawing.Point(69, 191);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Size = new System.Drawing.Size(505, 87);
            this.pnlFormaPago.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "TAB para alternar";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblMontoTotal);
            this.pnlTotal.Location = new System.Drawing.Point(79, 120);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(468, 65);
            this.pnlTotal.TabIndex = 13;
            // 
            // pnlPagoEfectivo
            // 
            this.pnlPagoEfectivo.Controls.Add(this.tbxMontoEfectivo);
            this.pnlPagoEfectivo.Controls.Add(this.lblClientePagaEfectivo);
            this.pnlPagoEfectivo.Controls.Add(this.lblVuelto);
            this.pnlPagoEfectivo.Controls.Add(this.lblMontoVuelto);
            this.pnlPagoEfectivo.Location = new System.Drawing.Point(42, 305);
            this.pnlPagoEfectivo.Name = "pnlPagoEfectivo";
            this.pnlPagoEfectivo.Size = new System.Drawing.Size(535, 117);
            this.pnlPagoEfectivo.TabIndex = 14;
            // 
            // pnlPagoTransferencia
            // 
            this.pnlPagoTransferencia.Location = new System.Drawing.Point(14, 305);
            this.pnlPagoTransferencia.Name = "pnlPagoTransferencia";
            this.pnlPagoTransferencia.Size = new System.Drawing.Size(614, 0);
            this.pnlPagoTransferencia.TabIndex = 15;
            this.pnlPagoTransferencia.Visible = false;
            // 
            // pnlReferencia
            // 
            this.pnlReferencia.Controls.Add(this.tbxNombreCliente);
            this.pnlReferencia.Controls.Add(this.lblNombreCliente);
            this.pnlReferencia.Location = new System.Drawing.Point(42, 435);
            this.pnlReferencia.Name = "pnlReferencia";
            this.pnlReferencia.Size = new System.Drawing.Size(535, 55);
            this.pnlReferencia.TabIndex = 16;
            // 
            // tbxNombreCliente
            // 
            this.tbxNombreCliente.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreCliente.Location = new System.Drawing.Point(279, 3);
            this.tbxNombreCliente.MaxLength = 30;
            this.tbxNombreCliente.Name = "tbxNombreCliente";
            this.tbxNombreCliente.Size = new System.Drawing.Size(227, 39);
            this.tbxNombreCliente.TabIndex = 7;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreCliente.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombreCliente.Location = new System.Drawing.Point(137, 6);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(123, 34);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblAvisoEfectivo
            // 
            this.lblAvisoEfectivo.AutoSize = true;
            this.lblAvisoEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvisoEfectivo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoEfectivo.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoEfectivo.Location = new System.Drawing.Point(335, 287);
            this.lblAvisoEfectivo.Name = "lblAvisoEfectivo";
            this.lblAvisoEfectivo.Size = new System.Drawing.Size(184, 21);
            this.lblAvisoEfectivo.TabIndex = 7;
            this.lblAvisoEfectivo.Text = "Ingrese un monto válido:";
            this.lblAvisoEfectivo.Visible = false;
            // 
            // frmCobro
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(642, 650);
            this.Controls.Add(this.lblAvisoEfectivo);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlPagoEfectivo);
            this.Controls.Add(this.pnlPagoTransferencia);
            this.Controls.Add(this.pnlReferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobro";
            this.Shown += new System.EventHandler(this.frmCobro_Shown);
            this.pnlFormaPago.ResumeLayout(false);
            this.pnlFormaPago.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlPagoEfectivo.ResumeLayout(false);
            this.pnlPagoEfectivo.PerformLayout();
            this.pnlReferencia.ResumeLayout(false);
            this.pnlReferencia.PerformLayout();
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
    }
}