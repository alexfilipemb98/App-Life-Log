using Models;
using Models.Enums;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utils;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log_App.Helpers
{
    /// <summary>
    /// Application class
    /// </summary>
    internal static class AppHelper
    {
        //Database configs

        /// <summary>
        /// Get the cofiguration file
        /// </summary>
        /// <returns></returns>
        internal static DatabaseConfigModel GetDatabaseConfigs()
        {
            DatabaseConfigModel config;

            if (File.Exists(AppContext.ConfigDbName))
            {
                config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(AppContext.ConfigDbName);
            }
            else
            {
                config = new DatabaseConfigModel
                {
                    DatabaseType = DatabaseTypeEnum.SQLLITE,
                    SQlLitePath = AppContext.SqlLiteName
                };

                FilesUtil.SaveFileWithEncryption(config, AppContext.ConfigDbName);
            }

            return config;
        }

        /// <summary>
        /// Save data configs
        /// </summary>
        /// <param name="config"></param>
        internal static void SaveDataConfigs(DatabaseConfigModel config)
        {
            FilesUtil.SaveFileWithEncryption(config, AppContext.ConfigDbName);
        }

        //Status message

        /// <summary>
        /// Show message box and status message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        internal static void StatusMessage(string message, Color color)
        {
            string caption = $"{DateTime.Now:HH:mm:ss} | {message}";

            if (AppContext.AuthForm != null && !AppContext.AuthForm.Disposing && !AppContext.AuthForm.IsDisposed && AppContext.MainForm == null)
            {
                AppContext.AuthForm.Invoke(new Action(() =>
                {
                    AppContext.AuthForm.bsiStatusLabel.Caption = caption;
                    AppContext.AuthForm.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
            else if (AppContext.MainForm != null && !AppContext.MainForm.Disposing && !AppContext.MainForm.IsDisposed)
            {
                AppContext.MainForm.Invoke(new Action(() =>
                {
                    AppContext.MainForm.bsiStatusLabel.Caption = caption;
                    AppContext.MainForm.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
        }

        /// <summary>
        /// Show message box and status message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="saved"></param>
        internal static void StatusMessage(string message, bool saved)
        {
            StatusMessage(message, saved ? ForeColors.Information : ForeColors.Critical);
        }

        //Application configs

        /// <summary>
        /// Load the application configurations
        /// </summary>
        internal static AppConfigsModel LoadAppConfigs()
        {
            string jsonFile = AppContext.ConfigsAppName;
            if (!File.Exists(jsonFile))
            {
                AppConfigsModel config = new AppConfigsModel
                {
                    Theme = ThemeEnum.SYSTEM,
                    MainFormWidth = 1000,
                    MainFormHeight = 500,
                    MainFormWindowState = (int)FormWindowState.Normal,
                    InternalApiUrl = "http://localhost:9000"
                };

                File.Create(jsonFile).Close();

                FilesUtil.SaveToJsonFile(jsonFile, config);
            }

            return FilesUtil.ReadFromJsonFile<AppConfigsModel>(jsonFile);
        }

        /// <summary>
        /// Save the application configurations
        /// </summary>
        internal static void SaveAppSetings(AppConfigsModel configs = null)
        {
            FilesUtil.SaveToJsonFile(AppContext.ConfigsAppName, configs ?? AppContext.AppConfigs);
        }
    }
}
