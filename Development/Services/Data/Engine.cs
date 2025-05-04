using Utils.Extensions;
using Data.Bases;
using Data.Helpers;
using Data.Queries;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using Models;
using Models.Enums;

namespace Data
{
    public class Engine : IDisposable
    {
        #region MAIN

        //PROPERTIES
        public bool IsConnected { get => UOW != null && SQL != null && UOW.IsConnected && SQL.IsConnected; }
        public string DBName { get; private set; }
        public UnitOfWork UOW { get; private set; }
        public DataSqlAccessBase SQL { get; private set; }
        public IDbConnection Connection { get; private set; }
        public IDataLayer DataLayer { get; private set; }

        //PRIVATE
        private Dictionary<Type, object> _queriesCache = new Dictionary<Type, object>();
        private readonly DatabaseConfigModel _config;
        private static Engine _instance;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config"></param>
        public Engine(DatabaseConfigModel config)
        {
            config.IsValid(out List<ValidationResult> results);
            if (results.Count > 0)
                throw new Exceptions.ValidationException(results);

            _config = config;

            if (_instance != null)
                _instance.Dispose();

            _instance = this;

            Initialize();
            UpdateSchema();
        }

        #endregion

        /// <summary>
        /// Notes query
        /// </summary>
        public NotesQuery Notes => CreateQuery<NotesQuery>();

        /// <summary>
        /// Versions query
        /// </summary>
        public VersionsQuery Versions => CreateQuery<VersionsQuery>();

        /// <summary>
        /// Users query
        /// </summary>
        public UsersQuery Users => CreateQuery<UsersQuery>();

        /// <summary>
        /// Module settings query
        /// </summary>
        public ModuleSettingsQuery ModuleSettings => CreateQuery<ModuleSettingsQuery>();

        #region FUNCTIONS

        //PUBLIC

        /// <summary>
        /// Inicialize engine
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public void Initialize()
        {
            string connectionString = DbHelper.GetConnection(_config);

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string is inválid!");

            IEnumerable<Type> objectTypes = Assembly.GetExecutingAssembly()
               .GetTypes()
               .Where(t => t.Namespace != null
                   && t.Namespace.Equals("Data.ORM.DataModelCode")
                   && !t.IsAbstract
               );

            Type[] persistentTypes = objectTypes.Where(t => !t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();
            Type[] nonPersistentTypes = objectTypes.Where(t => t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();

            ReflectionDictionary dictionary = new ReflectionDictionary();
            dictionary.GetDataStoreSchema(persistentTypes);
            dictionary.CollectClassInfos(nonPersistentTypes);
            IDataStore provider = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.DatabaseAndSchema);
            DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            IDataStore connectionProvider = ((DevExpress.Xpo.Helpers.BaseDataLayer)DataLayer).ConnectionProvider;
            XpoDefault.DataLayer = DataLayer;
            Connection = ((ConnectionProviderSql)connectionProvider).Connection;

            UOW = new UnitOfWork(DataLayer);

            XpoDefault.Session = UOW;

            switch (_config.DatabaseType)
            {
                case DatabaseTypeEnum.SQLLITE:
                    SQL = new DataSqlAccessBase((SqliteConnection)Connection);
                    break;

                case DatabaseTypeEnum.MSSQL:
                    SQL = new DataSqlAccessBase((SqlConnection)Connection);
                    break;

                default:
                    throw new NotSupportedException("Database type not supported");
            }

            DBName = _config.DatabaseType == DatabaseTypeEnum.SQLLITE
                ? $"(local) {Path.GetFileNameWithoutExtension(((SqliteConnection)Connection).DataSource)}"
                : ((SqlConnection)Connection).Database;

            Assembly assembly = Assembly.GetExecutingAssembly();
            Guid guidAttr = assembly.ManifestModule.ModuleVersionId;

            if (Versions.ValidateVersion(guidAttr, assembly.GetName().Name, assembly.GetName()?.Version?.ToString() ?? "0.0.0.0"))
                UpdateSchema();
            else
                throw new NotSupportedException("The dll is outdated, please check for updates");
        }

        /// <summary>
        /// Update Schena
        /// </summary>
        public void UpdateSchema()
        {
            if (IsConnected)
                UOW.UpdateSchema();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Connection?.Close();
            UOW?.Disconnect();
            UOW?.Dispose();
            SQL?.Dispose();
        }

        //PRIVATE

        /// <summary>
        /// Creates a new instance for the class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T CreateQuery<T>() where T : class
        {
            if (!IsConnected)
                Initialize();

            if (!_queriesCache.TryGetValue(typeof(T), out object existingQuery))
            {
                ConstructorInfo constructor = typeof(T).GetConstructor(new[] { typeof(UnitOfWork), typeof(DataSqlAccessBase) });

                if (constructor == null)
                    throw new InvalidOperationException($"The type {typeof(T).Name} must have a constructor with parameters (UnitOfWork, DataSqlAccessBase).");

                T query = constructor.Invoke(new object[] { UOW, SQL }) as T;

                if (query == null)
                    throw new InvalidOperationException($"Failed to create an instance of {typeof(T).Name}.");

                _queriesCache[typeof(T)] = query;
                return query;
            }

            return (T)existingQuery;
        }

        #endregion
    }
}
