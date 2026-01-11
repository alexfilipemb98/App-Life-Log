using DevExpress.XtraSplashScreen;
using LifeLog.Core.Models;
using LifeLog.Forms;
using LifeLog.Forms.Auth;
using LifeLog.Forms.Loading;
using LifeLog.Helpers;
using LifeLog.Services;
using LifeLog.Services.Api;
using System.IO;

namespace LifeLog;

internal static class Program
{
    internal static Data.Engine? DataEngine { get; set; }
    internal static LoggedUserModel? LoggedUser { get; set; }
    internal static AppConfigsModel? AppConfigs { get; set; }
    internal static AuthForm? AuthForm { get; set; }
    internal static MainForm? MainForm { get; set; }
    internal static LoggerService? Logger { get; set; }
    internal static string? UserDir { get; set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

        ApplicationConfiguration.Initialize();

        UserDir = Path.Combine(Environment.MachineName, Environment.UserName);

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

        DatabaseConfigModel configs = DbHelper.GetDatabaseConfig();

        DataEngine = new Data.Engine(configs);

        ApiHost host = new();
        _ = Task.Run(() => host.StartAsync(DataEngine.Connection, new[] { "http://localhost:5055" }));

        Application.ApplicationExit += async (_, __) => await host.DisposeAsync();

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
}

