using DevExpress.LookAndFeel.Design;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraSplashScreen;
using LifeLog.App.Helpers;
using LifeLog.Data.Models;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Auth;
using LifeLog.UI.Common.Forms.Loading;
using LifeLog.UI.Common.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.App
{
	/// <summary>
	/// The main class for the application.
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		internal static void Main()
		{
			try
			{
				SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

				AppMainHelper.CheckForRunningInstance();

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
				BonusSkins.Register();

				Application.ThreadException += (s, e) =>
					ErrorHelper.Handler(e.Exception);

				TaskScheduler.UnobservedTaskException += (s, e) =>
				{
					ErrorHelper.Handler(e.Exception);
					e.SetObserved();
				};

				AppSession.AppConfigs = AppHelper.LoadAppConfigs();
				ThemeHelper.ApplyTheme();

				AppSession.DbConfigs = AppHelper.GetDatabaseConfigs();
				AppSession.DataEngine = new Data.Database.Engine(AppSession.DbConfigs);

				if (AppSession.DbConfigs.EnableApi)
				{
					AppSession.ApiEngine = new Services.Api.Engine(AppSession.DbConfigs.ApiLink);
					Task.Run(() => LifeLog.UI.Common.Forms.Dialog.AlertForm.Alert("API Service is enabled.", UI.Common.Forms.Dialog.AlertForm.enmType.Info));
				}

				using (AppSession.AuthForm = new AuthForm())
				{
					AppSession.AuthForm.Shown += (s, e) =>
					{
						SplashScreenManager.CloseForm(false);
					};

					do
					{
						if (AppSession.AuthForm.ShowDialog() != DialogResult.Yes)
							Environment.Exit(0);

						SplashScreenManager.ShowForm(typeof(SplashScreenForm), true, true);

						AppSession.Container = new AppContainer($"LifeLog.UI.{AppSession.AuthForm.AplicationInterface.ToString()}");

						AppSession.Container.EngineForm.MainForm.Shown += (s, e) =>
						{
							SplashScreenManager.CloseForm(false);
						};

						Application.Run(AppSession.Container.EngineForm.MainForm);
					}
					while (AppSession.Container.EngineForm.IsUserLogingout);
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
			finally
			{
				ThemeHelper.Capture();
				AppHelper.SaveAppSetings();

				AppSession.Container?.Dispose();
				AppSession.ApiEngine?.Dispose();
				AppSession.DataEngine?.Dispose();
			}
		}
	}
}
