using LifeLog.Data.DBs;
using LifeLog.Data.DBs.Interfaces;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Reflection;

namespace LifeLog.Data.Helpers;

/// <summary>
/// Database helper
/// </summary>
internal static class DbHelper
{
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
	public static ServiceProvider ConfigureServices(IDbConnection connection)
	{
		ServiceCollection services = new();

		services.AddSingleton(connection);

		services.AddScoped(sp => new UnitOfWork());

		services.AddTransient<IUsersDB, UsersDB>();
		services.AddTransient<IGeralDB, GeralDB>();
		services.AddTransient<INotesDB, NotesDB>();

		return services.BuildServiceProvider();
	}
}
