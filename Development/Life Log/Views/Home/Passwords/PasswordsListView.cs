using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Fields.Expression;
using Life_Log.Helpers;
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
    /// Passwords List View
    /// </summary>
    public partial class PasswordsListView : DevExpress.XtraEditors.XtraUserControl
    {
        #region MAIN

        //PUBLIC

        public PasswordsView _PasswordsView;

        //PRIVATE

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public PasswordsListView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Row click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _PasswordsView.popupMenu.ShowPopup(MousePosition);
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data to the view
        /// </summary>
        public void LoadData()
        {
            try
            {
                passwordsEntityBindingSource.DataSource = AppHelper.DataEngine.Passwords.GetAll();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion
    }
}
