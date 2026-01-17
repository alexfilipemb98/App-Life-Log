using Dapper;
using LifeLog.Services.SqlData.Models;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace LifeLog.Services.SqlData;

/// <summary>
/// Class principal de sql management
/// </summary>
public class SqlDataAccess : IDisposable
{
    #region MAIN

    private IDbConnection _connection;
    private IDbTransaction _transaction;

    /// <summary>
    /// Construtor principal string connection
    /// </summary>
    /// <param name="stringConn"></param>
    /// <param name="startConnection"></param>
    public SqlDataAccess(string stringConn, bool startConnection = true)
    {
        if (_connection == null || _connection.State != ConnectionState.Open)
        {
            _connection = new SqlConnection(stringConn);
            _connection.Open();
        }
    }

    /// <summary>
    /// Construtor principal IDbConnection
    /// </summary>
    /// <param name="dbConnection"></param>
    public SqlDataAccess(IDbConnection dbConnection)
    {

        if (dbConnection is null)
            return;

        _connection = dbConnection;

        if (_connection.State != ConnectionState.Open)
            _connection.Open();
    }

    #endregion

    #region ASYNC

    public async Task<T?> GetValueAsync<T>(string query) =>
        await _connection.QueryFirstOrDefaultAsync<T>(query, transaction: _transaction);

    public async Task<T?> GetValueAsync<T, U>(string query, U parameters) =>
        await _connection.QueryFirstOrDefaultAsync<T>(query, parameters);

    public async Task<List<T>> LoadDataListAsync<T>(string sql)
    {
        IEnumerable<T> results = await _connection.QueryAsync<T>(sql, transaction: _transaction, commandType: CommandType.Text);
        return results.ToList();
    }

    public async Task<List<T>> LoadDataListAsync<T, U>(string sql, U parameters)
    {
        IEnumerable<T> results = await _connection.QueryAsync<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);
        return results.ToList();
    }

    public async Task<int?> SaveDataAsync(string sql) => await _connection.ExecuteAsync(sql);

    public async Task<int?> SaveDataAsync<T>(string sql, T parameters) => await _connection.ExecuteAsync(sql, parameters);

    public async Task<T?> ExecuteScalarAsync<T, U>(string sql, U parameters) => await _connection.ExecuteScalarAsync<T>(sql, parameters);

    public async Task<T?> ExecuteScalarAsync<T>(string sql, T parameters) => await _connection.ExecuteScalarAsync<T>(sql, parameters);

    public async Task<T?> ExecuteScalarAsync<T>(string sql) => await _connection.ExecuteScalarAsync<T>(sql);

    public async Task ExecuteScalarAsync(string sql) => await _connection.ExecuteScalarAsync(sql);

    public async Task<SqlBatchResult> RunBatchAsync(string sql, bool returnsRows, CancellationToken ct, int? commandTimeout = null)
    {
        if (string.IsNullOrWhiteSpace(sql))
            return new SqlBatchResult { ReturnsRows = returnsRows };

        if (returnsRows)
        {
            var cmd = new CommandDefinition(
                commandText: sql,
                transaction: _transaction,
                commandTimeout: commandTimeout,
                cancellationToken: ct);

            using var reader = await _connection.ExecuteReaderAsync(cmd);

            var (cols, rows) = await ReadAllWithSchemaAsync(reader, ct);

            return new SqlBatchResult
            {
                ReturnsRows = true,
                Columns = cols,
                Rows = rows
            };
        }
        else
        {
            var cmd = new CommandDefinition(
                commandText: sql,
                transaction: _transaction,
                commandTimeout: commandTimeout,
                cancellationToken: ct);

            int affected = await _connection.ExecuteAsync(cmd);

            return new SqlBatchResult
            {
                ReturnsRows = false,
                AffectedRows = affected
            };
        }
    }

    #endregion

    #region QUERIES

    public IEnumerable<T> LoadData<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text);

    public IEnumerable<T> LoadData<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text);

    public List<T> LoadDataList<T, U>(string sql, U parameters) => _connection.Query<T>(sql, parameters, transaction: _transaction, commandType: CommandType.Text).ToList();

    public List<T> LoadDataList<T>(string sql) => _connection.Query<T>(sql, transaction: _transaction, commandType: CommandType.Text).ToList();

    public int SaveData<T>(string sql, ref T parameters, int? commandTimeout = null) => _connection.Execute(sql, parameters, commandTimeout: commandTimeout);

    public int SaveData(string sql, int? commandTimeout = null) => _connection.Execute(sql, commandTimeout: commandTimeout);

    public T? GetValue<T, U>(string query, U parameters) => _connection.QueryFirstOrDefault<T>(query, parameters);

    public T? GetValue<T>(string query) => _connection.QueryFirstOrDefault<T>(query, transaction: _transaction);

    public T? ExecuteScalar<T, U>(string sql, U parameters) => _connection.ExecuteScalar<T>(sql, parameters);

    public T? ExecuteScalar<T>(string sql, ref T parameters) => _connection.ExecuteScalar<T>(sql, parameters);

    public T? ExecuteScalar<T>(string sql) => _connection.ExecuteScalar<T>(sql);

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
       await _connection.ExecuteAsync(sql, parameters, transaction: _transaction);

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

    #region PRIVATE

    /// <summary>
    /// Read all with schema async
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    private static async Task<(List<string> Columns, List<Dictionary<string, object?>> Rows)> ReadAllWithSchemaAsync(IDataReader reader, CancellationToken ct)
    {
        using DbDataReader? dbReader = reader as DbDataReader;

        List<string> columns = GetColumnNames(dbReader, reader);
        List<Dictionary<string, object?>> rows = new List<Dictionary<string, object?>>();

        if (dbReader is null)
        {
            while (reader.Read())
            {
                var dict = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < reader.FieldCount; i++)
                    dict[columns[i]] = reader.IsDBNull(i) ? null : reader.GetValue(i);

                rows.Add(dict);
            }

            return (columns, rows);
        }

        while (await dbReader.ReadAsync(ct))
        {
            Dictionary<string, object?> dict = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < dbReader.FieldCount; i++)
                dict[columns[i]] = await dbReader.IsDBNullAsync(i, ct) ? null : dbReader.GetValue(i);

            rows.Add(dict);
        }

        return (columns, rows);
    }

    /// <summary>
    /// List of column names
    /// </summary>
    /// <param name="dbReader"></param>
    /// <param name="reader"></param>
    /// <returns></returns>
    private static List<string> GetColumnNames(DbDataReader? dbReader, IDataReader reader)
    {
        List<string> names = new List<string>();
        HashSet<string> used = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        int unnamed = 0;

        // Preferível: GetColumnSchema (quando existe)
        if (dbReader != null)
        {
            try
            {
                ReadOnlyCollection<DbColumn> schema = dbReader.GetColumnSchema();
                if (schema != null && schema.Count > 0)
                {
                    foreach (DbColumn c in schema)
                    {
                        string name = string.IsNullOrWhiteSpace(c.ColumnName) ? $"Column_{++unnamed}" : c.ColumnName!;
                        name = MakeUnique(name, used);
                        names.Add(name);
                    }
                    return names;
                }
            }
            catch { }
        }


        for (int i = 0; i < reader.FieldCount; i++)
        {
            string name = "";
            try { name = reader.GetName(i); } catch { }
            if (string.IsNullOrWhiteSpace(name)) name = $"Column_{++unnamed}";
            name = MakeUnique(name, used);
            names.Add(name);
        }

        return names;

        static string MakeUnique(string baseName, HashSet<string> used)
        {
            if (used.Add(baseName)) return baseName;
            int suf = 1;
            while (!used.Add($"{baseName}_{suf}")) suf++;
            return $"{baseName}_{suf}";
        }
    }

    #endregion

    #region PUBLIC

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

    #endregion
}
