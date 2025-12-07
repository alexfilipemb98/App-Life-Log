using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraSplashScreen;
using LifeLog.Data.Models;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.UI.FrontEnd.Views.Main.Tasks
{
	public partial class TasksView : XtraUserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public TasksView() => InitializeComponent();

		/// <summary>
		/// gvTasks Row Updated event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void gvTasks_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
		{
			UpdateProgressBar();

			if (e.Row is TasksModel task && task != null)
			{
				task.User = AppSession.CurrentUser;
				(bool saved, string message)  = await AppSession.DataEngine.Tasks.Save(task);
			}
		}

		#region FUNCTIONS

		#region PUBLIC

		/// <summary>
		/// Load the data for the view
		/// </summary>
		public async Task LoadData()
		{
			(List<TasksModel> tasksList, string message) = await AppSession.DataEngine.Tasks.GetUserTasks(AppSession.CurrentUser.Id);


			AppHelper.StatusMessage(message, tasksList.Count > 0);

			tasksModelBindingSource.DataSource = tasksList;

			UpdateProgressBar();

		}

		#endregion

		#region PRIVATE

		/// <summary>
		/// Updates the progress bar based on completed tasks
		/// </summary>
		private void UpdateProgressBar()
		{
			int totalTasks = tasksModelBindingSource.Count;
			if (totalTasks == 0)
			{
				pbcTotal.Position = 0;
				return;
			}

			int completedTasks = tasksModelBindingSource.List.Cast<TasksModel>().Where(w => w.IsDone).Count();

			int progress = (int)((completedTasks / (double)totalTasks) * 100);
			pbcTotal.Position = progress;

			lcTextsTasks.Text = $"<b>{completedTasks} of {totalTasks}</b> ({progress}%)";
		}

		#endregion

		#endregion

		private async void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				await LoadData();
			}
		}

		private void gvTasks_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			TasksModel cmd = gvTasks.GetObjectByRowHandle<TasksModel>(e.RowHandle);
			if (cmd !=  null)
			{
				cmd.User = AppSession.CurrentUser;
			}
		}
	}
}
