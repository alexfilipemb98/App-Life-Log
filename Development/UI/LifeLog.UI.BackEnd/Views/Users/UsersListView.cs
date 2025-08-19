using DevExpress.XtraEditors;
using LifeLog.Base.Models.Data;
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
				bsUsers.DataSource = results;

				AppHelper.StatusMessage(message, results.Count > 0);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

	}
}
