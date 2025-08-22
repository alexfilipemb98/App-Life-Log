using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.BackEnd.Views.Images
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
		private async void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
		{
			await LoadData();
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
			ImagesModel model = ControlsHelper.GetObjectByRowHandle<ImagesModel>(gridView, gridView.FocusedRowHandle);
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
		private async void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
		{
			//try
			//{
			//	ImagesEntity imageData = ControlsHelper.GetObjectByRowHandle<ImagesEntity>(gridView, gridView.FocusedRowHandle);

			//	if (imageData == null)
			//		return;

			//	DialogResult result = MessageBoxDialogForm.SD("Delete Image", $"Do you really want to delete {imageData.Name}?");

			//	if (result == DialogResult.Yes)
			//	{
			//		using (Images query = new Images())
			//		{
			//			(bool isDeleted, string message) = await query.Delete(imageData.Id);

			//			if (isDeleted)
			//				bsImages.Remove(imageData);

			//			AppHelper.StatusMessage(message, ForeColors.Critical);
			//		}
			//	}
			//}
			//catch (Exception ex)
			//{
			//	ErrorHelper.Handler(ex);
			//}
		}

		/// <summary>
		/// Save button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			//try
			//{
			//	(bool imagesaved, ImagesEntity image) = await imagesDetailView.Save();
			//	if (imagesaved)
			//	{
			//		if (_createNew)
			//		{
			//			imagesBindingSource.Add(image);
			//			_createNew = false;
			//		}
			//		else
			//			gridView.UpdateCurrentRow();

			//		ShowListView();
			//	}
			//}
			//catch (Exception ex)
			//{
			//	ErrorHelper.Handler(ex);
			//}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load data from the database
		/// </summary>
		public async Task LoadData()
		{
			try
			{
				(List<ImagesModel> data, string message) = await AppSession.DataEngine.Images.GetAll();
				bsImages.DataSource = data;
				AppHelper.StatusMessage(message, data.Count > 0);
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
		private void ShowDetailView(ImagesModel imageDt = null)
		{
			try
			{
				if (imageDt == null)
				{
					imageDt = new ImagesModel();
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
