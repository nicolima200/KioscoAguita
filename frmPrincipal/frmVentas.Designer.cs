namespace frmPrincipal
{
    partial class frmVentas
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
            this.lblCantProductos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lbxPrecios = new System.Windows.Forms.ListBox();
            this.lbxProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCantProductos
            // 
            this.lblCantProductos.AutoSize = true;
            this.lblCantProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCantProductos.Location = new System.Drawing.Point(460, 407);
            this.lblCantProductos.Name = "lblCantProductos";
            this.lblCantProductos.Size = new System.Drawing.Size(89, 24);
            this.lblCantProductos.TabIndex = 24;
            this.lblCantProductos.Text = "Cantidad:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTotal.Location = new System.Drawing.Point(621, 469);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 26);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblListaProductos.Location = new System.Drawing.Point(459, 19);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(68, 24);
            this.lblListaProductos.TabIndex = 22;
            this.lblListaProductos.Text = "Ventas";
            // 
            // lbxPrecios
            // 
            this.lbxPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbxPrecios.FormattingEnabled = true;
            this.lbxPrecios.ItemHeight = 20;
            this.lbxPrecios.Location = new System.Drawing.Point(789, 50);
            this.lbxPrecios.Name = "lbxPrecios";
            this.lbxPrecios.Size = new System.Drawing.Size(113, 344);
            this.lbxPrecios.TabIndex = 21;
            // 
            // lbxProductos
            // 
            this.lbxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbxProductos.FormattingEnabled = true;
            this.lbxProductos.ItemHeight = 20;
            this.lbxProductos.Location = new System.Drawing.Point(464, 50);
            this.lbxProductos.Name = "lbxProductos";
            this.lbxProductos.Size = new System.Drawing.Size(328, 344);
            this.lbxProductos.TabIndex = 20;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 548);
            this.Controls.Add(this.lblCantProductos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lbxPrecios);
            this.Controls.Add(this.lbxProductos);
            this.Name = "frmVentas";
            this.Text = "Gestor Kiosco - VENTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.ListBox lbxPrecios;
        private System.Windows.Forms.ListBox lbxProductos;
    }
}