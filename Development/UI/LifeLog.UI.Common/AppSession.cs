using LifeLog.Base.Models;
using LifeLog.Data.Models;
using LifeLog.UI.Common.Forms.Auth;
using LifeLog.UI.Common.Helpers;
using System.IO;

namespace LifeLog.UI.Common
{
	/// <summary>
	/// App common session class.
	/// </summary>
	public static class AppSession
	{
		/// <summary>
		/// User folder configuration
		/// </summary>
		public static string UserFolder => AppHelper.CreateUserFolder();
		
		/// <summary>
		/// Gets the full file path of the configuration database file.
		/// </summary>
		public static string ConfigDbName => Path.Combine(UserFolder, "ConfigDb.dat");

		/// <summary>
		/// Configuration file for the application.
		/// </summary>
		public static string ConfigsAppName => Path.Combine(UserFolder, "ConfigsApp.json");

		/// <summary>
		/// Sqlite database file name.
		/// </summary>
		public static string SqlLiteName => Path.Combine(UserFolder, "Database.db");

		/// <summary>
		/// Application session container.
		/// </summary>
		public static AppContainer Container { get; set; }

		/// <summary>
		/// Data engine session.
		/// </summary>
		public static Data.Database.Engine  DataEngine { get; set; }

		/// <summary>
		/// Database configuration model.
		/// </summary>
		public static DatabaseConfigModel DbConfigs { get; set; }

		/// <summary>
		/// Application configuration model.
		/// </summary>
		public static AppConfigsModel AppConfigs { get; set; }

		/// <summary>
		/// User application configuration model.
		/// </summary>
		public static UserAppConfigsModel UserAppConfigs { get; set; }

		/// <summary>
		/// Authentication form instance.
		/// </summary>
		public static AuthForm AuthForm { get; set; }

		/// <summary>
		/// Api engine session.
		/// </summary>
		public static  Services.Api.Engine ApiEngine { get; set; }

		/// <summary>
		/// Logged user information.
		/// </summary>
		public static LoggedUserModel CurrentUser { get; internal set; }
	}
}
