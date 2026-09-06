namespace frmPrincipal
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.chkMostrarPassword = new System.Windows.Forms.CheckBox();
            this.btnAccederAdmin = new System.Windows.Forms.Button();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.lblDatosInvalidos = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gbxSoloVenta = new System.Windows.Forms.GroupBox();
            this.btnAccederSoloVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblOlvidarPassword = new System.Windows.Forms.LinkLabel();
            this.gbxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.gbxSoloVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(100, 40);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '-';
            this.tbxPassword.Size = new System.Drawing.Size(142, 20);
            this.tbxPassword.TabIndex = 3;
            // 
            // chkMostrarPassword
            // 
            this.chkMostrarPassword.AutoSize = true;
            this.chkMostrarPassword.Location = new System.Drawing.Point(100, 66);
            this.chkMostrarPassword.Name = "chkMostrarPassword";
            this.chkMostrarPassword.Size = new System.Drawing.Size(118, 17);
            this.chkMostrarPassword.TabIndex = 8;
            this.chkMostrarPassword.Text = "Mostrar contraseña";
            this.chkMostrarPassword.UseVisualStyleBackColor = true;
            this.chkMostrarPassword.CheckedChanged += new System.EventHandler(this.chkMostrarPassword_CheckedChanged);
            // 
            // btnAccederAdmin
            // 
            this.btnAccederAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccederAdmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAccederAdmin.Location = new System.Drawing.Point(98, 98);
            this.btnAccederAdmin.Name = "btnAccederAdmin";
            this.btnAccederAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAccederAdmin.TabIndex = 4;
            this.btnAccederAdmin.Text = "Acceder";
            this.btnAccederAdmin.UseVisualStyleBackColor = true;
            this.btnAccederAdmin.Click += new System.EventHandler(this.btnAccederAdmin_Click);
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Controls.Add(this.lblOlvidarPassword);
            this.gbxAdmin.Controls.Add(this.lblDatosInvalidos);
            this.gbxAdmin.Controls.Add(this.lblPassword);
            this.gbxAdmin.Controls.Add(this.btnAccederAdmin);
            this.gbxAdmin.Controls.Add(this.tbxPassword);
            this.gbxAdmin.Controls.Add(this.chkMostrarPassword);
            this.gbxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAdmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxAdmin.Location = new System.Drawing.Point(28, 196);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(271, 205);
            this.gbxAdmin.TabIndex = 6;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "Gestión y venta";
            // 
            // lblDatosInvalidos
            // 
            this.lblDatosInvalidos.AutoSize = true;
            this.lblDatosInvalidos.ForeColor = System.Drawing.Color.Red;
            this.lblDatosInvalidos.Location = new System.Drawing.Point(49, 128);
            this.lblDatosInvalidos.Name = "lblDatosInvalidos";
            this.lblDatosInvalidos.Size = new System.Drawing.Size(118, 13);
            this.lblDatosInvalidos.TabIndex = 5;
            this.lblDatosInvalidos.Text = "Contraseña inválida";
            this.lblDatosInvalidos.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // pbxLogo
            // 
            this.pbxLogo.ErrorImage = global::frmPrincipal.Properties.Resources.imagenNoEncontrada;
            this.pbxLogo.Image = global::frmPrincipal.Properties.Resources.logoKiosco26;
            this.pbxLogo.InitialImage = global::frmPrincipal.Properties.Resources.logoKiosco26;
            this.pbxLogo.Location = new System.Drawing.Point(83, 21);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(160, 160);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // gbxSoloVenta
            // 
            this.gbxSoloVenta.Controls.Add(this.btnAccederSoloVenta);
            this.gbxSoloVenta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxSoloVenta.Location = new System.Drawing.Point(28, 407);
            this.gbxSoloVenta.Name = "gbxSoloVenta";
            this.gbxSoloVenta.Size = new System.Drawing.Size(271, 55);
            this.gbxSoloVenta.TabIndex = 7;
            this.gbxSoloVenta.TabStop = false;
            this.gbxSoloVenta.Text = "Sólo venta";
            // 
            // btnAccederSoloVenta
            // 
            this.btnAccederSoloVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAccederSoloVenta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAccederSoloVenta.Location = new System.Drawing.Point(98, 19);
            this.btnAccederSoloVenta.Name = "btnAccederSoloVenta";
            this.btnAccederSoloVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAccederSoloVenta.TabIndex = 4;
            this.btnAccederSoloVenta.Text = "Acceder";
            this.btnAccederSoloVenta.UseVisualStyleBackColor = true;
            this.btnAccederSoloVenta.Click += new System.EventHandler(this.btnAccederSoloVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(230, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblOlvidarPassword
            // 
            this.lblOlvidarPassword.AutoSize = true;
            this.lblOlvidarPassword.Location = new System.Drawing.Point(49, 153);
            this.lblOlvidarPassword.Name = "lblOlvidarPassword";
            this.lblOlvidarPassword.Size = new System.Drawing.Size(118, 13);
            this.lblOlvidarPassword.TabIndex = 9;
            this.lblOlvidarPassword.TabStop = true;
            this.lblOlvidarPassword.Text = "Olvidé mi contraseña";
            this.lblOlvidarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvidarPassword_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAccederAdmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(327, 509);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.gbxSoloVenta);
            this.Controls.Add(this.gbxAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco26 - Acceder";
            this.gbxAdmin.ResumeLayout(false);
            this.gbxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.gbxSoloVenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.CheckBox chkMostrarPassword;
        private System.Windows.Forms.Button btnAccederAdmin;
        private System.Windows.Forms.GroupBox gbxAdmin;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblDatosInvalidos;
        private System.Windows.Forms.GroupBox gbxSoloVenta;
        private System.Windows.Forms.Button btnAccederSoloVenta;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel lblOlvidarPassword;
    }
}
