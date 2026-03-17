using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.Core.Interfaces;

/// <summary>
/// Defines the base contract for repository data operations.
/// </summary>
/// <typeparam name="TModel">Entity type handled by the repository.</typeparam>
public interface IBaseRepo<TModel>
{
	/// <summary>
	/// Gets the database table name associated with the repository.
	/// </summary>
	string TableName { get; }

	/// <summary>
	/// Checks whether an entity exists by its key.
	/// </summary>
	/// <param name="key">Entity unique identifier.</param>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>bool</c>: <c>true</c> if the entity exists; otherwise, <c>false</c>.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(bool, string)> Exists(Guid key);

	/// <summary>
	/// Gets an entity by its key.
	/// </summary>
	/// <param name="key">Entity unique identifier.</param>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>TModel?</c>: found entity, or <c>null</c> if not found.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(TModel?, string)> GetByKey(Guid key);

	/// <summary>
	/// Gets all entities.
	/// </summary>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>List&lt;TModel?&gt;?</c>: list of entities, or <c>null</c> if retrieval failed.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(List<TModel?>?, string)> GetAll();

	/// <summary>
	/// Gets the last inserted entity.
	/// </summary>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>TModel?</c>: last inserted entity, or <c>null</c> if unavailable.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(TModel?, string)> GetLast();

	/// <summary>
	/// Saves the provided entity.
	/// </summary>
	/// <param name="obj">Entity instance to save.</param>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>bool</c>: <c>true</c> if saved successfully; otherwise, <c>false</c>.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(bool, string)> Save(TModel obj);

	/// <summary>
	/// Duplicates an entity by key and returns the duplicated entity.
	/// </summary>
	/// <param name="key">Entity unique identifier.</param>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>TModel?</c>: duplicated entity, or <c>null</c> if duplication failed.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(TModel?, string?)> Duplicate(Guid key);

	/// <summary>
	/// Deletes an entity by key.
	/// </summary>
	/// <param name="key">Entity unique identifier.</param>
	/// <returns>
	/// A tuple containing:
	/// <list type="bullet">
	/// <item><description><c>bool</c>: <c>true</c> if deleted successfully; otherwise, <c>false</c>.</description></item>
	/// <item><description><c>string</c>: operation message or error details.</description></item>
	/// </list>
	/// </returns>
	Task<(bool, string)> Delete(Guid key);
}