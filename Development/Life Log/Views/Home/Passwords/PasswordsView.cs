using Core.Enums;
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

        //PUBLIC

        public PasswordsEntity _CrtPassword;

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

        /// <summary>
        /// Go back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        /// <summary>
        /// Edit data click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// LoadData to views
        /// </summary>
        public void LoadData()
        {

        }


        #endregion

    }
}
