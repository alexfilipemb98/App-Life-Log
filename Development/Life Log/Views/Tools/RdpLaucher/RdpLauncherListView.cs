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
using Data.Entities;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Life_Log.Helpers;
using Life_Log.Forms.Dialogs;
using Core.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using Life_Log.Views.Tools.HostsEditor;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System.Data.SQLite;
using Life_Log.Properties;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;
using Life_Log.Views.Tables.ExternalPrograms;

namespace Life_Log.Views.Tools.RdpLaucher
{
    /// <summary>
    /// Rdp Laucher View
    /// </summary>
	public partial class RdpLauncherListView : XtraUserControl
    {
        //PRIVATE
        private RdpConnectionsEntity _crtExtProgram;
        private bool _createNew = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public RdpLauncherListView() => InitializeComponent();

        #region CLICK

        /// <summary>
        /// Add button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tileView.GetFocusedRow() is RdpConnectionsEntity rdpConnection)
                {
                    OpenRdpConnection(rdpConnection);
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// New button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ShowDetailView();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (rdpLauncherDetailView.SaveData())
                {
                    if (_createNew)
                    {
                        rdpConnectionsEntityBindingSource.Add(_crtExtProgram);
                        _createNew = false;
                    }
                    else
                        tileView.UpdateCurrentRow();

                    ShowListView();
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Edit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowListView();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data
        /// </summary>
        public void LoadData()
        {
            rdpConnectionsEntityBindingSource.DataSource = AppHelper.DataEngine.RdpConnections.GetAll();
        }

        /// <summary>
        /// Open RDP connection
        /// </summary>
        /// <param name="rdpConnection"></param>
        private void OpenRdpConnection(RdpConnectionsEntity rdpConnection)
        {
            string cmdKeyCommand = $"cmdkey /generic:TERMSRV/{rdpConnection.Address} /user:{rdpConnection.Username} /pass:{rdpConnection.Password.Decrypt()}";
            ExecuteCommand(cmdKeyCommand);

            // Start RDP session
            string rdpCommand = $"mstsc /v:{rdpConnection.Address}";
            ExecuteCommand(rdpCommand);
        }

        /// <summary>
        /// Execute cmd commands
        /// </summary>
        /// <param name="command"></param>
        private void ExecuteCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }

        /// <summary>
        /// Show detail view 
        /// </summary>
        /// <param name="rdpCon"></param>
        private void ShowDetailView(RdpConnectionsEntity rdpCon = null)
        {
            try
            {
                if (rdpCon == null)
                {
                    rdpCon = new RdpConnectionsEntity();
                    rdpCon.Id = Guid.NewGuid();
                    rdpCon.EditingMode = false;
                    rdpCon.CreatedAt = DateTime.Now;

                    _createNew = true;
                }

                _crtExtProgram = rdpCon;

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiReload.Visibility = BarItemVisibility.Never;
                bbiSearch.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                rdpLauncherDetailView.LoadData(rdpCon);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Show the list view
        /// </summary>
        private void ShowListView()
        {
            try
            {
                bbiNew.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Never;
                bbiReload.Visibility = BarItemVisibility.Always;
                bbiSearch.Visibility = BarItemVisibility.Always;

                navigationFrame.SelectedPage = npMain;
                rdpLauncherDetailView.ResetForm();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
