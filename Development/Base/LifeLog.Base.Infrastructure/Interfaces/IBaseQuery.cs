using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Base.Infrastructure.Interfaces
{
	/// <summary>
	/// Query Interface for Base Query
	/// </summary>
	/// <typeparam name="Object"></typeparam>
	/// <typeparam name="Key"></typeparam>
	public interface IBaseQuery<Object, Key>
	{
		/// <summary>
		/// Table name   
		/// </summary>
		string TableName<Entity>();

		/// <summary>
		/// Checks if the entity exists by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<(bool, string)> Exists(Key key);

		/// <summary>
		/// Gets the entity by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<(Object, string)> GetByKey(Key key);

		/// <summary>
		/// Gets all entities
		/// </summary>
		/// <returns></returns>
		 Task<(List<Object>, string)> GetAll();

		/// <summary>
		/// Get's the last insert object
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		Task<(Object, string)> GetLast();

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		Task<(bool, string)> Save(Object obj);

		/// <summary>
		/// /// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<(Object, string)> Duplicate(Key key);

		/// <summary>
		/// Delete object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<(bool, string)> Delete(Key key);
	}
}
