using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.Helpers;
using System.Data;

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

	public async Task<List<T>> LoadSql<T>(string sql)
	{		 
		return await _sql.LoadDataListAsync<T>(sql);
	}


	public async Task<T?> ExecuteSql<T>(string sql)
	{
		return await _sql.ExecuteScalarAsync<T>(sql);
	}

	#endregion
}
