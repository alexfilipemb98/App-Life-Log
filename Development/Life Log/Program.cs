using Core.Extensions;
using Core.Utils;
using Data.Entities;
using Data.Queries;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Life_Log.Forms;
using Life_Log.Forms.Dialogs;
using Life_Log.Forms.Loading;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Life_Log
{
    /// <summary>
    /// Program main class to start the application and handle exceptions
    /// </summary>
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
                SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

                AppHelper.CheckForRunningInstance();

                AppHelper.LoadAppConfigs();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppHelper.InicializeDataEngines();

                LoggerUtil.Initialize();

                //AppHelper.ApiEngine.Inicialize("http://localhost:9000/");

                AppHelper.LoginFormInstance = new LoginForm();

                AppHelper.LoginFormInstance.Shown += (s, e) =>
                {
                    SplashScreenManager.CloseForm();
                };

                AppHelper.LoginFormInstance.FormClosing += (s, e) =>
                {
                    if (AppHelper.LoginFormInstance.DialogResult == DialogResult.Yes)
                    {
                        AppHelper.LoginFormInstance.Dispose();
                        SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);
                    }
                };

                DialogResult loginResult = AppHelper.LoginFormInstance.ShowDialog();

                if (loginResult == DialogResult.Yes)
                {
                    AppHelper.MainFormInstance = new MainForm();

                    AppHelper.MainFormInstance.Height = AppHelper.AppConfigs.FormHeight;
                    AppHelper.MainFormInstance.Width = AppHelper.AppConfigs.FormWidth;

                    AppHelper.MainFormInstance.Shown += (s, e) =>
                    {
                        SplashScreenManager.CloseForm();
                    };

                    Application.Run(AppHelper.MainFormInstance);
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
