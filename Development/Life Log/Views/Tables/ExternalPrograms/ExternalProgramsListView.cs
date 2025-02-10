using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Life_Log.Helpers;
using System;
using System.Windows.Forms;

namespace Life_Log.Views.Tables.ExternalPrograms
{
    public partial class ExternalProgramsListView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Data.Entities.ExternalProgramsEntity _crtExtProgram;
        private bool _createNew = false;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public ExternalProgramsListView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// New button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowDetailView();
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
                if (externalProgramsDetailView.Save())
                {
                    if (_createNew)
                    {
                        externalProgramsBindingSource.Add(_crtExtProgram);
                        _createNew = false;
                    }
                    else
                        gridView.UpdateCurrentRow();

                    ShowListView();
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Reload button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Back button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowListView();
        }

        /// <summary>
        /// Row click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            popupMenu.ShowPopup(Control.MousePosition);
        }

        /// <summary>
        /// Edit program button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Data.Entities.ExternalProgramsEntity extProgram = GridHelper.GetObjectByRowHandle<Data.Entities.ExternalProgramsEntity>(gridView, gridView.FocusedRowHandle);
            if (extProgram != null)
            {
                ShowDetailView(extProgram);
            }
        }

        /// <summary>
        /// Delete program event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data from the database
        /// </summary>
        public void LoadData()
        {
            try
            {
                externalProgramsBindingSource.DataSource = AppHelper.DataEngine.ExternalPrograms.GetAll();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Show detail view 
        /// </summary>
        /// <param name="extProgram"></param>
        private void ShowDetailView(Data.Entities.ExternalProgramsEntity extProgram = null)
        {
            try
            {
                if (extProgram == null)
                {
                    extProgram = new Data.Entities.ExternalProgramsEntity();
                    extProgram.Id = Guid.NewGuid();
                    extProgram.EditingMode = false;

                    _createNew = true;
                }

                _crtExtProgram = extProgram;

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                externalProgramsDetailView.LoadData(extProgram);
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

                navigationFrame.SelectedPage = npMain;
                externalProgramsDetailView.ResetForm();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion
    }
}
