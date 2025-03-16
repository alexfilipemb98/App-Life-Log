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

namespace Life_Log.Views.Tables.PasswordTypes
{
    /// <summary>
    /// Password types list view
    /// </summary>
    public partial class PasswordTypesListView : XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Construtor
        /// </summary>
        public PasswordTypesListView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Create new password type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        #region FUNCTIONS

        public void LoadData()
        {
            //throw new NotImplementedException();
        }

        #endregion

    
    }
}
