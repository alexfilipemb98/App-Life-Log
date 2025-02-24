using Core.Enums;
using Core.Extensions;
using Core.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Life_Log.Views.Settings
{
    /// <summary>
    /// Database settings View
    /// </summary>
    public partial class DatabaseSettingsView : XtraUserControl
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public DatabaseSettingsView() => InitializeComponent();

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
    }
}
