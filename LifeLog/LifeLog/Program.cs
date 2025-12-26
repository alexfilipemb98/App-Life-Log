using Core.Models;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraSplashScreen;
using LifeLog.Helpers;
using LifeLog.UI.Common.Forms.Auth;
using LifeLog.UI.Common.Forms.Loading;

namespace LifeLog;

internal static class Program
{
	internal static Data.Engine? DataEngine { get; set; }
	internal static LoggedUserModel? LoggedUser { get; set; }

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

		using (AuthForm authForm = new())
		{
			authForm.Shown += (s, e) => SplashScreenManager.CloseForm(false);

			if (authForm.ShowDialog() != DialogResult.Yes)
				Environment.Exit(0);
		}

		Application.Run(new AuthForm());
	}
}

