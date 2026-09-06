using dominio;
using dominio.enums;
using service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkMostrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = chkMostrarPassword.Checked ? '\0' : '-';
        }

        private void btnAccederSoloVenta_Click(object sender, EventArgs e)
        {
            btnAccederAdmin.Enabled = false;
            btnAccederSoloVenta.Enabled = false;

            Usuario vendedor = new Usuario()
            {
                Nombre = "Empleado",
                TipoUsuario = TipoUsuario.Empleado
            };

            Sesion.UsuarioActual = vendedor;
            this.Hide();
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();

            Sesion.UsuarioActual = null;
            this.Show();
            btnAccederAdmin.Enabled = true;
            btnAccederSoloVenta.Enabled = true;
            tbxPassword.Focus();
        }

        private void btnAccederAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña de administrador.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioService usuarioService = new UsuarioService();

            Usuario usuarioActual = usuarioService.LoginAdmin(tbxPassword.Text);

            if (usuarioActual == null)
            {
                MessageBox.Show("Contraseña inválida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDatosInvalidos.Visible = true;
                return;
            }

            deshabilitarYOcultar();
            Sesion.UsuarioActual = usuarioActual;

            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();

            Sesion.UsuarioActual = null;
            tbxPassword.Clear();
            chkMostrarPassword.Checked = false;
            deshabilitarYOcultar(false);
            lblDatosInvalidos.Visible = false;

            tbxPassword.Focus();
        }

        private void lblOlvidarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new frmRestablecerPassword())
            {
                frm.ShowDialog(this);
            }

            tbxPassword.Focus();
        }

        private void deshabilitarYOcultar(bool ocultar = true)
        {
            btnAccederAdmin.Enabled = !ocultar;
            btnAccederSoloVenta.Enabled = !ocultar;

            if (ocultar) this.Hide(); else this.Show();
        }
    }
}
