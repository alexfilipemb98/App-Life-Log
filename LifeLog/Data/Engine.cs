using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.Helpers;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;
using System.Data;

namespace LifeLog.Data;

/// <summary>
/// Data engine
/// </summary>
public class Engine
{
	#region MAIN

	//PUBLIC VARIABLES

	private static Engine? Instance;
	private readonly IServiceProvider ServiceProvider;
	public string DBName { get; private set; }

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="configs"></param>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	public Engine(DatabaseConfigModel configs)
	{
		if (configs == null)
			throw new ArgumentNullException("Configs for data base are null");

		if (!configs.IsValid())
			throw new ArgumentException("Configurations are not valid");

		string? conn = configs.ToString();

		if (string.IsNullOrWhiteSpace(conn))
			throw new ArgumentNullException("Connection string is empty!");

		conn = $"XpoProvider={configs.XpoProvider()};{conn}";

		Batteries_V2.Init();

		DbHelper.GenerateStore(conn, out IDataStore provider, out ReflectionDictionary dictionary);

		DbHelper.UpdateDB(provider, dictionary);

		IDbConnection Connection = DbHelper.ConnectDb(provider, dictionary);

		DBName = configs.DatabaseType == DatabaseTypeEnum.SQLLITE
			? $"(local) {Path.GetFileNameWithoutExtension(((SqliteConnection)Connection).DataSource)}"
			: ((SqlConnection)Connection).Database;

		ServiceProvider = DbHelper.ConfigureServices(Connection);

		Instance = this;
	}

	#endregion

	#region CONTEXT

	//Users
	public IUsersDB Users => ServiceProvider.GetRequiredService<IUsersDB>();

	//Geral
	public IGeralDB Geral => ServiceProvider.GetRequiredService<IGeralDB>();
	
	//Notes
	public INotesDB Notes => ServiceProvider.GetRequiredService<INotesDB>();

	#endregion
}
