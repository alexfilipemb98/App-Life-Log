using Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Life_Log.Helpers;
using Life_Log.Views.Tables.ExternalPrograms;
using Life_Log.Views.Tables.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log.Views.Home.Passwords
{
    /// <summary>
    /// Passwords View 
    /// </summary>
    public partial class PasswordsView : XtraUserControl
    {
        #region MAIN

        //PRIVATES

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public PasswordsView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// New item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDetailView();
        }

        /// <summary>
        /// Show list view click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiViewList_ItemClick(object sender, ItemClickEventArgs e)
        {
            navigationFrame.SelectedPage = npList;
            passwordsListView.LoadData();
        }

        /// <summary>
        /// Save 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            passwordsDetailView.SaveData();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// LoadData to views
        /// </summary>
        public void LoadData()
        {
            passwordsListView._PasswordsView = this;
            passwordsDetailView._PasswordsView = this;
            passwordsDetailView._PasswordsListView = passwordsListView;
        }

        /// <summary>
        /// Show detail view
        /// </summary>
        /// <param name="password"></param>
        public void ShowDetailView(PasswordsEntity password = null)
        {
            try
            {
                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                passwordsDetailView.LoadData();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }

        }

        /// <summary>
        /// Show list view
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void ShowListView()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
