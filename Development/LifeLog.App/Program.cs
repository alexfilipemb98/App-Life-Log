using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraSplashScreen;
using LifeLog.App.Helpers;
using LifeLog.Base.Infrastructure.Exceptions;
using LifeLog.Base.Infrastructure.Flags;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Auth;
using LifeLog.UI.Common.Forms.Loading;
using LifeLog.UI.Common.Helpers;
using System;
using System.Runtime.Remoting.Contexts;
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
				AppSession.DataEngine = new Data.Database.Engine(AppSession.DbConfigs);

				using (AppSession.AuthForm = new AuthForm())
				{
					AppSession.AuthForm.Shown += (s, e) =>
						SplashScreenManager.CloseForm(false);

					do
					{
						if (AppSession.AuthForm.ShowDialog() != DialogResult.Yes)
							Environment.Exit(0);

						AppSession.Container = new AppContainer($"LifeLog.UI.{AppSession.AuthForm.AplicationInterface.ToString()}");

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
				AppHelper.SaveAppSetings();
				AppSession.Container?.Dispose();
				AppSession.DataEngine?.Dispose();
			}
		}
	}
}
