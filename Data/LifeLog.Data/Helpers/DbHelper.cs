using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using LifeLog.Data.DBs;
using LifeLog.Data.DBs.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using LifeLog.Services.SqlData;
using System.Data;
using System.Reflection;

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
		using (SqlDataAccess dataAccess = new SqlDataAccess(connectionString))
		{
			return await dataAccess.LoadDataListAsync<string>("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')");
		}
	}

	/// <summary>
	/// Update database
	/// </summary>
	/// <param name="provider"></param>
	/// <param name="dictionary"></param>
	public static void UpdateDB(IDataStore provider, ReflectionDictionary dictionary)
	{
		using (SimpleDataLayer simpleLayer = new SimpleDataLayer(dictionary, provider))
		{
			using (UnitOfWork uow = new UnitOfWork(simpleLayer))
			{
				uow.UpdateSchema();
			}
		}
	}

	/// <summary>
	/// Genera te the store
	/// </summary>
	/// <param name="conn"></param>
	/// <param name="provider"></param>
	/// <param name="dictionary"></param>
	public static void GenerateStore(string conn, out IDataStore provider, out ReflectionDictionary dictionary)
	{
		IEnumerable<Type> assemblyTypes = Assembly.GetExecutingAssembly().GetTypes()
					 .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == "Data.XPO.ORMDataModelCode");

		Type[] persistentTypes = assemblyTypes
			.Where(t => !Attribute.IsDefined(t, typeof(NonPersistentAttribute), inherit: false))
			.ToArray();

		Type[] nonPersistentTypes = assemblyTypes
			 .Where(t => Attribute.IsDefined(t, typeof(NonPersistentAttribute), inherit: false))
			.ToArray();

		provider = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema);
		dictionary = new ReflectionDictionary();
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

		services.AddTransient<IUsersDB, UsersDB>();
		services.AddTransient<IGeralDB, GeralDB>();
		services.AddTransient<INotesDB, NotesDB>();
		services.AddTransient<ITasksDB, TasksDB>();
		services.AddTransient<ICommandsDB, CommandsDB>();
		services.AddTransient<IExternalProgramsDB, ExternalProgramsDB>();	 

		return services;
	}
}
