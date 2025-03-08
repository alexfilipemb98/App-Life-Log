using System.Collections.Generic;
using System.Linq;

namespace Core.Interfaces
{
    /// <summary>
    /// Query Interface for Base Query
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    /// <typeparam name="Key"></typeparam>
    public interface IBaseQuery<Entity, Key>
    {
       
        /// <summary>
        /// Query Base
        /// </summary>
        IQueryable<Entity> QueryBase { get; }

        /// <summary>
        /// Checks if the table exists
        /// </summary>
        /// <returns></returns>
        bool TableExists();

        /// <summary>
        /// Checks if the object exists
        /// </summary>
        /// <param fName="key"></param>
        /// <param fName="message"></param>
        /// <returns></returns>
        bool Exists(Key key);

        /// <summary>
        /// Gets the entity by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Entity GetByKey(Key key);

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        List<Entity> GetAll();

        /// <summary>
        /// Get's the last insert object
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Entity GetLast();

        /// <summary>
        /// Save the object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Save(Entity obj, out string message);

        /// <summary>
        /// /// Duplicates the object by key and returns the duplicated
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Entity Duplicate(Key key);

        /// <summary>
        /// Delete object by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Delete(Key key, out string message);
    }
}
