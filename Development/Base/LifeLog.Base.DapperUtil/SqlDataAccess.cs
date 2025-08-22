using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace JDS.BASE.DapperUtil
{
    /// <summary>
    /// Class principal de sql management
    /// </summary>
    public class SqlDataAccess : IDisposable
    {
        #region MAIN

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public SqlDataAccess(string stringConn, bool startConnection = true)
        {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new SqlConnection(stringConn);
                _connection.Open();
            }
        }

        public SqlDataAccess(IDbConnection dbConnection)
        {
            if (_connection == null)
            {
                _connection = dbConnection;

                if (_connection.State != ConnectionState.Open)
                    _connection.Open();
            }
        }

        #endregion

        #region ASYNC

        public async Task<T> GetValueAsync<T>(string query) => 
            await _connection.QueryFirstOrDefaultAsync<T>(query, transaction: _transaction);
       
        public async Task<T> GetValueAsync<T, U>(string query, U parameters) => 
            await _connection.QueryFirstOrDefaultAsync<T>(query, parameters);

        public async Task<List<T>> LoadDataListAsync<T>(string sql)
        {
            IEnumerable<T> results = await _connection.QueryAsync<T>(sql, transaction: _transaction, commandType: CommandType.Text);
            return results.ToList();
        }

		public async Task<List<T>> LoadDataListAsync<T, U>(string sql, U parameters)
		{
            var results = await _connection.QueryAsync<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);
			return results.ToList();
		}

		public async Task<int> SaveDataAsync(string sql) => await _connection.ExecuteAsync(sql);

		public async Task<int> SaveDataAsync<T>(string sql, T parameters) => await _connection.ExecuteAsync(sql, parameters);

		public async Task<T> ExecuteScalarAsync<T, U>(string sql, U parameters) => await _connection.ExecuteScalarAsync<T>(sql, parameters);

		public async Task<T> ExecuteScalarAsync<T>(string sql, T parameters) => await _connection.ExecuteScalarAsync<T>(sql, parameters);

		public async Task<T> ExecuteScalarAsync<T>(string sql) => await _connection.ExecuteScalarAsync<T>(sql);

		public async Task ExecuteScalarAsync(string sql) => await _connection.ExecuteScalarAsync(sql);

		#endregion

		#region QUERIES

		public IEnumerable<T> LoadData<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);

        public IEnumerable<T> LoadData<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text);

        public List<T> LoadDataList<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text).ToList();

        public List<T> LoadDataList<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text).ToList();

        public int SaveData<T>(string sql, ref T parameters, int? commandTimeout = null) => _connection.Execute(sql, parameters, commandTimeout: commandTimeout);

        public int SaveData(string sql, int? commandTimeout = null) => _connection.Execute(sql, commandTimeout: commandTimeout);

        public T GetValue<T, U>(string query, U parameters) => _connection.QueryFirstOrDefault<T>(query, parameters);

        public T GetValue<T>(string query) => _connection.QueryFirstOrDefault<T>(query, transaction: _transaction);

        public T ExecuteScalar<T, U>(string sql, U parameters) => _connection.ExecuteScalar<T>(sql, parameters);

        public T ExecuteScalar<T>(string sql, ref T parameters) => _connection.ExecuteScalar<T>(sql, parameters);

        public T ExecuteScalar<T>(string sql) => _connection.ExecuteScalar<T>(sql);

        public void ExecuteScalar(string sql) => _connection.ExecuteScalar(sql);

        #endregion

        #region TRANSACTION

        public void StartTransaction()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            _transaction = _connection.BeginTransaction();
        }

        public void ExecuteInTransaction(string sql) =>
            _connection.Execute(sql, transaction: _transaction);

        public void SaveDataInTransaction<T>(string sql, ref T parameters) =>
            _connection.Execute(sql, parameters, transaction: _transaction);

        public async Task SaveDataInTransactionAsync<T>(string sql, T parameters) =>
           await  _connection.ExecuteAsync(sql, parameters, transaction: _transaction);

        public void SaveDataInTransaction(string sql) =>
            _connection.Execute(sql, transaction: _transaction);

        public async Task SaveDataInTransactionAsync(string sql) =>
            await _connection.ExecuteAsync(sql, transaction: _transaction);

        public void CommitTransaction()
        {
            _transaction.Commit();
        }

        public bool isInTransaction() =>
            _transaction?.Connection != null;

        public void RollbackTransaction()
        {
            _transaction.Rollback();
        }

        #endregion

        #region FUNCTION'S

        /// <summary>
        /// On dispose fechar a conexão com a base de dados!
        /// </summary>
        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
