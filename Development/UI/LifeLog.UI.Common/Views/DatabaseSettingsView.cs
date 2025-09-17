using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LifeLog.Data.Database.Helpers;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Utils;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using LifeLog.Base.Models;

namespace LifeLog.UI.Common.Views
{
	/// <summary>
	/// Database settings View
	/// </summary>
	public partial class DatabaseSettingsView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Construtor
		/// </summary>
		public DatabaseSettingsView() => InitializeComponent();

		#endregion

		#region EVENTS

		#region CLICK

		/// <summary>
		/// Password button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beSqlPassword_ButtonClick(object sender, ButtonPressedEventArgs e) =>
			ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);

		/// <summary>
		/// Sql lite password button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beSqlLitePassword_ButtonClick(object sender, ButtonPressedEventArgs e) =>
			ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);

		/// <summary>
		/// Select the path for autobackup database 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bePathSqlLiteBackup_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
				{
					folderBrowserDialog.Description = "Select a folder";
					folderBrowserDialog.ShowNewFolderButton = true;

					if (!string.IsNullOrWhiteSpace(bePathSqlLiteBackup.Text) && System.IO.Directory.Exists(bePathSqlLiteBackup.Text))
						folderBrowserDialog.SelectedPath = bePathSqlLiteBackup.Text;

					if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
						bePathSqlLiteBackup.Text = folderBrowserDialog.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Save
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (SaveData())
				{
					AppHelper.StatusMessage("Settings saved successfully", true);
					AppSession.DataEngine = new Data.Database.Engine(AppSession.DbConfigs);
				}
				else
					AppHelper.StatusMessage("Error saving settings", false);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// List the databases
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void cbSQLDatabase_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				string tag = e.Button.Tag?.ToString();

				if (string.IsNullOrWhiteSpace(tag))
					return;

				if (tag == "LISTDB")
				{
					cbSQLDatabase.Properties.Items.Clear();

					SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
					{
						InitialCatalog = "master",
						UserID = teSqlUsername.Text,
						Password = beSqlPassword.Text,
						DataSource = beSqlAddress.Text,
						TrustServerCertificate = true,
					};

					cbSQLDatabase.Properties.Items.AddRange(await DbHelper.GetDatabases(sqlConnectionStringBuilder.ToString()));
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Sql lite path chooser
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bePathSqlLite_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = "SQLite files (*.sqlite;*.db)|*.sqlite;*.db|All files (*.*)|*.*";
					openFileDialog.FilterIndex = 1;
					openFileDialog.RestoreDirectory = true;

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						string filePath = openFileDialog.FileName;
						bePathSqlLite.Text = filePath;
					}
				}
			}
			catch (Exception ex)
			{
				Helpers.ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Open the api link
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beApiLink_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				string apiLink = beApiLink.Text;

				if (!apiLink.IsValidUrl())
				{
					dxErrorProvider.SetError(beApiLink, "The URL is not valid");
					return;
				}
				else
					dxErrorProvider.SetError(beApiLink, string.Empty);

				if (!string.IsNullOrWhiteSpace(apiLink))
					System.Diagnostics.Process.Start(apiLink);
			}
			catch (Exception ex)
			{
				Helpers.ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region SELECTED INDEX CHANGED

		/// <summary>
		/// Selected index changed to changed from remote to sql
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((DatabaseTypeEnum)cbDatabaseType.SelectedIndex)
			{
				case DatabaseTypeEnum.SQLLITE:
					lcgRemoteSql.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					lcgSqlLite.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
					break;
				case DatabaseTypeEnum.MSSQL:
					lcgRemoteSql.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
					lcgSqlLite.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					break;
			}
		}

		#endregion

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load the data
		/// </summary>
		public void LoadData()
		{
			cbDatabaseType.Properties.Items.Clear();
			List<string> listaDbTypes = typeof(DatabaseTypeEnum).ToList()
					.Select(s => s.Value)
					.ToList();

			cbDatabaseType.Properties.Items.AddRange(listaDbTypes);

			DatabaseConfigModel configs = AppHelper.GetDatabaseConfigs();
			databaseConfigModelBindingSource.DataSource = configs;

			cbDatabaseType.SelectedIndex = (int)configs.DatabaseType;
		}

		/// <summary>
		/// Save the data
		/// </summary>
		/// <returns></returns>
		public bool SaveData()
		{
			this.ValidateChildren();
			databaseConfigModelBindingSource.EndEdit();
			DatabaseConfigModel configs = databaseConfigModelBindingSource.DataSource as DatabaseConfigModel;

			if (!ValidationHelper.ValidateModelAndSetError(configs, dxErrorProvider, dataLayoutControl))
				return false;

			FilesUtil.SaveFileWithEncryption(configs, AppSession.ConfigDbName);

			AppSession.DbConfigs = configs;

			return true;
		}

		#endregion

	}
}