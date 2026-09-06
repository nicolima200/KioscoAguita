using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace frmPrincipal
{
    /// <summary>
    /// Chequea actualizaciones contra UpdateUrl (App.config) usando AutoUpdater.NET.
    /// Silencioso: si falla o no hay red, la app sigue normalmente.
    /// </summary>
    public static class ActualizacionService
    {
        private static bool configurado;
        private static bool chequeoManual;

        public static void Chequear(bool manual)
        {
            try
            {
                Configurar();

                string url = ConfigurationManager.AppSettings["UpdateUrl"];
                if (string.IsNullOrWhiteSpace(url))
                    return;

                chequeoManual = manual;
                AutoUpdater.Start(url);
            }
            catch
            {
                chequeoManual = false;
            }
        }

        private static void Configurar()
        {
            if (configurado)
                return;
            configurado = true;

            AutoUpdater.PersistenceProvider = new JsonFilePersistenceProvider(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                    "KioscoAguita",
                    "updates.json"));
            AutoUpdater.LetUserSelectRemindLater = false;
            AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            AutoUpdater.RemindLaterAt = 7;
            AutoUpdater.ShowSkipButton = true;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.ReportErrors = false;
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
        }

        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            try
            {
                if (args == null)
                    return;

                bool manual = chequeoManual;
                chequeoManual = false;

                if (args.Error != null)
                {
                    if (manual)
                        MessageBox.Show(
                            "No se pudo verificar actualizaciones (sin conexión o servidor no disponible).",
                            "Buscar actualizaciones",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                if (args.IsUpdateAvailable)
                {
                    Form owner = Application.OpenForms.Count > 0 ? Application.OpenForms[0] : null;

                    DialogResult respuesta = MessageBox.Show(
                        owner,
                        "Hay una nueva versión disponible (" + args.CurrentVersion + ").\n¿Descargar e instalar ahora?",
                        "Actualización disponible",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.OK && AutoUpdater.DownloadUpdate(args))
                        Application.Exit();
                }
                else if (manual)
                {
                    MessageBox.Show(
                        "Ya tenés la última versión instalada (" + args.InstalledVersion + ").",
                        "Buscar actualizaciones",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch
            {
                // nunca romper la app por el updater
            }
        }
    }
}