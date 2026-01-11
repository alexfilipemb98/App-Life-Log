using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using System.IO;

namespace LifeLog.Helpers;

/// <summary>
/// Db helper
/// </summary>
internal static class DbHelper
{
    private const string CONF_DB_FILE = "DbConfig.dat";
    private const string DB_FILE = "Database.db";
    private const string DB_FILE_PASSWORD = ":bg8o?7V2G4I";

    internal static DatabaseConfigModel GetDatabaseConfig()
    {
        DatabaseConfigModel? config;

        if (File.Exists(CONF_DB_FILE))
        {
            config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(CONF_DB_FILE);
        }
        else
        {
            config = new DatabaseConfigModel
            {
                DatabaseType = DatabaseTypeEnum.SQLLITE,
                SQlLitePath = DB_FILE,
                SqlLitePassword = DB_FILE_PASSWORD,
            };

            FilesUtil.SaveFileWithEncryption(config, CONF_DB_FILE);
        }

        return config!;
    }

    /// <summary>
    /// Save data configs
    /// </summary>
    /// <param name="config"></param>
    internal static void SaveDataConfigs(DatabaseConfigModel config)
    {
        FilesUtil.SaveFileWithEncryption(config, CONF_DB_FILE);
    }
}
