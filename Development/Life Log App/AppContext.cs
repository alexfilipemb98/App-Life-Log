using Data.ORM.DataModelCode;
using Life_Log_App.Forms;
using Models;
using System;
using System.IO;

namespace Life_Log_App
{
    /// <summary>
    /// Aplication context
    /// </summary>
    internal static class AppContext
    {
        #region PROPERTIES

        private static string _userFolder;

        internal static string UserFolder
        {
            get
            {
                if (!string.IsNullOrEmpty(_userFolder))
                    return _userFolder;

                string username = Environment.UserName;

                foreach (var c in Path.GetInvalidFileNameChars())
                    username = username.Replace(c, '_');

                username = username.Replace(' ', '_');

                string path = Path.Combine("Configs", username);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                _userFolder = path;

                return path;
            }
        }
        internal static string ConfigDbName => Path.Combine(UserFolder, "ConfigDb.dat");
        internal static string ConfigsAppName => Path.Combine(UserFolder, "ConfigsApp.json");
        internal static string SqlLiteName => Path.Combine(UserFolder, "Database.db");
        internal static DatabaseConfigModel DbConfigs { get; set; }
        internal static MainForm MainForm { get; set; }
        internal static Forms.Auth.AuthForm AuthForm { get; set; }
        internal static Data.Engine DataEngine { get; set; }
        internal static Api.Engine ApiEngine { get; set; }
        internal static ORM_Users CurrentUser { get; set; }
        internal static AppConfigsModel AppConfigs { get; set; }
        internal static ORM_ModuleSettings ModuleSettings { get; set; }

        #endregion
    }
}
