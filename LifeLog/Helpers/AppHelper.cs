using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using System.IO;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Helpers;

/// <summary>
/// App helper
/// </summary>
internal class AppHelper
{
	private const string CONF_FILE = "Configs.json";
	private const string CONF_DB_FILE = "DbConfig.dat";
	private const string DB_FILE = "Database.db";
	private const string DB_FILE_PASSWORD = ":bg8o?7V2G4I";

	#region CONFIGS
	
	#region APP

	/// <summary>
	/// Read app configs
	/// </summary>
	/// <returns></returns>
	internal static AppConfigsModel? ReadAppConfigs()
	{
		AppConfigsModel? config = null;

		string file = Path.Combine(Program.UserDir!, CONF_FILE);

		if (File.Exists(file))
		{
			config = FilesUtil.ReadFromJsonFile<AppConfigsModel>(file);
		}
		else
		{
			config = new AppConfigsModel()
			{
				Theme = Core.Enums.ThemeEnum.SYSTEM
			};
		}

		FilesUtil.SaveToJsonFile(file, config);

		return config;
	}

	/// <summary>
	/// Save app configs
	/// </summary>
	/// <param name="config"></param>
	internal static void SaveAppConfigs(AppConfigsModel config)
	{
		string file = Path.Combine(Program.UserDir!, CONF_FILE);

		FilesUtil.SaveToJsonFile(file, config);
	}

	#endregion

	#region DB

	/// <summary>
	/// Get database configs
	/// </summary>
	/// <returns></returns>
	internal static DatabaseConfigModel GetDatabaseConfig()
	{
		DatabaseConfigModel? config;

		string dir = "Database";

		if (!Directory.Exists(dir))
			Directory.CreateDirectory(dir);

		string dbPath = Path.Combine(dir, DB_FILE);
		string dbConfPath = Path.Combine(dir, CONF_DB_FILE);

		if (File.Exists(dbConfPath))
		{
			config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(dbConfPath);
		}
		else
		{
			config = new DatabaseConfigModel
			{
				DatabaseType = DatabaseTypeEnum.SQLLITE,
				SqlLitePath = dbPath,
				SqlLitePassword = DB_FILE_PASSWORD,
			};

			FilesUtil.SaveFileWithEncryption(config, dbConfPath);
		}

		return config!;
	}

	/// <summary>
	/// Save data configs
	/// </summary>
	/// <param name="config"></param>
	internal static void SaveDataConfigs(DatabaseConfigModel config)
	{
		string dir = "Database";

		if (!Directory.Exists(dir))
			Directory.CreateDirectory(dir);

		string dbConfPath = Path.Combine(dir, CONF_DB_FILE);

		FilesUtil.SaveFileWithEncryption(config, dbConfPath);
	}

	#endregion

	#endregion

	/// <summary>
	/// Show message box and status message
	/// </summary>
	/// <param name="message"></param>
	/// <param name="color"></param>
	internal static void StatusMessage(string message, Color color)
	{
		string caption = $"{DateTime.Now:HH:mm:ss} | {message}";

		bool logged = Program.LoggedUser is not null;
		BarStaticItem labelControll = logged ? Program.MainForm!.bsiStatusLabel : Program.AuthForm!.bsiStatusLabel;

		labelControll.Caption = caption;
		labelControll.ItemAppearance.Normal.ForeColor = color;
	}

    /// <summary>
    /// Show message box and status message
    /// </summary>
    /// <param name="message"></param>
    /// <param name="saved"></param>
    internal static void StatusMessage(string message, bool? saved = null)
    {
		var color = ForeColors.ControlText;
		if (saved.HasValue)
			color = saved.Value ? ForeColors.Information : ForeColors.Critical;

		StatusMessage(message, color);
    }

	/// <summary>
	/// Generate a fake form
	/// </summary>
	/// <returns></returns>
	internal static Form GenFakeForm()
	{
		Form owner = new Form();
		owner.StartPosition = FormStartPosition.Manual;
		owner.Location = new Point(0, 0);
		owner.Size = new Size(1, 1);
		owner.ShowInTaskbar = false;
		owner.Opacity = 0;
		owner.Show();
		return owner;
	}
}
