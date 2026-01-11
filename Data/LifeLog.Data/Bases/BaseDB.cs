using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Helpers;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.Bases;

/// <summary>
/// Model base database operations
/// </summary>
/// <typeparam name="Model"></typeparam>
public class BaseDB<Model>
{
	#region MAIN

	//PRIVATE

	protected readonly UnitOfWork _db;
	protected readonly SqlDataAccess _sql;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="db"></param>
	public BaseDB(UnitOfWork db, SqlDataAccess sql)
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
