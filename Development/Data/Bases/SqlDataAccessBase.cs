using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Bases
{
    /// <summary>
    /// Class principal de sql management
    /// </summary>
    public class SqlDataAccessBase : IDisposable
    {
        #region MAIN

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="stringConn"></param>
        public SqlDataAccessBase(IDbConnection connection)
        {
            if (connection is null)
                throw new Exception("Connection type not supported");

            _connection = connection;
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="stringConn"></param>
        /// <param name="isSqlLite"></param>
        public SqlDataAccessBase(string stringConn, bool isSqlLite = false)
        {
            if (isSqlLite)
                _connection = new System.Data.SQLite.SQLiteConnection(stringConn);
            else
                _connection = new System.Data.SqlClient.SqlConnection(stringConn);

            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        #endregion

        #region QUERIES

        public IEnumerable<T> LoadData<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);

        public IEnumerable<T> LoadData<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text);

        public List<T> LoadDataList<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text).ToList();

        public List<T> LoadDataList<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text).ToList();

        public int SaveData<T>(string sql, ref T parameters, int? commandTimeout = null) => _connection.Execute(sql, parameters, commandTimeout: commandTimeout);

        public int SaveData(string sql, int? commandTimeout = null) => _connection.Execute(sql, commandTimeout: commandTimeout);

        public void SaveData<T, U>(string sql, ref T parameters, out U outputValue) => outputValue = _connection.ExecuteScalar<U>(sql, parameters);

        public T GetValue<T, U>(string query, U parameters) => _connection.QueryFirstOrDefault<T>(query, parameters);

        public T GetValue<T>(string query) => _connection.QueryFirstOrDefault<T>(query, transaction: _transaction);

        public T ExecuteScalar<T, U>(string sql, U parameters) => _connection.ExecuteScalar<T>(sql, parameters);

        public T ExecuteScalar<T>(string sql) => _connection.ExecuteScalar<T>(sql);

        public void ExecuteScalar(string sql) => _connection.ExecuteScalar(sql);

        #endregion

        #region TRANSACTION

        public void StartTransaction() => _transaction = _connection.BeginTransaction();

        public void ExecuteInTransaction(string sql) => _connection.Execute(sql, transaction: _transaction);

        public void SaveDataInTransaction<T>(string sql, ref T parameters) => _connection.Execute(sql, parameters, transaction: _transaction);

        public void SaveDataInTransaction(string sql) => _connection.Execute(sql, transaction: _transaction);

        public void CommitTransaction() => _transaction.Commit();

        public bool isInTransaction() => _transaction?.Connection != null;

        public void RollbackTransaction() => _transaction.Rollback();

        #endregion

        #region FUNCTION'S

        /// <summary>
        /// Returns the connection state
        /// </summary>
        /// <returns></returns>
        public bool isConnected() => _connection.State == ConnectionState.Open;

        /// <summary>
        /// On dispose fechar a conexão com a base de dados!
        /// </summary>
        public void Dispose()
        {
            try
            {
                if (_transaction != null)
                {
                    if (_transaction.Connection != null)
                        _transaction.Rollback();

                    _transaction.Dispose();
                }

                if (_connection != null)
                {
                    _connection?.Close();
                    _connection?.Dispose();
                }
            }
            catch (Exception)
            {
            }

            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
