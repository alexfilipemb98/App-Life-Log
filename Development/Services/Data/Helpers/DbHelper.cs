using Core.Enums;
using Core.Models;
using Dapper;
using Data.Bases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
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
        public static List<string> GetDatabases(string connectionString)
        {
            using (DataSqlAccessBase dataAccess = new DataSqlAccessBase(connectionString))
            {
                return dataAccess.LoadDataList<string>("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')");
            }
        }

        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string? GetConnection(DatabaseConfigModel config, bool raw = false)
        {
            string? connectionString = null;

            switch (config.DatabaseType)
            {
                case DatabaseTypeEnum.SQLLITE:

                    if (string.IsNullOrWhiteSpace(config.SQlLitePath))
                        throw new Exception("SQL lite path is null");

                    connectionString = $"{(raw ? "" : "XpoProvider=SQLite;")} Data Source={config.SQlLitePath};";
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
        public static void SQLLiteBackUp(DatabaseConfigModel config)
        {
            if (config.DatabaseType != DatabaseTypeEnum.SQLLITE)
                return;

            if (string.IsNullOrWhiteSpace(config.SQlLitePath))
                return;

            string sqlLitePath = config.SQlLitePath;
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
            using DataSqlAccessBase connection = new(builder.ConnectionString);
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
