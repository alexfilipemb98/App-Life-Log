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
}
