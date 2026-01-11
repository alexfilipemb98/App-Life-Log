using LifeLog.Data.Bases;
using LifeLog.Data.DTOs;

namespace LifeLog.Data.DBs.Interfaces;

/// <summary>
/// Tasks DB Interface
/// </summary>
public interface ITasksDB : IBaseDB<TasksDTO>
{
	#region QUERIES

	/// <summary>
	/// Gets tasks for a user
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	Task<(List<TasksDTO?>?, string)> GetUserTasks(Guid id);
	
	#endregion
}
