using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using System.IO;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Helpers;

internal class AppHelper
{
	private const string CONF_FILE = "Configs.json";

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
}
