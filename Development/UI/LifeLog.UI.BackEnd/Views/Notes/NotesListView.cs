using DevExpress.Utils;
using DevExpress.XtraEditors;
using LifeLog.Data.Database.Entities;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				List<NotesEntity> data = await AppSession.DataEngine.Notes.GetAll();
				bsNotes.DataSource = data;
				AppHelper.StatusMessage($"Found {data.Count} notes!", Color.Green);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion
	}
}
