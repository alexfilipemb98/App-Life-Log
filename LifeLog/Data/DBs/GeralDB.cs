using Data.DBs.Interfaces;
using Data.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBs;

public class GeralDB : IGeralDB
{
	#region SQL

	public async Task<List<T?>> LoadSql(string sql)
	{		 
		using SqlDataAccessHelper db = new(Engine.Instance!.Connection!);
		return await db.LoadDataListAsync<T>(sql);
	}


	public async Task<T?> ExecuteSql<T>(string sql)
	{
		using SqlDataAccessHelper db = new(Engine.Instance!.Connection!);
		return await db.ExecuteScalarAsync<T>(sql);
	}

	#endregion
}
