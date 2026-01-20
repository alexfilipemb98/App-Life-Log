using LifeLog.Services.SqlData.Models;

namespace LifeLog.Data.DBs.Interfaces;

/// <summary>
/// Interface for the geral db
/// </summary>
public interface IGeralDB
{
    /// <summary>
    /// Loads any query sql 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <returns></returns>
    Task<List<T>> LoadSql<T>(string sql);

    /// <summary>
    /// Executes any query sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <returns></returns>
    Task<T?> ExecuteSql<T>(string sql);

    /// <summary>
    /// Runs a sql batch
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="returnsRows"></param>
    /// <param name="ct"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    Task<SqlBatchResult> RunBatchAsync(string sql, bool returnsRows, CancellationToken ct, int? timeout = null);
}
