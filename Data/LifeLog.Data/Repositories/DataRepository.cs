using LifeLog.Data.Interfaces;
using LifeLog.Services.SqlData;
using LifeLog.Services.SqlData.Models;

namespace LifeLog.Data.Repositories;

/// <summary>
/// Geral data
/// </summary>
public class DataRepository : IDataRepository
{
    #region MAIN

    //PRIVATE
    private readonly SqlDataAccess _sql;

    /// <summary>
    /// Contructor
    /// </summary>
    /// <param name="connection"></param>
    public DataRepository(SqlDataAccess sql)
    {
        _sql = sql;
    }

    #endregion

    #region SQL

    /// <summary>
    /// Load sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <returns></returns>
    public async Task<List<T>> LoadSql<T>(string sql)
    {
        return await _sql.LoadDataListAsync<T>(sql);
    }

    /// <summary>
    /// Execute sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <returns></returns>
    public async Task<T?> ExecuteSql<T>(string sql)
    {
        return await _sql.ExecuteScalarAsync<T>(sql);
    }

    /// <summary>
    /// Run batch
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="returnsRows"></param>
    /// <param name="ct"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public Task<SqlBatchResult> RunBatchAsync(string sql, bool returnsRows, CancellationToken ct, int? timeout = null) =>
       _sql.RunBatchAsync(sql, returnsRows, ct, timeout);

    #endregion
}
