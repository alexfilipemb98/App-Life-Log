using DevExpress.Xpo;
using DevExpress.XtraEditors.Filtering;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.DBs;

public class TasksDB : ITasksDB
{

	private IUsersDB _userDB;
	private UnitOfWork _db;

	public TasksDB(IUsersDB usersDB, UnitOfWork db)
	{
		_userDB = usersDB;
		_db = db;
	}

	public async Task<List<TasksDTO?>> GetUserTasks(Guid idUser)
	{
		bool userexist = await _userDB.UserExistsById(idUser);
		if (!userexist)
			throw new ArgumentOutOfRangeException("User not found");

		List<TasksDTO?> tasks = await _db.Query<TasksXPO>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();

		return tasks;
	}

	public async Task<bool> Save(TasksDTO task)
	{
		TasksXPO? entity = task.ToEntity(_db);

		if (entity is null)
			throw new ArgumentNullException("Tasks entity is null");

		await _db.SaveAsync(entity);
		await _db.CommitChangesAsync();

		return true;
	}
}
