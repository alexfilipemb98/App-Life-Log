using Data;
using Data.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Life_Log_App.Helpers;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Utils;
using Utils.Extensions;

namespace Life_Log_App.Views.Settings
{
    /// <summary>
    /// Database settings View
    /// </summary>
    public partial class DatabaseSettingsView : XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Construtor
        /// </summary>
        public DatabaseSettingsView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Password button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beSqlPassword_ButtonClick(object sender, ButtonPressedEventArgs e) =>
            Helpers.ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);

        /// <summary>
        /// Sql lite password button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beSqlLitePassword_ButtonClick(object sender, ButtonPressedEventArgs e) =>
            Helpers.ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);

        /// <summary>
        /// Select the path for autobackup database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePathSqlLiteBackup_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a folder";
                    folderBrowserDialog.ShowNewFolderButton = true;

                    if (!string.IsNullOrWhiteSpace(bePathSqlLiteBackup.Text) && System.IO.Directory.Exists(bePathSqlLiteBackup.Text))
                        folderBrowserDialog.SelectedPath = bePathSqlLiteBackup.Text;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        bePathSqlLiteBackup.Text = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (SaveData())
                {
                    Helpers.AppHelper.StatusMessage("Settings saved successfully", true);
                    AppContext.DataEngine = new Engine(AppContext.DbConfigs);
                }
                else
                    Helpers.AppHelper.StatusMessage("Error saving settings", false);
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// List the databases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSQLDatabase_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                string tag = e.Button.Tag?.ToString();

                if (string.IsNullOrWhiteSpace(tag))
                    return;

                if (tag == "LISTDB")
                {
                    cbSQLDatabase.Properties.Items.Clear();

                    SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                    {
                        InitialCatalog = "master",
                        UserID = teSqlUsername.Text,
                        Password = beSqlPassword.Text,
                        DataSource = beSqlAddress.Text,
                        TrustServerCertificate = true,
                    };

                    cbSQLDatabase.Properties.Items.AddRange(DbHelper.GetDatabases(sqlConnectionStringBuilder.ToString()));
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Sql lite path chooser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePathSqlLite_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "SQLite files (*.sqlite;*.db)|*.sqlite;*.db|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        bePathSqlLite.Text = filePath;
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region SELECTED INDEX CHANGED

        /// <summary>
        /// Selected index changed to changed from remote to sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((DatabaseTypeEnum)cbDatabaseType.SelectedIndex)
            {
                case DatabaseTypeEnum.SQLLITE:
                    lcgRemoteSql.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcgSqlLite.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case DatabaseTypeEnum.MSSQL:
                    lcgRemoteSql.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcgSqlLite.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
            }
        }

        #endregion    

        #region FUNCTIONS

        /// <summary>
        /// Load the data
        /// </summary>
        public void LoadData()
        {
            cbDatabaseType.Properties.Items.Clear();
            List<string> listaDbTypes = typeof(DatabaseTypeEnum).ToList()
                    .Select(s => s.Value)
                    .ToList();

            cbDatabaseType.Properties.Items.AddRange(listaDbTypes);

            var configs = AppHelper.GetDatabaseConfigs();
            databaseConfigModelBindingSource.DataSource = configs;

            cbDatabaseType.SelectedIndex = (int)configs.DatabaseType;
        }

        /// <summary>
        /// Save the data
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            databaseConfigModelBindingSource.EndEdit();
            DatabaseConfigModel configs = databaseConfigModelBindingSource.DataSource as DatabaseConfigModel;

            if (!Helpers.ValidationHelper.ValidateModelAndSetError(configs, dxErrorProvider, dataLayoutControl))
                return false;

            //configs.DatabaseType = (DatabaseTypeEnum)cbDatabaseType.SelectedIndex;

            ////SQL LITE
            //configs.SQlLitePath = bePathSqlLite.Text;

            ////REMOTE SQL
            //configs.SqlAddress = beSqlAddress.Text;
            //configs.SqlUsername = teSqlUsername.Text;
            //configs.SqlPassword = beSqlPassword.Text;

            //configs.SqlDatabase = cbSQLDatabase.Text;

            FilesUtil.SaveFileWithEncryption(configs, AppContext.ConfigDbName);

            AppContext.DbConfigs = configs;

            return true;
        }

        #endregion

    }
}
