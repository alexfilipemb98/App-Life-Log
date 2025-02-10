using Core.Enums;
using Data.Bases;
using Data.Queries;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using Life_Log.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Data
{
    public class Engine : IDisposable
    {
        //PROPERTIES
        public bool IsConnected { get; private set; }
        public string DBName { get; private set; }
        public SqlDataAccessBase SQL { get; private set; }

        //PRIVATES 
        private readonly DatabaseConfigModel _config;
        private readonly IDbConnection _connection;
        private UnitOfWork _uow;
        private Lazy<object>[] _lazyObjects;
        private Type[] _persistentTypes;
        private Type[] _nonPersistentTypes;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_config"></param>
        public Engine(DatabaseConfigModel _config)
        {
            this._config = _config;

            string connectionString = GetConnection(_config);

            RegisterDataEntities();
            RegisterDataQueries();

            _connection = RegisterDataLayer(connectionString);
            _connection.Close();
        }

        #region QUERIES

        /// <summary>
        /// Notes data query
        /// </summary>
        public NotesQuery Notes => GetObject<NotesQuery>();

        /// <summary>
        /// External programs data query
        /// </summary>
        public ExternalProgramsQuery ExternalPrograms => GetObject<ExternalProgramsQuery>();

        /// <summary>
        /// Images data query
        /// </summary>
        public ImagesQuery Images => GetObject<ImagesQuery>();

        /// <summary>
        /// Commands data query
        /// </summary>
        public CommandsQuery Commands => GetObject<CommandsQuery>();
        
        /// <summary>
        /// Passwords data query
        /// </summary>
        public PasswordsQuery Passwords => GetObject<PasswordsQuery>();

        #endregion

        #region FUNCTIONS

        //PUBLIC

        /// <summary>
        /// Connect engine
        /// </summary>
        public bool Connect()
        {
            _uow = new UnitOfWork();
            _uow.UpdateSchema();

            if (_config.DatabaseType == DatabaseTypeEnum.SQLLITE)
            {
                SQL = new SqlDataAccessBase((SQLiteConnection)_connection);
                DBName = $"(local) {((SQLiteConnection)_connection).DataSource}";
            }
            else if (_config.DatabaseType == DatabaseTypeEnum.MSSQL)
            {
                SQL = new SqlDataAccessBase((SqlConnection)_connection);
                DBName = ((SqlConnection)_connection).Database;
            }

            IsConnected = _uow.IsConnected && SQL.isConnected();
            return IsConnected;
        }

        /// <summary>
        /// Disconnect data
        /// </summary>
        public void Disconnect()
        {
            _connection?.Close();
            _uow?.Disconnect();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Disconnect();
            _uow?.Dispose();
            SQL?.Dispose();
        }

        /// <summary>
        /// Create a backup of the SQLLite database
        /// </summary>
        public void SQLLiteBackUp()
        {
            if (_config.DatabaseType != DatabaseTypeEnum.SQLLITE)
                return;

            if (string.IsNullOrWhiteSpace(_config.SQlLitePath))
                return;

            string sqlLitePath = _config.SQlLitePath;
            string backupFolder = "Backups";

            if (!Directory.Exists(backupFolder))
                Directory.CreateDirectory(backupFolder);

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = Path.GetFileNameWithoutExtension(sqlLitePath);
            string extension = Path.GetExtension(sqlLitePath);
            string backupFile = Path.Combine(backupFolder, $"{fileName}_{timestamp}{extension}");

            File.Copy(sqlLitePath, backupFile, true);
        }

        //PRIVATE

        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        private string GetConnection(DatabaseConfigModel _config)
        {
            string connectionString = null;

            switch (_config.DatabaseType)
            {
                case DatabaseTypeEnum.SQLLITE:

                    if (string.IsNullOrWhiteSpace(_config.SQlLitePath))
                        throw new Exception("SQL lite path is null");

                    connectionString = $"XpoProvider=SQLite; Data Source={_config.SQlLitePath};";
                    break;

                case DatabaseTypeEnum.MSSQL:

                    SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder()
                    {
                        DataSource = _config.SqlAddress,
                        UserID = _config.SqlUsername,
                        Password = _config.SqlPassword,
                        InitialCatalog = _config.SqlDatabase,
                        PersistSecurityInfo = true,
                        TrustServerCertificate = true,
                        ConnectTimeout = 2,
                        ApplicationName = "LifeLog"
                    };

                    connectionString = $"XpoProvider=MSSqlServer;{conn}";
                    break;
            }

            return connectionString;
        }

        /// <summary>
        /// Register data queries
        /// </summary>
        private void RegisterDataQueries()
        {
            IEnumerable<Type> objectTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.Namespace != null
                        && t.Namespace.Equals("Data.Queries")
                        && t.Name.EndsWith("Query"));

            _lazyObjects = new Lazy<object>[objectTypes.Count()];

            int index = 0;
            foreach (Type objectType in objectTypes)
            {
                _lazyObjects[index] = new Lazy<object>(() =>
                    Activator.CreateInstance(objectType, new object[] { _uow, SQL }));
                index++;
            }
        }

        /// <summary>
        /// Register data entities
        /// </summary>
        private void RegisterDataEntities()
        {
            IEnumerable<Type> objectTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.Namespace != null
                && t.Namespace.Equals("Data.Entities")
                && !t.IsAbstract
            );

            _persistentTypes = objectTypes.Where(t => !t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();
            _nonPersistentTypes = objectTypes.Where(t => t.GetCustomAttributes(typeof(NonPersistentAttribute), false).Any()).ToArray();

        }

        /// <summary>
        /// Register datalayer
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        private IDbConnection RegisterDataLayer(string connectionString)
        {
            IDataStore provider = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.DatabaseAndSchema);
            ReflectionDictionary dictionary = new ReflectionDictionary();
            dictionary.GetDataStoreSchema(_persistentTypes);
            dictionary.CollectClassInfos(_nonPersistentTypes);
            XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            IDataStore connectionProvider = ((DevExpress.Xpo.Helpers.BaseDataLayer)XpoDefault.DataLayer).ConnectionProvider;
            return ((ConnectionProviderSql)connectionProvider).Connection;
        }

        /// <summary>
        /// Gets the desired object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T GetObject<T>()
        {
            foreach (Lazy<object> lazyObject in _lazyObjects)
            {
                if (!(lazyObject?.Value is T obj))
                    continue;

                return obj;
            }

            return default;
        }

        #endregion
    }
}
