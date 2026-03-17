using LifeLog.Core.Interfaces;
using LifeLog.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Repos;

internal class BaseRepo<Entity>
{
	#region MAIN

	//PRIVATE

	protected readonly DbContext _db;
	protected readonly SqlDataAccess _sql;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="db"></param>
	public BaseRepository(DbContext db, SqlDataAccess sql)
	{
		_db = db;
		_sql = sql;
	}

	#endregion

	/// <summary>
	/// TABLE NAME
	/// </summary>
	public string TableName => typeof(Model).GetTableName();

	/// <summary>
	/// Get's the last insert object
	/// </summary>
	/// <returns></returns>
	public async Task<Model?> GetLastInsert()
	{
		if (string.IsNullOrEmpty(TableName))
			return default;

		string sql = @$"
			DECLARE @total int = (SELECT COUNT(*) FROM {TableName} WITH(NOLOCK));
			DECLARE @skip int = CASE WHEN @total > 0 THEN @total - 1 ELSE 0 END;

			SELECT * 
			FROM {TableName} WITH(NOLOCK)
			ORDER BY id ASC 
			OFFSET @skip ROWS 
			FETCH NEXT 1 ROWS ONLY;";

		return await _sql.GetValueAsync<Model>(sql);
	}
}
