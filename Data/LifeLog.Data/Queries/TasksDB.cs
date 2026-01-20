using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Bases;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.DBs;

/// <summary>
/// Tasks database operations
/// </summary>
public class TasksDB : BaseDB<TasksDTO>, ITasksDB
{
    #region MAIN

    //PRIVATE
    private readonly IUsersDB _userDB;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="usersDB"></param>
    /// <param name="db"></param>
    /// <param name="sql"></param>
    public TasksDB(IUsersDB usersDB, UnitOfWork db, SqlDataAccess sql) : base(db, sql)
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
        bool exists = await _db.Query<TasksXPO>().AnyAsync(w => w.Id == key);
        return (exists, exists ? "Task exists" : "Task does not exist");
    }

    /// <summary>
    /// Get task by key
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<(TasksDTO?, string)> GetByKey(Guid id)
    {
        TasksXPO? task;
        task = await _db.GetObjectByKeyAsync<TasksXPO>(id);
        bool found = task is not null;
        return (task?.ToModel(), found ? "Task found" : "Task not found");
    }

    /// <summary>
    /// Get all tasks
    /// </summary>
    /// <returns></returns>
    public async Task<(List<TasksDTO?>?, string)> GetAll()
    {
        List<TasksXPO> tasks = await _db.Query<TasksXPO>().ToListAsync();
        bool found = tasks.Count > 0;
        List<TasksDTO?>? result = tasks.ConvertAll(u => u.ToModel());
        return (result, found ? tasks.Count + " tasks found" : "No tasks found");
    }

    /// <summary>
    /// Get the last dto on the database
    /// </summary>
    /// <returns></returns>
    public async Task<(TasksDTO?, string)> GetLast()
    {
        TasksDTO? task = await base.GetLastInsert();
        string message = task != null ? "Last task retrieved successfully" : "No task found";
        return (task, message);
    }

    /// <summary>
    /// Save task
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Save(TasksDTO model)
    {
        if (!model.IsValid())
            return (false, "Model is not valid");

        TasksXPO? entity = model.ToEntity(_db);

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
    public async Task<(TasksDTO?, string)> Duplicate(Guid key)
    {
        TasksXPO existingTask = await _db.GetObjectByKeyAsync<TasksXPO>(key);
        if (existingTask == null)
            return (null, "User not found");
        existingTask.Id = Guid.NewGuid();

        await _db.SaveAsync(existingTask);
        await _db.CommitChangesAsync();

        TasksXPO? duplicateTask = await _db.GetObjectByKeyAsync<TasksXPO>(existingTask.Id);
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
    public async Task<(List<TasksDTO?>?, string)> GetUserTasks(Guid idUser)
    {
        (bool userexist, _) = await _userDB.Exists(idUser);
        if (!userexist)
            return (null, "User not found");

        List<TasksDTO?> tasks = await _db.Query<TasksXPO>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();
        return (tasks, tasks.Count > 0 ? tasks.Count + " tasks found" : "No tasks found");
    }

    #endregion
}
