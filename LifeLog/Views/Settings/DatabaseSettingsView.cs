using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.DTOs;
using LifeLog.Data.Helpers;
using LifeLog.Helpers;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LifeLog.Views.Settings;

/// <summary>
/// Database settings View
/// </summary>
public partial class DatabaseSettingsView : XtraUserControl
{
	#region MAIN

	//PRIVATE
	private DatabaseConfigModel? _dbConfigs;

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
		ControlsHelper.ButtonTogglePassword((ButtonEdit)sender, e);

	/// <summary>
	/// Sql lite password button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void beSqlLitePassword_ButtonClick(object sender, ButtonPressedEventArgs e) =>
		ControlsHelper.ButtonTogglePassword((ButtonEdit)sender, e);

	/// <summary>
	/// Select the path for autobackup database 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void bePathSqlLiteBackup_ButtonClick(object sender, ButtonPressedEventArgs e)
	{
		string? path = DialogHelper.OpenFolder("Select the folder to save the automatic backups", bePathSqlLiteBackup.Text);
		bePathSqlLiteBackup.Text = path;
	}

	/// <summary>
	/// Save
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		try
		{
			if (!ValidateForm())
			{
				AppHelper.StatusMessage("Error saving settings", false);
				return;
			}

			AppHelper.SaveDataConfigs(_dbConfigs!);
			AppHelper.StatusMessage("Settings saved successfully", true);
		
			Program.DataEngine!.Dispose();
			Program.DataEngine = new Data.Engine(_dbConfigs!);

			if (_dbConfigs!.ApiEnabled)
			{
				if (Program.ApiEngine is not null)
				{
					await Program.ApiEngine.DisposeAsync();
				}

				Program.ApiEngine = new Services.Api.Engine();
				_ = Task.Run(() => Program.ApiEngine.StartAsync(Program.DataEngine.Connection, _dbConfigs.ApiUrl!));
			}
			else if (Program.ApiEngine != null)
				await Program.ApiEngine.DisposeAsync();

			Program.DbConfigs = _dbConfigs;
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
			string? tag = e.Button.Tag?.ToString();

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
			ErrorHelper.Handler(ex);
		}
	}

	/// <summary>
	/// Open the api link
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void beApiLink_ButtonClick(object sender, ButtonPressedEventArgs e)
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

		if (Program.DbConfigs == null)
			_dbConfigs = new DatabaseConfigModel();

		_dbConfigs = Program.DbConfigs.DeepCloneJson();

		cbDatabaseType.SelectedIndex = (int)_dbConfigs!.DatabaseType;

		//SQL
		beSqlAddress.Text = _dbConfigs.SqlAddress;
		teSqlUsername.Text = _dbConfigs.SqlUsername;
		beSqlPassword.Text = _dbConfigs.SqlPassword;
		cbSQLDatabase.Text = _dbConfigs.SqlDatabase;

		//SQL LITE
		bePathSqlLite.Text = _dbConfigs.SqlLitePath;
		beSqlLitePassword.Text = _dbConfigs.SqlLitePassword;
		bePathSqlLiteBackup.Text = _dbConfigs.SqlLiteAutoBackupPath;

		//API
		beApiLink.Text = _dbConfigs.ApiUrl;
		tsEnableApi.IsOn = _dbConfigs.ApiEnabled;
	}

	/// <summary>
	/// Load Data From Form
	/// </summary>
	/// <returns></returns>
	private void LoadFillObj(ref DatabaseConfigModel obj)
	{
		//DB TYPE
		obj.DatabaseType = (DatabaseTypeEnum)cbDatabaseType.SelectedIndex;
		//SQL
		obj.SqlAddress = beSqlAddress.Text;
		obj.SqlUsername = teSqlUsername.Text;
		obj.SqlPassword = beSqlPassword.Text;
		obj.SqlDatabase = cbSQLDatabase.Text;
		//SQL LITE
		obj.SqlLitePath = bePathSqlLite.Text;
		obj.SqlLitePassword = beSqlLitePassword.Text;
		obj.SqlLiteAutoBackupPath = bePathSqlLiteBackup.Text;
		//API
		obj.ApiUrl = beApiLink.Text;
		obj.ApiEnabled = tsEnableApi.IsOn;
	}

	/// <summary>
	/// Validate Form
	/// </summary>
	/// <returns></returns>
	private bool ValidateForm()
	{
		this.ValidateChildren();

		LoadFillObj(ref _dbConfigs!);

		return ControlsHelper.ValidateForm(
			_dbConfigs,
			dxErrorProvider,
			new Dictionary<string, Control>(StringComparer.Ordinal)
			{
				//DB TYPE
				[nameof(DatabaseConfigModel.DatabaseType)] = cbDatabaseType,
				//SQL
				[nameof(DatabaseConfigModel.SqlAddress)] = beSqlAddress,
				[nameof(DatabaseConfigModel.SqlUsername)] = teSqlUsername,
				[nameof(DatabaseConfigModel.SqlPassword)] = beSqlPassword,
				[nameof(DatabaseConfigModel.SqlDatabase)] = cbSQLDatabase,
				//SQL LITE
				[nameof(DatabaseConfigModel.SqlLitePath)] = bePathSqlLite,
				[nameof(DatabaseConfigModel.SqlLitePassword)] = beSqlLitePassword,
				//API
				[nameof(DatabaseConfigModel.ApiEnabled)] = tsEnableApi,
				[nameof(DatabaseConfigModel.ApiUrl)] = beApiLink,
			});
	}

	#endregion

}