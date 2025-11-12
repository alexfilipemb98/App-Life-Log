using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using LifeLog.Data.Models;
using LifeLog.UI.BackEnd.Bases;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.UI.BackEnd.Views.Notes
{
	/// <summary>
	/// Notes view
	/// </summary>
	public partial class NotesListView : BaseView
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public NotesListView() => InitializeComponent();

		#endregion

		#region EVENTS

		#region CLICK



		/// <summary>
		/// Reload button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public override async void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (IOverlaySplashScreenHandle loader = SplashScreenManager.ShowOverlayForm(gridControl))
			{
				await LoadData();
			}
		}

		#endregion

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load data from the database
		/// </summary>
		public async Task LoadData()
		{
			try
			{
				(List<NotesModel> data, string message) = await AppSession.DataEngine.Notes.GetAll();
				notesModelBindingSource.DataSource = data;
				AppHelper.StatusMessage(message, data.Count > 0);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion
	}
}
