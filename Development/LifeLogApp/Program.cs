using Core.Enums;
using Core.Models;
using Core.Utils;
using Data;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LifeLogApp.Forms;
using LifeLogApp.Forms.Loading;
using LifeLogApp.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LifeLogApp;

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

            AppContext.DataEngine = new Engine(AppContext.DbConfigs);

            AppContext.LoginForm = new Forms.Auth.LoginForm();

            //Api.Engine engine = new Api.Engine(AppContext.DataEngine);
            //engine.Inicialize("http://localhost:9000");

            AppContext.LoginForm.Shown += (s, e) =>
                SplashScreenManager.CloseForm(false);

            if (AppContext.LoginForm.ShowDialog() != DialogResult.Yes)
                return;

            SplashScreenManager.ShowForm(null, typeof(LoadingForm), true, true, false);

            AppContext.LoginForm.Dispose();

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
