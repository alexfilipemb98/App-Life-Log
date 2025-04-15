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
        Entity GetByKey(Key key, out string message);

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        List<Entity> GetAll(out string message);

        /// <summary>
        /// Get's the last insert object
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Entity GetLast(out string message);

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
        Entity Duplicate(Key key, out string message);

        /// <summary>
        /// Delete object by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Delete(Key key, out string message);
    }
}
