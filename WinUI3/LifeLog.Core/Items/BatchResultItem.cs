using System.Collections.Generic;

namespace LifeLog.Services.SqlData.Models;

/// <summary>
/// Represents a single result item returned from a SQL batch execution.
/// </summary>
/// <remarks>
/// A batch may return rows (query result) or only affected row count (non-query result).
/// </remarks>
public sealed class BatchResultItem
{
	#region PROPERTIES

	/// <summary>
	/// Gets a value indicating whether this batch item contains tabular rows.
	/// </summary>
	public bool ReturnsRows { get; init; }

	/// <summary>
	/// Gets the column names returned by the query result.
	/// </summary>
	public List<string> Columns { get; init; } = new();

	/// <summary>
	/// Gets the returned rows, where each row is a key/value map of column name to value.
	/// </summary>
	public List<Dictionary<string, object>> Rows { get; init; } = new();

	/// <summary>
	/// Gets the number of affected rows for non-query operations (for example, INSERT/UPDATE/DELETE).
	/// </summary>
	public int? AffectedRows { get; init; }

	#endregion
}
