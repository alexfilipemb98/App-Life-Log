using Data.DBs.Interfaces;
using Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBs;

public class GeralDB : IGeralDB
{
	private IDbConnection _connection;

	public GeralDB(IDbConnection connection)
	{
		_connection = connection;
	}

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
