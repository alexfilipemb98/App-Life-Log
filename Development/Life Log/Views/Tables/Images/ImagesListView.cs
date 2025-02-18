using Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
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
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Tables.Images
{
    /// <summary>
    /// Images List View
    /// </summary>
    public partial class ImagesListView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

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
            if (e.Button == MouseButtons.Right)
                popupMenu.ShowPopup(Control.MousePosition);
        }

        /// <summary>
        /// Edit program button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ImagesEntity model = GridHelper.GetObjectByRowHandle<ImagesEntity>(gridView, gridView.FocusedRowHandle);
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
                ImagesEntity imageData = GridHelper.GetObjectByRowHandle<ImagesEntity>(gridView, gridView.FocusedRowHandle);

                if (imageData == null)
                    return;

                DialogResult result = DialogHelper.ShowDeleteDialog("Delete Image", $"Do you really want to delete {imageData.Name}?");

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = AppHelper.DataEngine.Images.Delete(imageData.Id, out string message);

                    if (isDeleted)
                        imagesBindingSource.Remove(imageData);

                    AppHelper.StatusMessage(message, ForeColors.Critical);
                }
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
                if (imagesDetailView.Save(out ImagesEntity image))
                {
                    if (_createNew)
                    {
                        imagesBindingSource.Add(image);
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
                List<ImagesEntity> data = AppHelper.DataEngine.Images.GetAll();
                imagesBindingSource.DataSource = data;
                AppHelper.StatusMessage($"Found {data.Count} images!", Color.Green);
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
        private void ShowDetailView(ImagesEntity imageDt = null)
        {
            try
            {
                if (imageDt == null)
                {
                    imageDt = new ImagesEntity
                    {
                        Id = Guid.NewGuid(),
                        EditingMode = false
                    };
                    _createNew = true;
                }

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiReload.Visibility = BarItemVisibility.Never;
                bbiSearch.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                imagesDetailView.LoadData(imageDt);
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
