using Core.Models;
using DevExpress.XtraSplashScreen;
using LifeLog.Forms;
using LifeLog.Forms.Auth;
using LifeLog.Forms.Loading;
using LifeLog.Helpers;

namespace LifeLog;

internal static class Program
{
	internal static Data.Engine? DataEngine { get; set; }
	internal static LoggedUserModel? LoggedUser { get; set; }
	internal static AppConfigsModel? AppConfigs { get; set; }
	internal static MainForm? MainForm { get; set; }

	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

		ApplicationConfiguration.Initialize();


		Application.ThreadException += (s, e) =>
				ErrorHelper.Handler(e.Exception);

		TaskScheduler.UnobservedTaskException += (s, e) =>
		{
			ErrorHelper.Handler(e.Exception);
			e.SetObserved();
		};

		Core.Models.DatabaseConfigModel configs = DbHelper.GetDatabaseConfig();

		DataEngine = new Data.Engine(configs);

		AppConfigs = AppHelper.ReadAppConfigs();

		using (AuthForm authForm = new())
		{
			authForm.Shown += (s, e) => SplashScreenManager.CloseForm(false);

			if (authForm.ShowDialog() != DialogResult.Yes)
				Environment.Exit(0);
		}

		MainForm = new();

		Application.Run(MainForm);
	}
}

