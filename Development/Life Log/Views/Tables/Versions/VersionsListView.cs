using Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using Life_Log.Helpers;
using Life_Log.Views.Tables.ExternalPrograms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Tables.Versions
{
    /// <summary>
    /// Images List View
    /// </summary>
    public partial class VersionsListView : XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public VersionsListView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Reload click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e) => 
            LoadData();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data from the database
        /// </summary>
        public void LoadData()
        {
            try
            {
                List<VersionsEntity> data = AppHelper.DataEngine.Versions.GetAll().OrderByDescending(w => w.CreatedAt).ToList();
                versionsEntityBindingSource.DataSource = data;
                AppHelper.StatusMessage($"Found {data.Count} versions!", ForeColors.Information);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
