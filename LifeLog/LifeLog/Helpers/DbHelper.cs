using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using System.IO;

namespace LifeLog.Helpers;
internal static class DbHelper
{
	private const string CONF_DB_FILE = "DbConfig.dat";

	internal static DatabaseConfigModel GetDatabaseConfig()
	{
		DatabaseConfigModel? config;

		string file = Path.Combine(Program.UserDir!, CONF_DB_FILE);

		if (File.Exists(file))
		{
			config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(file);
		}
		else
		{
			config = new DatabaseConfigModel
			{
				DatabaseType = DatabaseTypeEnum.SQLLITE,
				SQlLitePath = "Database.db",
				SqlLitePassword = ":bg8o?7V2G4I",
			};

			FilesUtil.SaveFileWithEncryption(config, file);
		}

		return config!;
	}

	/// <summary>
	/// Save data configs
	/// </summary>
	/// <param name="config"></param>
	internal static void SaveDataConfigs(DatabaseConfigModel config)
	{
		string file = Path.Combine(Program.UserDir!, CONF_DB_FILE);

		FilesUtil.SaveFileWithEncryption(config, file);
	}
}
