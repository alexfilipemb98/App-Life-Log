using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using LifeLog.Data.DTOs;
using LifeLog.Helpers;
using System.Data;

namespace LifeLog.Views.tasks
{
	/// <summary>
	/// Tasks View
	/// </summary>
	public partial class TasksView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public TasksView() => InitializeComponent();

		#endregion

		#region EVENTS

		#region CLICK

		/// <summary>
		/// Refresh button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				await LoadData();
			}
		}

		#endregion

		#region GV TASKS

		/// <summary>
		/// Init new row event for gvTasks
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gvTasks_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			TasksDTO? cmd = gvTasks.GetObjectByRowHandle<TasksDTO>(e.RowHandle);
			if (cmd != null)
			{
				cmd.IdUser = Program.LoggedUser!.Id;
			}
		}

		/// <summary>
		/// gvTasks Row Updated event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void gvTasks_RowUpdated(object sender, RowObjectEventArgs e)
		{
			UpdateProgressBar();

			if (e.Row is TasksDTO task && task != null)
			{
				task.IdUser = Program.LoggedUser!.Id;
				bool saved = await Program.DataEngine!.Tasks.Save(task);
			}
		}

		#endregion

		#endregion

		#region FUNCTIONS

		#region PUBLIC

		/// <summary>
		/// Load the data for the view
		/// </summary>
		public async Task LoadData()
		{
			List<TasksDTO?> tasksList = await Program.DataEngine!.Tasks.GetUserTasks(Program.LoggedUser!.Id);

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

			int completedTasks = tasksModelBindingSource.List.Cast<TasksDTO>().Where(w => w.IsDone).Count();

			int progress = (int)((completedTasks / (double)totalTasks) * 100);
			pbcTotal.Position = progress;

			lcTextsTasks.Text = $"<b>{completedTasks} of {totalTasks}</b> ({progress}%)";
		}

		#endregion

		#endregion

	}
}
