using Dapper;
using DataService.Bases;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Infrastructure.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Helpers
{
	/// <summary>
	/// Database helper
	/// </summary>
	public static class DbHelper
	{
		/// <summary>
		/// List hte databases
		/// </summary>
		/// <param name="connectionString"></param>
		/// <returns></returns>
		public static async Task<List<string>> GetDatabases(string connectionString)
		{
			using (SqlDataAccess dataAccess = new SqlDataAccess(connectionString))
			{
				return await dataAccess.LoadDataListAsync<string>("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')");
			}
		}

		/// <summary>
		/// Gets the connection string
		/// </summary>
		/// <param name="config"></param>
		/// <returns></returns>
		public static string GetConnection(DatabaseConfigModel config, bool raw = false)
		{
			string connectionString = null;

			switch (config.DatabaseType)
			{
				case DatabaseTypeEnum.SQLLITE:

					if (string.IsNullOrWhiteSpace(config.SQlLitePath))
						throw new Exception("SQL lite path is null");

					SqliteConnectionStringBuilder connLite = new SqliteConnectionStringBuilder
					{
						DataSource = config.SQlLitePath,
						Mode = SqliteOpenMode.ReadWriteCreate,
						Password = config.SqlLitePassword,
					};

					connectionString = $"{(raw ? "" : "XpoProvider=SQLite;")} {connLite}";

					break;

				case DatabaseTypeEnum.MSSQL:

					SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder()
					{
						DataSource = config.SqlAddress,
						UserID = config.SqlUsername,
						Password = config.SqlPassword,
						InitialCatalog = "master",
						PersistSecurityInfo = true,
						TrustServerCertificate = true,
						ConnectTimeout = 2,
						ApplicationName = "LifeLog"
					};

					CheckDatabaseExists(conn, config.SqlDatabase);

					conn.InitialCatalog = config.SqlDatabase;

					connectionString = $"{(raw ? "" : "XpoProvider=MSSqlServer;")} {conn}";
					break;
			}

			return connectionString;
		}

		/// <summary>
		/// Create a backup of the SQLLite database
		/// </summary>
		public static void SqlLiteBackUp(DatabaseConfigModel config)
		{
			if (config.DatabaseType != DatabaseTypeEnum.SQLLITE)
				return;

			if (string.IsNullOrWhiteSpace(config.SQlLitePath))
				return;

			string sqlLitePath = config.SQlLitePath;

			if (!File.Exists(sqlLitePath))
				return;

			string backupFolder = "Backups";

			if (!Directory.Exists(backupFolder))
				Directory.CreateDirectory(backupFolder);

			string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
			string fileName = Path.GetFileNameWithoutExtension(sqlLitePath);
			string extension = Path.GetExtension(sqlLitePath);
			string backupFile = Path.Combine(backupFolder, $"{fileName}_{timestamp}{extension}");

			File.Copy(sqlLitePath, backupFile, true);
		}

		/// <summary>
		/// Check if the database exists
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="databaseName"></param>
		/// <returns></returns>
		public static void CheckDatabaseExists(SqlConnectionStringBuilder builder, string databaseName)
		{
			using (SqlDataAccess connection = new SqlDataAccess(builder.ConnectionString))
			{
				string query = "SELECT COUNT(*) FROM sys.databases WHERE name = @dbName";

				DynamicParameters parameters = new DynamicParameters();
				parameters.Add("@dbName", databaseName);

				int count = connection.GetValue<int, DynamicParameters>(query, parameters);

				if (count <= 0)
				{
					query = "CREATE DATABASE " + databaseName;
					bool created = connection.ExecuteScalar<int>(query) > 0;
					if (!created)
						throw new Exception("Database creation failed");
				}
			}
		}

	}
}
