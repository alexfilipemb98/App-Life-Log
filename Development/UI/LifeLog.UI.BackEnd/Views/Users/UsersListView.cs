using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.UI.BackEnd.Views.Users
{
	public partial class UsersListView : DevExpress.XtraEditors.XtraUserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public UsersListView() => InitializeComponent();


		/// <summary>
		/// Load data from the database
		/// </summary>
		public async Task LoadData()
		{
			try
			{
				(List<UsersModel> results, string message) = await AppSession.DataEngine.Users.GetAll();
				usersModelBindingSource.DataSource = results;

				AppHelper.StatusMessage(message, results.Count > 0);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

	}
}
