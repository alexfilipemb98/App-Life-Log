using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Services.SqlData.Models;

/// <summary>
/// Sql batch result
/// </summary>
public sealed class SqlBatchResult
{
	#region PROPERTIES

	public bool ReturnsRows { get; init; }
	public List<string> Columns { get; init; } = new();
	public List<Dictionary<string, object?>> Rows { get; init; } = new();

	public int? AffectedRows { get; init; }
	
	#endregion
}
