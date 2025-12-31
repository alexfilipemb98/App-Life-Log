using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;

public interface ITasksDB
{
	Task<List<TasksDTO?>> GetUserTasks(Guid id);
	Task<bool> Save(TasksDTO task);
}
