using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using System.IO;

namespace LifeLog.Helpers;

internal class AppHelper
{
	private const string CONF_FILE = "Configs.json";

	/// <summary>
	/// Read app configs
	/// </summary>
	/// <returns></returns>
	public static AppConfigsModel? ReadAppConfigs()
	{
		AppConfigsModel? config = null;
		string path = Path.Combine(Environment.MachineName, Environment.UserName);

		if (!Directory.Exists(path))
			Directory.CreateDirectory(path);

		string file = Path.Combine(path, CONF_FILE);

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
	public static void SaveAppConfigs(AppConfigsModel config)
	{
		string path = Path.Combine(Environment.MachineName, Environment.UserName);

		if (!Directory.Exists(path))
			Directory.CreateDirectory(path);

		string file = Path.Combine(path, CONF_FILE);


		FilesUtil.SaveToJsonFile(file, config);
	}
}
