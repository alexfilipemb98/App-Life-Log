using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Interfaces
{
	/// <summary>
	/// Query Interface for Base Query
	/// </summary>
	/// <typeparam name="Entity"></typeparam>
	/// <typeparam name="Object"></typeparam>
	/// <typeparam name="Key"></typeparam>
	public interface IBaseQuery<Entity, Object, Key>
	{
		/// <summary>
		/// Table name   
		/// </summary>
		string TableName { get; }

		/// <summary>
		/// Checks if the object exists
		/// </summary>
		/// <param fName="key"></param>
		/// <param fName="message"></param>
		/// <returns></returns>
		Task<bool> Exists(Key key);

		/// <summary>
		/// Gets the entity by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<Object> GetByKey(Key key);

		/// <summary>
		/// Gets all entities
		/// </summary>
		/// <returns></returns>
		 Task<List<Object>> GetAll();

		/// <summary>
		/// Get's the last insert object
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		Task<Object> GetLast();

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		Task<bool> Save(Object obj);

		/// <summary>
		/// /// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<Object> Duplicate(Key key);

		/// <summary>
		/// Delete object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<bool> Delete(Key key);
	}
}
