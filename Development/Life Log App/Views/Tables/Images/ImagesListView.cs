using Components;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log_App.Views.Tables.Images
{
    /// <summary>
    /// Images list View
    /// </summary>
    public partial class ImagesListView : UserControlBase
    {
        #region MAIN

        /// <summary>
        /// Construtor
        /// </summary>
        public ImagesListView() => InitializeComponent();

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

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data
        /// </summary>
        public override void LoadData()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
