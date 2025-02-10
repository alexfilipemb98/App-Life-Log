using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace Life_Log.Views.Tables.Images
{
    /// <summary>
    /// Images List View
    /// </summary>
    public partial class ImagesListView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private Data.Entities.ImagesEntity _crtImage;
        private bool _createNew = false;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public ImagesListView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Reload click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

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
            Data.Entities.ImagesEntity model = GridHelper.GetObjectByRowHandle<Data.Entities.ImagesEntity>(gridView, gridView.FocusedRowHandle);
            if (model != null)
            {
                ShowDetailView(model);
            }
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
        /// Delete image event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

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
                if (imagesDetailView.Save())
                {
                    if (_createNew)
                    {
                        imagesBindingSource.Add(_crtImage);
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

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data from the database
        /// </summary>
        public void LoadData()
        {
            try
            {
                imagesBindingSource.DataSource = AppHelper.DataEngine.Images.GetAll();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Show detail view 
        /// </summary>
        /// <param name="imageDt"></param>
        private void ShowDetailView(Data.Entities.ImagesEntity imageDt = null)
        {
            try
            {
                if (imageDt == null)
                {
                    imageDt = new Data.Entities.ImagesEntity();
                    imageDt.Id = Guid.NewGuid();
                    imageDt.EditingMode = false;
                    _createNew = true;
                }

                _crtImage = imageDt;

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                imagesDetailView.LoadData(_crtImage);
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
                imagesDetailView.ResetForm();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
