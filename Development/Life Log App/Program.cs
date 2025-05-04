using Data;
using DevExpress.XtraSplashScreen;
using Life_Log_App.Forms.Loading;
using Life_Log_App.Helpers;
using Life_Log_App.Forms;
using System;
using System.Windows.Forms;
using Exceptions;

namespace Life_Log_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), true, true, false);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppContext.AppConfigs = AppHelper.LoadAppConfigs();
                AppContext.DbConfigs = AppHelper.GetDatabaseConfigs();

                AppContext.AuthForm = new Forms.Auth.AuthForm();

                try
                {
                    AppContext.DataEngine = new Engine(AppContext.DbConfigs);
                    AppContext.AuthForm.IsConfigsOk = true;
                }
                catch (ValidationException)
                {
                    AppContext.AuthForm.IsConfigsOk = false;
                }

                if (AppContext.AppConfigs.InternalApiEnabled && !string.IsNullOrWhiteSpace(AppContext.AppConfigs.InternalApiUrl))
                {
                    AppContext.ApiEngine = new Api.Engine(AppContext.DataEngine);
                    AppContext.ApiEngine.Inicialize(AppContext.AppConfigs.InternalApiUrl);
                }

                AppContext.AuthForm.Shown += (s, e) =>
                    SplashScreenManager.CloseForm(false);

                if (AppContext.AuthForm.ShowDialog() != DialogResult.Yes)
                    return;

                SplashScreenManager.ShowForm(null, typeof(LoadingForm), true, true, false);

                AppContext.AuthForm.Dispose();

                AppContext.ModuleSettings = AppContext.DataEngine.ModuleSettings.GetUserModuleSettings(AppContext.CurrentUser.Id);

                AppContext.MainForm = new MainForm();

                AppContext.MainForm.Height = AppContext.AppConfigs.MainFormHeight;
                AppContext.MainForm.Width = AppContext.AppConfigs.MainFormWidth;
                AppContext.MainForm.WindowState = (FormWindowState)AppContext.AppConfigs.MainFormWindowState;

                AppContext.MainForm.Shown += (s, e) =>
                    SplashScreenManager.CloseForm(false);

                Application.Run(AppContext.MainForm);
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
            finally
            {
                AppHelper.SaveAppSetings();

                if (AppContext.DataEngine != null && AppContext.DataEngine.IsConnected)
                    AppContext.DataEngine.Dispose();
            }

        }
    }
}
