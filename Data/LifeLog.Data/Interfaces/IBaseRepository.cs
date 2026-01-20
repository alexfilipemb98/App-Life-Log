namespace LifeLog.Data.Interfaces;

/// <summary>
/// Base interface for DB operations
/// </summary>
/// <typeparam name="Model"></typeparam>
public interface IBaseRepository<Model>
{
	/// <summary>
	/// Table name   
	/// </summary>
	string TableName { get; }

	/// <summary>
	/// Checks if the entity exists by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	Task<(bool, string)> Exists(Guid key);

	/// <summary>
	/// Gets the entity by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	Task<(Model?, string)> GetByKey(Guid key);

	/// <summary>
	/// Gets all entities
	/// </summary>
	/// <returns></returns>
	Task<(List<Model?>?, string)> GetAll();

	/// <summary>
	/// Get's the last insert object
	/// </summary>
	/// <param name="message"></param>
	/// <returns></returns>
	Task<(Model?, string)> GetLast(); 

	/// <summary>
	/// Save the object
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	Task<(bool, string)> Save(Model obj);

	/// <summary>
	/// /// Duplicates the object by key and returns the duplicated
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	Task<(Model?, string)> Duplicate(Guid key);

	/// <summary>
	/// Delete object by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	Task<(bool, string)> Delete(Guid key);
}
