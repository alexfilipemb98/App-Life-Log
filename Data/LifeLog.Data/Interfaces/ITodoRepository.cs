
using LifeLog.Data.Entities;

namespace LifeLog.Data.Interfaces;

/// <summary>
/// Tasks DB Interface
/// </summary>
public interface ITodoRepository : IBaseRepository<Todo>
{
	#region QUERIES

	/// <summary>
	/// Gets tasks for a user
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	Task<(List<Todo?>?, string)> GetUserTasks(Guid id);
	
	#endregion
}
