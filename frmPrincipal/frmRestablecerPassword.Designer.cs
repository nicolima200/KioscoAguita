namespace frmPrincipal
{
    partial class frmRestablecerPassword
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Restablecer contraseña";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(22, 52);
            this.lblInstruccion.MaximumSize = new System.Drawing.Size(360, 40);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(358, 26);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Contactá a soporte y pedí un código de restablecimiento.\r\nIngresalo abajo para definir una contraseña nueva.";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(25, 96);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(181, 96);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 29);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar código";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 140);
            this.lblEstado.MaximumSize = new System.Drawing.Size(360, 60);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(33, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "...";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(291, 196);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRestablecerPassword
            // 
            this.AcceptButton = this.btnValidar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 231);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestablecerPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiosco26 - Restablecer contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCerrar;
    }
}
