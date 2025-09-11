using LifeLog.Data.Models;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.UI.BackEnd.Views.Notes
{
	public partial class NotesListView : DevExpress.XtraEditors.XtraUserControl
	{
		public NotesListView() => InitializeComponent();

		#region FUNCTIONS

		/// <summary>
		/// Load data from the database
		/// </summary>
		public async Task LoadData()
		{
			try
			{
				(List<NotesModel> data, string message) = await AppSession.DataEngine.Notes.GetAll();
				bsNotes.DataSource = data;
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
