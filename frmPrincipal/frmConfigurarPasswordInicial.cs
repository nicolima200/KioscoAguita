using service;
using System;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmConfigurarPasswordInicial : Form
    {
        public frmConfigurarPasswordInicial()
        {
            InitializeComponent();
        }

        private void chkMostrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNueva.PasswordChar = chkMostrarPassword.Checked ? '\0' : '-';
            txtConfirmar.PasswordChar = chkMostrarPassword.Checked ? '\0' : '-';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string nueva = txtNueva.Text;
            string confirmar = txtConfirmar.Text;

            if (string.IsNullOrEmpty(nueva) || string.IsNullOrEmpty(confirmar))
            {
                MostrarError("Debés ingresar y confirmar la contraseña.");
                return;
            }

            if (nueva.Length < 8)
            {
                MostrarError("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            if (nueva != confirmar)
            {
                MostrarError("Las contraseñas no coinciden.");
                return;
            }

            try
            {
                new UsuarioService().ConfigurarPassword(nueva);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }
    }
}
