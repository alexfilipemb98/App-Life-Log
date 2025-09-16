using DevExpress.XtraBars.Ribbon;
using Life_Log.Helpers;
using System;
using System.Drawing;

namespace Life_Log.Forms.Dialogs
{
    public partial class ShowQrCodeForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="main"></param>
        /// <param name="v"></param>
        public ShowQrCodeForm()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENT'S

        /// <summary>
        /// when the qr code is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowQrCode_Load(object sender, EventArgs e)
        {
            try
            {
                if (Owner != null)
                    Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                        Owner.Location.Y + Owner.Height / 2 - Height / 2);
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        #endregion
    }
}