using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Data.Interfaces;
using LifeLog.Data.Mappers;
using LifeLog.Data.Xpo.Model;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.Repositories;

/// <summary>
/// Tasks database operations
/// </summary>
public class TodoRepository : BaseRepository<Todo>, ITodoRepository
{
	#region MAIN

	//PRIVATE
	private readonly IUserRepository _userDB;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="usersDB"></param>
	/// <param name="db"></param>
	/// <param name="sql"></param>
	public TodoRepository(IUserRepository usersDB, UnitOfWork db, SqlDataAccess sql) : base(db, sql)
	{
		_userDB = usersDB;
	}

	#endregion

	#region BASE

	/// <summary>
	/// Exists task by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Exists(Guid key)
	{
		bool exists = await _db.Query<TodoXpo>().AnyAsync(w => w.Id == key);
		return (exists, exists ? "Task exists" : "Task does not exist");
	}

	/// <summary>
	/// Get task by key
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(Todo?, string)> GetByKey(Guid id)
	{
		TodoXpo? task;
		task = await _db.GetObjectByKeyAsync<TodoXpo>(id);
		bool found = task is not null;
		return (task?.ToModel(), found ? "Task found" : "Task not found");
	}

	/// <summary>
	/// Get all tasks
	/// </summary>
	/// <returns></returns>
	public async Task<(List<Todo?>?, string)> GetAll()
	{
		List<TodoXpo> tasks = await _db.Query<TodoXpo>().ToListAsync();
		bool found = tasks.Count > 0;
		List<Todo?>? result = tasks.ConvertAll(u => u.ToModel());
		return (result, found ? tasks.Count + " tasks found" : "No tasks found");
	}

	/// <summary>
	/// Get the last dto on the database
	/// </summary>
	/// <returns></returns>
	public async Task<(Todo?, string)> GetLast()
	{
		Todo? task = await base.GetLastInsert();
		string message = task != null ? "Last task retrieved successfully" : "No task found";
		return (task, message);
	}

	/// <summary>
	/// Save task
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Save(Todo model)
	{
		if (!model.IsValid())
			return (false, "Model is not valid");

		TodoXpo? entity = model.ToEntity(_db);

		if (entity is null)
			return (false, "Tasks entity is null");

		await _db.SaveAsync(entity);
		await _db.CommitChangesAsync();

		(bool exists, _) = await Exists(entity.Id);

		return (exists, exists ? "Task saved successfully" : "Error saving task");
	}

	/// <summary>
	/// Duplicate task by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(Todo?, string)> Duplicate(Guid key)
	{
		TodoXpo existingTask = await _db.GetObjectByKeyAsync<TodoXpo>(key);
		if (existingTask == null)
			return (null, "User not found");
		existingTask.Id = Guid.NewGuid();

		await _db.SaveAsync(existingTask);
		await _db.CommitChangesAsync();

		TodoXpo? duplicateTask = await _db.GetObjectByKeyAsync<TodoXpo>(existingTask.Id);
		bool found = duplicateTask is not null;

		return (duplicateTask?.ToModel(), found ? "Task duplicated successfully" : "Error duplicating task");
	}

	/// <summary>
	/// Delete the object by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Delete(Guid key)
	{
		throw new NotImplementedException();
	}

	#endregion

	#region QUERIES

	/// <summary>
	/// Devolve all task tasks
	/// </summary>
	/// <param name="idUser"></param>
	/// <returns></returns>
	public async Task<(List<Todo?>?, string)> GetUserTasks(Guid idUser)
	{
		(bool userexist, _) = await _userDB.Exists(idUser);
		if (!userexist)
			return (null, "User not found");

		List<Todo?> tasks = await _db.Query<TodoXpo>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();
		return (tasks, tasks.Count > 0 ? tasks.Count + " tasks found" : "No tasks found");
	}

	#endregion
}
