using System.Collections.Generic;
using System.Linq;

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
		/// Query Base
		/// </summary>
		IQueryable<Entity> QueryBase { get; }

		/// <summary>
		/// Checks if table exists
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		bool TableExists(out string message);

		/// <summary>
		/// Checks if the object exists
		/// </summary>
		/// <param fName="key"></param>
		/// <param fName="message"></param>
		/// <returns></returns>
		bool Exists(Key key, out string message);

		/// <summary>
		/// Gets the entity by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Object GetByKey(Key key, out string message);

		/// <summary>
		/// Gets all entities
		/// </summary>
		/// <returns></returns>
		List<Object> GetAll(out string message);

		/// <summary>
		/// Get's the last insert object
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		Object GetLast(out string message);

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		bool Save(Object obj, out string message);

		/// <summary>
		/// /// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Object Duplicate(Key key, out string message);

		/// <summary>
		/// Delete object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		bool Delete(Key key, out string message);
	}
}
