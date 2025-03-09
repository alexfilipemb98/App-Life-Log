using Core.Enums;
using Core.Models;
using Core.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using Life_Log.Forms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static DevExpress.LookAndFeel.DXSkinColors;
using Data.Entities;
using DevExpress.XtraSplashScreen;
using Life_Log.Forms.Dialogs;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Life_Log.Helpers
{
    /// <summary>
    /// Application class
    /// </summary>
    public static class AppHelper
    {
        #region CONSTANTS

        public const string ConfigDbName = "ConfigDb.dat";
        public const string ConfigsAppName = "ConfigsApp.json";
        public const string SqlLiteName = "Database.db";

        #endregion

        #region PROPERTIES

        public static Data.Engine DataEngine { get; set; }
        public static LoginForm LoginFormInstance { get; set; }
        public static MainForm MainFormInstance { get; set; }
        public static AppConfigsModel AppConfigs { get; set; }
        public static DatabaseConfigModel DbConfigs { get; set; }
        public static Api.Engine ApiEngine { get; set; }
        public static UsersEntity CurrentUser { get; set; }

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
        /// Inicialize the data engines and the api
        /// </summary>
        public static void InicializeDataEngines()
        {
            if (DataEngine != null && DataEngine.IsConnected)
                DataEngine.Dispose();

            DbConfigs = GetDatabaseConfigs();
            DataEngine = new Data.Engine(DbConfigs);
            ApiEngine = new Api.Engine(DataEngine);
            DataEngine.SQLLiteBackUp();
            DataEngine.Connect();

            List<Assembly> assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => (new string[] { "Core", "Data", "Api", "Life Log" }).Contains(a.GetName().Name))
                .ToList();

            if (!AppHelper.DataEngine.ValidateVersions(assemblies))
            {
                SplashScreenManager.CloseForm(false);
                MessageBoxDialogForm.SD("App Outdated", "The application is outdated, please update it.");
                Environment.Exit(0);
                return;
            }

            AppHelper.DataEngine.UpdateSchema();
        }

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

            if (File.Exists(ConfigDbName))
            {
                config = FilesUtil.LoadFileWithEncryption<DatabaseConfigModel>(ConfigDbName);
            }
            else
            {
                config = new DatabaseConfigModel
                {
                    DatabaseType = DatabaseTypeEnum.SQLLITE,
                    SQlLitePath = SqlLiteName
                };

                FilesUtil.SaveFileWithEncryption(config, ConfigDbName);
            }

            return config;
        }

        /// <summary>
        /// Check if is already is running 
        /// </summary>
        public static void CheckForRunningInstance()
        {
#if !DEBUG
            Process currentProcess = Process.GetCurrentProcess();
            Process checkProcess = Process.GetProcessesByName(currentProcess.ProcessName).FirstOrDefault(p => p.Id != currentProcess.Id);

            if (checkProcess != null)
            {
                SplashScreenManager.CloseForm(false);
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
            XtraMessageBox.Show(message, "INFO", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            if (LoginFormInstance != null && !LoginFormInstance.Disposing && !LoginFormInstance.IsDisposed && MainFormInstance == null)
            {
                LoginFormInstance.Invoke(new Action(() =>
                {
                    LoginFormInstance.bsiStatusLabel.Caption = $"{DateTime.Now:HH:mm:ss} | {message}";
                    LoginFormInstance.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
            else if (MainFormInstance != null && !MainFormInstance.Disposing && !MainFormInstance.IsDisposed)
            {
                MainFormInstance.Invoke(new Action(() =>
                {
                    MainFormInstance.bsiStatusLabel.Caption = $"{DateTime.Now:HH:mm:ss} | {message}";
                    MainFormInstance.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
                }));
            }
        }

        /// <summary>
        /// Show message box and status message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="saved"></param>
        public static void StatusMessage(string message, bool saved)
        {
            StatusMessage(message, saved ? ForeColors.Information : ForeColors.Critical);
        }

        /// <summary>
        /// Load the application configurations
        /// </summary>
        public static void LoadAppConfigs()
        {
            string jsonFile = ConfigsAppName;
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
            string jsonFile = ConfigsAppName;
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

        /// <summary>
        /// Checks if is running with admin perms
        /// </summary>
        /// <returns></returns>
        public static bool IsRunningAsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        #endregion
    }
}
