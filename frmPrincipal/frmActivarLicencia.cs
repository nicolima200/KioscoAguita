using service;
using System;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmActivarLicencia : Form
    {
        private LicenciaService licenciaService = new LicenciaService();
        public frmActivarLicencia()
        {
            InitializeComponent();
            lblEstado.Text = "";
        }
        private async void btnActivar_Click(object sender, EventArgs e)
        {
            btnActivar.Enabled = false;
            lblEstado.Text= "Activando licencia...";

            try
            {
                string token= await 
                licenciaService.ActivarAsync(txbEmail.Text.Trim(), txbPassword.Text);
                licenciaService.GuardarToken(token);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
                btnActivar.Enabled = true;
            }
        }
    }
}
