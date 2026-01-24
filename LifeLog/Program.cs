using DevExpress.XtraSplashScreen;
using LifeLog.Core.Models;
using LifeLog.Forms;
using LifeLog.Forms.Auth;
using LifeLog.Forms.Loading;
using LifeLog.Helpers;
using LifeLog.Services;
using System.IO;

namespace LifeLog;

internal static class Program
{
    internal static DatabaseConfigModel? DbConfigs { get; set; }
    internal static Data.Engine? DataEngine { get; set; }
    internal static Services.Api.Engine? ApiEngine { get; set; }
    internal static LoggedUserModel? LoggedUser { get; set; }
    internal static AppConfigsModel? AppConfigs { get; set; }
    internal static AuthForm? AuthForm { get; private set; }
    internal static MainForm? MainForm { get; private set; }
    internal static LoggerService? Logger { get; private set; }
    internal static string? UserDir { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

            ApplicationConfiguration.Initialize();

            UserDir = Path.Combine("Machines", Environment.MachineName, Environment.UserName);

            if (!Directory.Exists(UserDir))
                Directory.CreateDirectory(UserDir);

            Logger = new LoggerService(UserDir);

            Application.ThreadException += (s, e) =>
                    ErrorHelper.Handler(e.Exception);

            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                ErrorHelper.Handler(e.Exception);
                e.SetObserved();
            };

            Application.ApplicationExit += async (_, _) =>
            {
                if (ApiEngine is not null)
                    await ApiEngine.DisposeAsync();

                DataEngine?.Dispose();
            };

            DbConfigs = AppHelper.GetDatabaseConfig();

            DataEngine = new Data.Engine(DbConfigs);

            ApiEngine = new Services.Api.Engine();

            if (DbConfigs.ApiEnabled && !string.IsNullOrWhiteSpace(DbConfigs.ApiUrl))
                _ = Task.Run(() => ApiEngine.StartAsync(DataEngine.Connection, DbConfigs.ApiUrl));

            AppConfigs = AppHelper.ReadAppConfigs();

            using (AuthForm = new())
            {
                AuthForm.Shown += (s, e) => SplashScreenManager.CloseForm(false);

                if (AuthForm.ShowDialog() != DialogResult.Yes)
                    Environment.Exit(0);
            }

            MainForm = new();

            Application.Run(MainForm);
        }
        catch (Exception ex)
        {
            ErrorHelper.Handler(ex);
        }
    }
}

