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
	private IDbConnection _connection;

	/// <summary>
	/// Contructor
	/// </summary>
	/// <param name="connection"></param>
	public GeralDB(IDbConnection connection)
	{
		_connection = connection;
	}

	#endregion
	#region SQL

	public async Task<List<T>> LoadSql<T>(string sql)
	{		 
		using SqlDataAccessHelper db = new(_connection!);
		return await db.LoadDataListAsync<T>(sql);
	}


	public async Task<T?> ExecuteSql<T>(string sql)
	{
		using SqlDataAccessHelper db = new(_connection);
		return await db.ExecuteScalarAsync<T>(sql);
	}

	#endregion
}
