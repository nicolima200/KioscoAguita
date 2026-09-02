using service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static service.LicenciaService;


namespace frmPrincipal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!VerificarLicencia())
                    return;
                
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fatal al iniciar: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private static bool VerificarLicencia()
        {
            LicenciaService licenciaService = new LicenciaService();

            EstadoLicencia resultado = licenciaService.RefrescarAsync().GetAwaiter().GetResult();

            if (resultado == EstadoLicencia.Renovada)
                return true;

            if (resultado == EstadoLicencia.SinConexion)
            {

                string token = licenciaService.LeerTokenGuardado();

                if (token != null)
                {
                    try
                    {
                        licenciaService.ValidarToken(token);
                        return true;
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            using (var frm = new frmActivarLicencia())
                return frm.ShowDialog() == DialogResult.OK;
        }
    }
}
