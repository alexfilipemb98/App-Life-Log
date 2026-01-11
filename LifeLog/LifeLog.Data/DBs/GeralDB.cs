using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.Helpers;

namespace LifeLog.Data.DBs;

/// <summary>
/// Geral data
/// </summary>
public class GeralDB : IGeralDB
{
	#region MAIN

	//PRIVATE
	private readonly SqlDataAccessHelper _sql;

	/// <summary>
	/// Contructor
	/// </summary>
	/// <param name="connection"></param>
	public GeralDB(SqlDataAccessHelper sql)
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

	#endregion
}
