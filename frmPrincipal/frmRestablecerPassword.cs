using service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmRestablecerPassword : Form
    {
        private LicenciaService licenciaService = new LicenciaService();
        private string ticketPendiente;

        public frmRestablecerPassword()
        {
            InitializeComponent();
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MostrarEstado("Ingresá el código de 6 dígitos que te dio soporte.", Color.Firebrick);
                return;
            }

            btnValidar.Enabled = false;
            MostrarEstado("Validando código...", Color.DimGray);

            try
            {
                ticketPendiente = await licenciaService.AutorizarRestablecimientoAsync(codigo);

                new UsuarioService().PrepararRestablecimiento();

                using (var frmPass = new frmConfigurarPasswordInicial())
                {
                    if (frmPass.ShowDialog(this) != DialogResult.OK)
                    {
                        MostrarEstado("No se cambió la contraseña. El código sigue pendiente.", Color.DimGray);
                        btnValidar.Enabled = true;
                        return;
                    }
                }

                await licenciaService.ConfirmarRestablecimientoAsync(ticketPendiente);

                MostrarEstado("Contraseña restablecida. Ingresá con tu nueva contraseña.", Color.ForestGreen);
                btnCerrar.Visible = true;
            }
            catch (Exception ex)
            {
                MostrarEstado(ex.Message, Color.Firebrick);
                btnValidar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MostrarEstado(string mensaje, Color color)
        {
            lblEstado.Text = mensaje;
            lblEstado.ForeColor = color;
        }
    }
}
