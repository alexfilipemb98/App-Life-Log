using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using LifeLog.Base.DapperUtil;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using LifeLog.Data.Database.Helpers;
using LifeLog.Data.Database.Queries;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LifeLog.Data.Database
{
	/// <summary>
	/// Class engine to connect to the database 
	/// </summary>
	public class Engine : IDisposable
	{
		#region MAIN

		//PROPERTIES
		internal static Engine Instance { get; private set; }
		internal IDataLayer DataLayer { get; private set; }
		internal IDbConnection Connection { get; private set; }
		public string DBName { get; private set; } = "Disconected!";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param fName="config"></param>
		public Engine(DatabaseConfigModel config)
		{
			config.ValidateModel(out List<ValidationResult> results);
			if (results.Count > 0)
				throw new Base.Infrastructure.Exceptions.ValidationException(results);

			if (Instance != null)
				Instance.Dispose();

			Instance = this;

			string connectionString = DbHelper.GetConnection(config);

			if (string.IsNullOrWhiteSpace(connectionString))
				throw new ArgumentNullException("Connection string is inválid!");

			Batteries_V2.Init();

			DbHelper.SqlLiteBackUp(config);

			IEnumerable<Type> objectTypes = Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(t => t.Namespace != null
					&& t.Namespace.Equals("LifeLog.Data.Database.ORMDataModel")
					&& !t.IsAbstract
				);

			Type[] persistentTypes = objectTypes.Where(t => !t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();
			Type[] nonPersistentTypes = objectTypes.Where(t => t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();

			IDataStore provider = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.DatabaseAndSchema);
			ReflectionDictionary dictionary = new ReflectionDictionary();
			dictionary.GetDataStoreSchema(persistentTypes);
			dictionary.CollectClassInfos(nonPersistentTypes);

			DbHelper.UpdateDB(provider, dictionary);

			DataLayer = new ThreadSafeDataLayer(dictionary, provider);
			XpoDefault.DataLayer = DataLayer;
			IDataStore connectionProvider = ((DevExpress.Xpo.Helpers.BaseDataLayer)DataLayer).ConnectionProvider;
			Connection = ((ConnectionProviderSql)connectionProvider).Connection;

			DBName = config.DatabaseType == DatabaseTypeEnum.SQLLITE
				? $"(local) {Path.GetFileNameWithoutExtension(((SqliteConnection)Connection).DataSource)}"
				: ((SqlConnection)Connection).Database;
		}

		#endregion

		#region DATA BASE

		//SQL
		private SqlDataAccess _sql;
		public SqlDataAccess SQL
		{
			get
			{
				if (_sql == null)
					_sql = new SqlDataAccess(Connection);

				return _sql;
			}
		}
		
		//UOW
		private UnitOfWork _uow;
		public UnitOfWork UOW
		{
			get
			{
				if (_uow == null)
					_uow = new UnitOfWork(DataLayer);

				return _uow;
			}
		}

		#endregion

		#region QUERIES

		//Users
		private UsersQuery _users;
		public UsersQuery Users
		{
			get
			{
				if (_users == null)
					_users = new UsersQuery();

				return _users;
			}
		}

		//External Programs
		private ExternalProgramsQuery _externalPrograms;
		public ExternalProgramsQuery ExternalPrograms
		{
			get
			{
				if (_externalPrograms == null)
					_externalPrograms = new ExternalProgramsQuery();

				return _externalPrograms;
			}
		}

		//Notes
		private NotesQuery _notes;
		public NotesQuery Notes
		{
			get
			{
				if (_notes == null)
					_notes = new NotesQuery();

				return _notes;
			}
		}

		////Versions
		//private VersionsQuery _versions;
		//public VersionsQuery Versions
		//{
		//	get
		//	{
		//		if (_versions == null)
		//			_versions = new VersionsQuery();

		//		return _versions;
		//	}
		//}

		//Images
		private ImagesQuery _images;
		public ImagesQuery Images
		{
			get
			{
				if (_images == null)
					_images = new ImagesQuery();

				return _images;
			}
		}

		//Commands
		private CommandsQuery _commands;
		public CommandsQuery Commands
		{
			get
			{
				if (_commands == null)
					_commands = new CommandsQuery();

				return _commands;
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Dispose
		/// </summary>
		public void Dispose()
		{
			DataLayer?.Dispose();
			Connection?.Dispose();
		}

		#endregion
	}
}
