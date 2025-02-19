using Core.Enums;
using Core.Models;
using Core.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using Life_Log.Forms;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Life_Log.Helpers
{
    /// <summary>
    /// Application class
    /// </summary>
    public static class AppHelper
    {
        #region PROPERTIES

        public static Data.Engine DataEngine { get; set; }
        public static LoginForm LoginFormInstance { get; set; }
        public static MainForm MainFormInstance { get; set; }
        public static AppConfigsModel AppConfigs { get; set; }
        public static DatabaseConfigModel DbConfigs { get; set; }

        #endregion

        #region EXTERM

        /// <summary>
        /// User32.dll to set the window to the front
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Check if windows has theme dark or light
        /// </summary>
        /// <returns></returns>
        public static ThemeEnum GetTheme()
        {
            if (AppConfigs != null && AppConfigs.Theme != ThemeEnum.SYSTEM)
                return AppConfigs.Theme;

            string key = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
            object value = Registry.GetValue(key, "AppsUseLightTheme", null);

            if (value != null && value is int)
                return (int)value == 0 ? ThemeEnum.DARK : ThemeEnum.LIGHT;

            return ThemeEnum.LIGHT;
        }

        /// <summary>
        /// Get the cofiguration file
        /// </summary>
        /// <returns></returns>
        public static DatabaseConfigModel GetDatabaseConfigs()
        {
            DatabaseConfigModel config;

            if (File.Exists(Properties.Settings.Default.ConfigFileName))
            {
                config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(Properties.Settings.Default.ConfigFileName);

                //TODO REMOVER DEPOIS DE TER AS CONFIGS CONFIGURAVEIS
                if (config.SQlLitePath != Properties.Settings.Default.SqlLitePath)
                {
                    config.SQlLitePath = Properties.Settings.Default.SqlLitePath;
                }
            }
            else
            {
                config = new DatabaseConfigModel
                {
                    DatabaseType = DatabaseTypeEnum.SQLLITE,
                    SQlLitePath = Properties.Settings.Default.SqlLitePath
                };

                FilesUtil.SaveFileWithEncryption(config, Properties.Settings.Default.ConfigFileName);
            }

            DbConfigs = config;

            return config;
        }

        /// <summary>
        /// Check if is already is running 
        /// </summary>
        public static void CheckForRunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process checkProcess = Process.GetProcessesByName(currentProcess.ProcessName).FirstOrDefault(p => p.Id != currentProcess.Id);
#if !DEBUG
            if (checkProcess != null)
            {
                DialogHelper.ShowNotificationDialog("Application", "This app is already open!");

                IntPtr hWnd = IntPtr.Zero;
                hWnd = checkProcess.MainWindowHandle;
                SetForegroundWindow(hWnd);
                Environment.Exit(0);
            }
#endif
        }

        /// <summary>
        /// Show message box and status message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public static void StatusMessage(string message, Color color)
        {
            if (LoginFormInstance != null && !LoginFormInstance.Disposing && !LoginFormInstance.IsDisposed)
            {
                LoginFormInstance.Invoke(new Action(() =>
                {
                    LoginFormInstance.bsiStatusLabel.Caption = $"{DateTime.Now:HH/mm/ss}|{message}";
                    LoginFormInstance.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
            else if (MainFormInstance != null && !MainFormInstance.Disposing && !MainFormInstance.IsDisposed)
            {
                MainFormInstance.Invoke(new Action(() =>
                {
                    MainFormInstance.bsiStatusLabel.Caption = $"{DateTime.Now:HH/mm/ss}|{message}";
                    MainFormInstance.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
        }

        /// <summary>
        /// Load the application configurations
        /// </summary>
        public static void LoadAppConfigs()
        {
            string jsonFile = Properties.Settings.Default.GeralSettings;
            if (!File.Exists(jsonFile))
            {
                AppConfigsModel config = new AppConfigsModel
                {
                    Theme = ThemeEnum.SYSTEM
                };

                File.Create(jsonFile).Close();

                FilesUtil.SaveToJsonFile(jsonFile, config);
            }

            AppConfigs = FilesUtil.ReadFromJsonFile<AppConfigsModel>(jsonFile);
        }

        /// <summary>
        /// Save the application configurations
        /// </summary>
        public static void SaveAppSetings()
        {
            string jsonFile = Properties.Settings.Default.GeralSettings;
            FilesUtil.SaveToJsonFile(jsonFile, AppConfigs);
        }

        /// <summary>
        /// Toggle password visibility  
        /// </summary>
        /// <param name="button"></param>
        /// <param name="e"></param>
        public static void ButtonTogglePassword(ButtonEdit button, ButtonPressedEventArgs e)
        {
            button.Properties.UseSystemPasswordChar = !button.Properties.UseSystemPasswordChar;
            e.Button.ImageOptions.SvgImage = button.Properties.UseSystemPasswordChar ? Properties.Resources.security_visibilityoff : Properties.Resources.security_visibility;
        }

        #endregion
    }
}
