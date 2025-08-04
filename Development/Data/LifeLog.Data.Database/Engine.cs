using DataService.Bases;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Infrastructure.Models;
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
		public static Engine Instance { get; private set; }
		internal IDataLayer DataLayer { get; private set; }
		public IDbConnection Connection { get; private set; }
		public string DBName { get; private set; } = "Disconected!";
		public DatabaseConfigModel Config { get; private set; }
		public  UnitOfWork UOW { get; private set; }
		public SqlDataAccess SQL { get; private set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="config"></param>
		public Engine(DatabaseConfigModel config)
		{
			config.ValidateModel(out List<ValidationResult> results);
			if (results.Count > 0)
				throw new LifeLog.Base.Infrastructure.Exceptions.ValidationException(results);

			if (Instance != null)
				Instance.Dispose();

			Instance = this;
			Config = config;

			string connectionString = DbHelper.GetConnection(config);

			if (string.IsNullOrWhiteSpace(connectionString))
				throw new ArgumentNullException("Connection string is inválid!");

			Batteries_V2.Init();

			DbHelper.SqlLiteBackUp(config);

			IEnumerable<Type> objectTypes = Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(t => t.Namespace != null
					&& t.Namespace.Equals("LifeLog.Data.Database.Entities")
					&& !t.IsAbstract
					|| t.Name.Equals("DataEntityBase")
				);

			Type[] persistentTypes = objectTypes.Where(t => !t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();
			Type[] nonPersistentTypes = objectTypes.Where(t => t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();

			IDataStore provider = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.DatabaseAndSchema);
			ReflectionDictionary dictionary = new ReflectionDictionary();
			dictionary.GetDataStoreSchema(persistentTypes);
			dictionary.CollectClassInfos(nonPersistentTypes);

			using (SimpleDataLayer simpleLayer = new SimpleDataLayer(dictionary, provider))
			{
				Assembly assembly = Assembly.GetExecutingAssembly();
				Guid guidAttr = assembly.ManifestModule.ModuleVersionId;

				using (VersionsQuery query = new VersionsQuery(simpleLayer, null))
				{
					bool isValid = query.ValidateVersion(guidAttr, assembly.GetName().Name, assembly.GetName()?.Version?.ToString() ?? "0.0.0.0");
					if (!isValid)
						throw new NotSupportedException("The dll is outdated, please check for updates");
				}

				using (UnitOfWork uow = new UnitOfWork(simpleLayer))
				{
					uow.UpdateSchema();
				}
			}

			DataLayer = new ThreadSafeDataLayer(dictionary, provider);
			XpoDefault.DataLayer = DataLayer;
			IDataStore connectionProvider = ((DevExpress.Xpo.Helpers.BaseDataLayer)XpoDefault.DataLayer).ConnectionProvider;
			Connection = ((ConnectionProviderSql)connectionProvider).Connection;

			UOW = new UnitOfWork(DataLayer);
			SQL = new SqlDataAccess(Connection);

			XpoDefault.Session = UOW;

			DBName = config.DatabaseType == DatabaseTypeEnum.SQLLITE
				? $"(local) {Path.GetFileNameWithoutExtension(((SqliteConnection)Connection).DataSource)}"
				: ((SqlConnection)Connection).Database;
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
					_users = new UsersQuery(UOW, SQL);

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
					_externalPrograms = new ExternalProgramsQuery(UOW, SQL);

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
					_notes = new NotesQuery(UOW, SQL);

				return _notes;
			}
		}

		//Versions
		private VersionsQuery _versions;
		public VersionsQuery Versions
		{
			get
			{
				if (_versions == null)
					_versions = new VersionsQuery(UOW, SQL);

				return _versions;
			}
		}

		//Images
		private ImagesQuery _images;
		public ImagesQuery Images
		{
			get
			{
				if (_images == null)
					_images = new ImagesQuery(UOW, SQL);

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
					_commands = new CommandsQuery(UOW, SQL);

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
			UOW?.Dispose();
			SQL?.Dispose();
			DataLayer?.Dispose();
			Connection?.Dispose();
		}

		#endregion
	}
}
