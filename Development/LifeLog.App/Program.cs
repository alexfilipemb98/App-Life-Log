using DevExpress.XtraSplashScreen;
using LifeLog.App.Helpers;
using LifeLog.Base.Infrastructure.Exceptions;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Auth;
using LifeLog.UI.Common.Forms.Loading;
using LifeLog.UI.Common.Helpers;
using System;
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

				do
				{
					AppSession.Container?.Dispose();

					AppSession.AppConfigs = AppHelper.LoadAppConfigs();
					AppSession.DbConfigs = AppHelper.GetDatabaseConfigs();

					AppSession.AuthForm = new AuthForm();

					try
					{
						AppSession.DataEngine = new Data.Database.Engine(AppSession.DbConfigs);
						AppSession.AuthForm.IsConfigsOk = true;
					}
					catch (ValidationException)
					{
						AppSession.AuthForm.IsConfigsOk = false;
					}

					if (AppSession.AppConfigs.InternalApiEnabled && !string.IsNullOrWhiteSpace(AppSession.AppConfigs.InternalApiUrl))
					{
						AppSession.ApiEngine = new Services.Api.Engine(AppSession.DataEngine);
						AppSession.ApiEngine.Inicialize(AppSession.AppConfigs.InternalApiUrl);
					}

					AppSession.AuthForm.Shown += (s, e) =>
						SplashScreenManager.CloseForm(false);

					AppSession.AuthForm.FormClosed += (s, e) =>
						AppSession.AuthForm.Dispose();

					if (AppSession.AuthForm.ShowDialog() != DialogResult.Yes)
						Environment.Exit(0);

					AppSession.Container = new AppContainer($"LifeLog.UI.{AppSession.AuthForm.AplicationInterface.ToString()}");

					Application.Run(AppSession.Container.EngineForm.MainForm);
				}
				while (AppSession.Container.EngineForm.IsUserLogingout);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
			finally
			{
				AppHelper.SaveAppSetings();
				AppSession.Container?.Dispose();
				AppSession.DataEngine?.Dispose();
			}
		}
	}
}
