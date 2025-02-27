using Core.Enums;
using Core.Extensions;
using Core.Models;
using Core.Utils;
using Data.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Life_Log.Views.Settings
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
        private void beSqlPassword_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            AppHelper.ButtonTogglePassword(sender as ButtonEdit, e);
        }

        #endregion

        #region FUNCTIONS

        public void LoadData()
        {
            cbDatabaseType.Properties.Items.Clear();
            List<string> listaDbTypes = typeof(DatabaseTypeEnum).ToList().Select(w => w.Description).ToList();

            cbDatabaseType.Properties.Items.AddRange(listaDbTypes);

            var configs = AppHelper.GetDatabaseConfigs();
            databaseConfigModelBindingSource.DataSource = configs;

            cbDatabaseType.SelectedIndex = (int)configs.DatabaseType;
        }

        public bool SaveData()
        {
            DatabaseConfigModel configs = databaseConfigModelBindingSource.DataSource as DatabaseConfigModel;
            // AppHelper.SaveDatabaseConfigs(configs);

            configs.DatabaseType = (DatabaseTypeEnum)cbDatabaseType.SelectedIndex;
            
            //SQL LITE
            configs.SQlLitePath = bePathSqlLite.Text;

            //REMOTE SQL
            configs.SqlAddress = beSqlAddress.Text;
            configs.SqlUsername = teSqlUsername.Text;
            configs.SqlPassword = beSqlPassword.Text;

            configs.SqlDatabase = cbSQLDatabase.Text;

            FilesUtil.SaveFileWithEncryption(configs, Properties.Settings.Default.ConfigFileName);

            return true;
        }

        #endregion

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

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SaveData())
            {
                XtraMessageBox.Show("Settings saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error saving settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSQLDatabase_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var tag = e.Button.Tag?.ToString();

            if (string.IsNullOrWhiteSpace(tag))
                return;

            if ( tag == "LISTDB")
            {
                cbSQLDatabase.Properties.Items.Clear();
                
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
                sqlConnectionStringBuilder.InitialCatalog = "master";
                sqlConnectionStringBuilder.UserID = teSqlUsername.Text;
                sqlConnectionStringBuilder.Password = beSqlPassword.Text;
                sqlConnectionStringBuilder.DataSource = beSqlAddress.Text;

                cbSQLDatabase.Properties.Items.AddRange(DbHelper.GetDatabases(sqlConnectionStringBuilder.ToString()));
            }
        }
    }
}
