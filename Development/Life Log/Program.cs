using Core.Extensions;
using Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Life_Log.Forms;
using Life_Log.Forms.Loading;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Life_Log
{
    /// <summary>
    /// Program main class to start the application and handle exceptions
    /// </summary>111111111111
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                AppHelper.CheckForRunningInstance();

                SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

                AppHelper.LoadAppConfigs();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppHelper.GetDatabaseConfigs();
                AppHelper.DataEngine = new Data.Engine(AppHelper.DbConfigs);
                AppHelper.DataEngine.SQLLiteBackUp();
                AppHelper.DataEngine.Connect();

                //new Api.Engine("http://localhost:9000/", AppHelper.DataEngine);

                LoginForm loginForm = new LoginForm();

                loginForm.Shown += (s, e) =>
                {
                    SplashScreenManager.CloseForm();
                };

                loginForm.FormClosing += (s, e) =>
                {
                    if (loginForm.DialogResult == DialogResult.Yes)
                        SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);
                };

                DialogResult loginResult = loginForm.ShowDialog();

                if (loginResult == DialogResult.Yes)
                {
                    AppHelper.MainFormInstance = new MainForm();

                    AppHelper.MainFormInstance.Shown += (s, e) =>
                    {
                        SplashScreenManager.CloseForm();
                    };

                    Application.Run(AppHelper.MainFormInstance);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
            finally
            {
                AppHelper.DataEngine?.Disconnect();
            }
        }
    }
}
