using Components;
using Data.ORM.DataModelCode;
using DevExpress.XtraBars;
using Life_Log_App.Helpers;
using System;
using Utils.Extensions;

namespace Life_Log_App.Views.Tables.ExternalPrograms
{
	/// <summary>
	/// External Programs List View
	/// </summary>
	public partial class ExternalProgramsListView : UserControlBase<ORM_ExternalPrograms>
	{
		#region MAIN

		//PRIVATE
		private bool _IsNew = false;

		/// <summary>
		/// External Programs List View
		/// </summary>
		public ExternalProgramsListView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// New Item Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ShowEditor();
		}

		/// <summary>
		/// Back Item Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ShowList();
		}

		/// <summary>
		/// Save Item Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				if (navigationFrame.SelectedPage != npDetail) return;

				bool saved = externalProgramsDetailView.SaveData(out ORM_ExternalPrograms model);

				if (!saved) return;

				ShowList();

				if (_IsNew)
					xpcExternalPrograms.Add(model);
				else
					gvExternalPrograms.UpdateCurrentRow();

				_IsNew = false;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Show Editor
		/// </summary>
		private void ShowEditor(ORM_ExternalPrograms model = null)
		{
			try
			{
				_IsNew = model == null;
				bbiBack.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Always;

				externalProgramsDetailView.SetData(model);

				navigationFrame.SelectedPage = npDetail;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Show List
		/// </summary>
		public void ShowList()
		{
			bbiBack.Visibility = BarItemVisibility.Never;
			bbiEdit.Visibility = BarItemVisibility.Always;
			bbiSave.Visibility = BarItemVisibility.Never;

			navigationFrame.SelectedPage = npList;
		}

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
