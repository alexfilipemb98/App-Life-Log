using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using LifeLog.Data.Interfaces;
using LifeLog.Data.Repositories;
using LifeLog.Data.Xpo.ModelCode;
using LifeLog.Services.SqlData;
using Microsoft.Extensions.DependencyInjection;

namespace LifeLog.Data.Helpers;

/// <summary>
/// Database helper
/// </summary>
public static class DbHelper
{
	/// <summary>
	/// List hte databases
	/// </summary>
	/// <param fName="connectionString"></param>
	/// <returns></returns>
	public static async Task<List<string>> GetDatabases(string connectionString)
	{
		using SqlDataAccess dataAccess = new(connectionString);
		return await dataAccess.LoadDataListAsync<string>("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')");
	}

	/// <summary>
	/// Update database
	/// </summary>
	/// <param name="provider"></param>
	/// <param name="dictionary"></param>
	public static void UpdateDB(IDataStore provider, ReflectionDictionary dictionary)
	{
		using SimpleDataLayer simpleLayer = new(dictionary, provider);
		using UnitOfWork uow = new(simpleLayer);
		uow.UpdateSchema();
	}

	/// <summary>
	/// Genera te the store
	/// </summary>
	/// <param name="conn"></param>
	/// <param name="provider"></param>
	/// <param name="dictionary"></param>
	public static void GenerateStore(string conn, out IDataStore provider, out ReflectionDictionary dictionary)
	{
		Type[] persistentTypes = [
			typeof(CommandXpo),
			typeof(ExternalProgramXpo),
			typeof(NoteXpo),
			typeof(TodoXpo),
			typeof(UserXpo)
		];

		Type[] nonPersistentTypes = [

		];

		provider = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema);
		dictionary = new();
		dictionary.GetDataStoreSchema(persistentTypes);
		dictionary.CollectClassInfos(nonPersistentTypes);
	}

	/// <summary>
	/// Connect database
	/// </summary>
	/// <param name="provider"></param>
	/// <param name="dictionary"></param>
	/// <returns></returns>
	public static IDbConnection ConnectDb(IDataStore provider, ReflectionDictionary dictionary)
	{
		IDataLayer dataLayer = new ThreadSafeDataLayer(dictionary, provider);
		XpoDefault.DataLayer = dataLayer;
		IDataStore connectionProvider = ((DevExpress.Xpo.Helpers.BaseDataLayer)dataLayer).ConnectionProvider;
		IDbConnection Connection = ((ConnectionProviderSql)connectionProvider).Connection;
		return Connection;
	}

	/// <summary>
	/// Configure
	/// </summary>
	/// <param name="services"></param>
	public static IServiceCollection ConfigureServices(this IServiceCollection services, IDbConnection connection)
	{
		services.AddSingleton(connection);

		services.AddScoped(sp => new UnitOfWork());
		services.AddScoped(sp => new SqlDataAccess(connection));

		services.AddTransient<IUserRepository, UserRepository>();
		services.AddTransient<IDataRepository, DataRepository>();
		services.AddTransient<INoteRepository, NoteRepository>();
		services.AddTransient<ITodoRepository, TodoRepository>();
		services.AddTransient<ICommandRepository, CommandRepository>();
		services.AddTransient<IExternalProgramRepository, ExternalProgramRepository>();

		return services;
	}
}
