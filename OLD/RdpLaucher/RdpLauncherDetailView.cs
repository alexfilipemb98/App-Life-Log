using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Life_Log.Helpers;
using Data.Entities;
using DevExpress.XtraDataLayout;
using Core.Extensions;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Tools.RdpLaucher
{
    public partial class RdpLauncherDetailView : DevExpress.XtraEditors.XtraUserControl
    {
        private RdpConnectionsEntity _crtRdpConnection;

        public RdpLauncherDetailView() => InitializeComponent();

        private void bePassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AppHelper.ButtonTogglePassword(bePassword, e);
        }

        #region FUNCTIONS

        /// <summary>
        /// Load data
        /// </summary>
        /// <param name="rdpConnection"></param>
        public void LoadData(RdpConnectionsEntity rdpConnection = null)
        {
            _crtRdpConnection = rdpConnection ?? new RdpConnectionsEntity();
            _crtRdpConnection.Password = _crtRdpConnection.Password.Decrypt();

            rdpConnectionsEntityBindingSource.DataSource = _crtRdpConnection;
        }

        /// <summary>
        /// Save data
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            _crtRdpConnection.Address = teAddress.Text;
            _crtRdpConnection.Name = teName.Text;
            _crtRdpConnection.Username = teUsername.Text;
            _crtRdpConnection.Password = bePassword.Text.Encrypt();

            if (!ValidationHelper.ValidateModelAndSetError(_crtRdpConnection, dxErrorProvider, dataLayoutControl))
                return false;

           bool  saved = AppHelper.DataEngine.RdpConnections.Save(_crtRdpConnection, out string message);
            if (!saved)
            {
                AppHelper.StatusMessage(message, ForeColors.Critical);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Reset form
        /// </summary>
        public void ResetForm()
        {
            rdpConnectionsEntityBindingSource.DataSource = new RdpConnectionsEntity();
            teName.ResetText();
            teAddress.ResetText();
            teUsername.ResetText();
            bePassword.ResetText();

            dataLayoutControl.ResetText();
        }

        #endregion
    }
}
