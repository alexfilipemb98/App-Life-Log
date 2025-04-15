using Core.Enums;
using Core.Models;
using Core.Utils;
using DevExpress.XtraEditors;
using Microsoft.Identity.Client;
using System;
using System.Drawing;
using System.IO;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLogApp.Helpers
{
    /// <summary>
    /// Application class
    /// </summary>
    internal static class AppHelper
    {
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

        /// <summary>
        /// Show message box and status message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        internal static void StatusMessage(string message, Color color)
        {
            if (AppContext.LoginForm != null && !AppContext.LoginForm.Disposing && !AppContext.LoginForm.IsDisposed && AppContext.MainForm == null)
            {
                AppContext.LoginForm.Invoke(new Action(() =>
                {
                    AppContext.LoginForm.bsiStatusLabel.Caption = $"{DateTime.Now:HH:mm:ss} | {message}";
                    AppContext.LoginForm.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                    AppContext.LoginForm.ribbonStatusBar.Refresh();
                }));
            }
            else if (AppContext.MainForm != null && !AppContext.MainForm.Disposing && !AppContext.MainForm.IsDisposed)
            {
                AppContext.MainForm.Invoke(new Action(() =>
                {
                    AppContext.MainForm.bsiStatusLabel.Caption = $"{DateTime.Now:HH:mm:ss} | {message}";
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

        /// <summary>
        /// Load the application configurations
        /// </summary>
        internal static AppConfigsModel LoadAppConfigs()
        {
            string jsonFile =  AppContext.ConfigsAppName;
            if (!File.Exists(jsonFile))
            {
                AppConfigsModel config = new AppConfigsModel
                {
                    Theme = ThemeEnum.SYSTEM
                };

                File.Create(jsonFile).Close();

                FilesUtil.SaveToJsonFile(jsonFile, config);
            }

            return FilesUtil.ReadFromJsonFile<AppConfigsModel>(jsonFile);
        }

        /// <summary>
        /// Save the application configurations
        /// </summary>
        internal static void SaveAppSetings()
        {
            FilesUtil.SaveToJsonFile(AppContext.ConfigsAppName, AppContext.AppConfigs);
        }
    }
}
