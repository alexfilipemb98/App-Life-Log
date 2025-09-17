using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.Common.Helpers
{
	/// <summary>
	/// Application class
	/// </summary>
	public static class AppHelper
	{
		//Database configs

		/// <summary>
		/// Get the cofiguration file
		/// </summary>
		/// <returns></returns>
		public static DatabaseConfigModel GetDatabaseConfigs()
		{
			DatabaseConfigModel config;

			if (File.Exists(AppSession.ConfigDbName))
			{
				config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(AppSession.ConfigDbName);
			}
			else
			{
				config = new DatabaseConfigModel
				{
					DatabaseType = DatabaseTypeEnum.SQLLITE,
					SQlLitePath = AppSession.SqlLiteName,
					SqlLitePassword = "sAt34@5432€"
				};

				FilesUtil.SaveFileWithEncryption(config, AppSession.ConfigDbName);
			}

			return config;
		}

		/// <summary>
		/// Save data configs
		/// </summary>
		/// <param name="config"></param>
		public static void SaveDataConfigs(DatabaseConfigModel config)
		{
			FilesUtil.SaveFileWithEncryption(config, AppSession.ConfigDbName);
		}

		//Status message

		/// <summary>
		/// Show message box and status message
		/// </summary>
		/// <param name="message"></param>
		/// <param name="color"></param>
		public static void StatusMessage(string message, Color color, bool showDialog = false)
		{
			string caption = $"{DateTime.Now:HH:mm:ss} | {message}";

			if (showDialog)
				XtraMessageBox.Show(caption, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if (AppSession.AuthForm != null && !AppSession.AuthForm.Disposing && !AppSession.AuthForm.IsDisposed && AppSession.AuthForm.Visible)
			{
				AppSession.AuthForm.Invoke(new Action(() =>
				{
					AppSession.AuthForm.bsiStatusLabel.Caption = caption;
					AppSession.AuthForm.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
				}));
			}
			else
				AppSession.Container.EngineForm.SetLabelStatus(caption, color);
		}

		/// <summary>
		/// Show message box and status message
		/// </summary>
		/// <param name="message"></param>
		/// <param name="saved"></param>
		public static void StatusMessage(string message, bool saved, bool showDialog = false) =>
			StatusMessage(message, saved ? ForeColors.Information : ForeColors.Critical, showDialog);

		//Application configs

		/// <summary>
		/// Load the application configurations
		/// </summary>
		public static AppConfigsModel LoadAppConfigs()
		{
			string jsonFile = AppSession.ConfigsAppName;
			if (!File.Exists(jsonFile))
			{
				AppConfigsModel config = new AppConfigsModel
				{
					Theme = ThemeEnum.SYSTEM,
				};

				File.Create(jsonFile).Close();

				FilesUtil.SaveToJsonFile(jsonFile, config);
			}

			return FilesUtil.ReadFromJsonFile<AppConfigsModel>(jsonFile);
		}

		/// <summary>
		/// Save the application configurations
		/// </summary>
		public static void SaveAppSetings(AppConfigsModel configs = null)
		{
			FilesUtil.SaveToJsonFile(AppSession.ConfigsAppName, configs ?? AppSession.AppConfigs);
		}

		//OTHERS

		/// <summary>
		/// User folder configuration 
		/// </summary>
		/// <returns></returns>
		public static string CreateUserFolder()
		{
			// get current user and sanitize
			string username = Environment.UserName;
			foreach (var c in Path.GetInvalidFileNameChars())
				username = username.Replace(c, '_');
			username = username.Replace(' ', '_');

			// build & ensure folder
			string path = Path.Combine("Configs", username);
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			return path;
		}

	}
}
