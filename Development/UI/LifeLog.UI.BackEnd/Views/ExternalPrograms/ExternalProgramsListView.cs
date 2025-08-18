using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Database.Queries;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using LifeLog.Base.Models.Data;

namespace LifeLog.UI.BackEnd.Views.ExternalPrograms
{
	public partial class ExternalProgramsListView : XtraUserControl
	{
		#region MAIN

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
		private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				(bool saved, ExternalProgramsModel entity) = await externalProgramsDetailView.SaveData();
				if (saved)
				{
					List<ExternalProgramsModel> lista = bsExternalPrograms.DataSource as List<ExternalProgramsModel>;

					if (!lista.Any(w => w.Id == entity.Id))
					{
						lista.Add(entity);
						gridView.RefreshData();
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
		private async void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
		{
			await LoadData();
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
			ExternalProgramsModel extProgram = ControlsHelper.GetObjectByRowHandle<ExternalProgramsModel>(gridView, gridView.FocusedRowHandle);
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
		public async Task LoadData()
		{
			try
			{
				List<ExternalProgramsModel> results = await AppSession.DataEngine.ExternalPrograms.GetAll();
				bsExternalPrograms.DataSource = results;
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
		private void ShowDetailView(ExternalProgramsModel extProgram = null)
		{
			try
			{
				if (extProgram == null)
				{
					extProgram = new ExternalProgramsModel();
				}

				bbiNew.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Always;
				bbiBack.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Never;
				bbiReload.Visibility = BarItemVisibility.Never;
				bbiSearch.Visibility = BarItemVisibility.Never;

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
				bbiReload.Visibility = BarItemVisibility.Always;
				bbiSearch.Visibility = BarItemVisibility.Always;

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
