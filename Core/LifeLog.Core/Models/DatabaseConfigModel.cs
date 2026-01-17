using LifeLog.Core.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Core.Models;

/// <summary>
/// Database config object model
/// </summary>
[Serializable]
public class DatabaseConfigModel
{
	#region PROPERTIES

	#region SQL LITE

	[EnumDataType(typeof(DatabaseTypeEnum))]
	public DatabaseTypeEnum DatabaseType { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
	public string? SqlLitePath { get; set; }

	public bool SqlLiteBackup { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(SqlLiteBackup), OperatorsEnum.Equal, true)]
	public string? SqlLiteAutoBackupPath { get; set; }

	[DataType(DataType.Password)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.SQLLITE)]
	public string? SqlLitePassword { get; set; }

	#endregion

	#region REMOTE SQL

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
	public string? SqlAddress { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
	public string? SqlUsername { get; set; }

	[DataType(DataType.Password)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
	public string? SqlPassword { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
	public string? SqlDatabase { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(DatabaseType), OperatorsEnum.Equal, DatabaseTypeEnum.MSSQL)]
	public string? SqlXpoProvider { get; set; }

    #endregion

    #region API

    public bool ApiEnabled { get; set; }

	[DataType(DataType.Text)]
	[Attributes.RequiredIf(nameof(ApiEnabled), OperatorsEnum.Equal, true)]
	public string? ApiUrl { get; set; }

	#endregion

	#endregion

	#region FUCNTIONS

	/// <summary>
	/// Returs the xpo provider
	/// 
	/// </summary>
	/// <returns></returns>
	public string XpoProvider()
	{
		if (DatabaseType == DatabaseTypeEnum.SQLLITE)
			return "SQLite";
		
		return SqlXpoProvider ?? "MSSqlServer";
	}

	#endregion

	#region OVERRIDES

	/// <summary>
	/// Return connection string
	/// </summary>
	/// <returns></returns>
	public override string? ToString()
	{
		switch (DatabaseType)
		{
			case DatabaseTypeEnum.SQLLITE:

				if (string.IsNullOrWhiteSpace(SqlLitePath))
					throw new Exception("SQL lite path is null");

				SqliteConnectionStringBuilder connLite = new SqliteConnectionStringBuilder
				{
					DataSource = SqlLitePath,
					Mode = SqliteOpenMode.ReadWriteCreate,
					Password = SqlLitePassword,
				};

				return connLite.ToString();	

			case DatabaseTypeEnum.MSSQL:

				SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder()
				{
					DataSource = SqlAddress,
					UserID = SqlUsername,
					Password = SqlPassword,
					InitialCatalog = SqlDatabase,
					PersistSecurityInfo = true,
					TrustServerCertificate = true,
					ConnectTimeout = 2,
					ApplicationName = "LifeLog"
				};

				return conn.ToString();
		}

		return base.ToString();
	}

	#endregion
}
