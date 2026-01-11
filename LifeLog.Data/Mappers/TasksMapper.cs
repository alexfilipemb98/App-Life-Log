using DevExpress.Xpo;
using LifeLog.Data.DTOs;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// TasksXPO mappers.
/// </summary>
internal static class TasksMapper
{
	/// <summary>
	/// TasksXPO to TasksDTO mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static TasksDTO? ToModel(this TasksXPO xPO)
	{
		if (xPO is null)
			return null;

		TasksDTO task = new()
		{
			Id = xPO.Id,
			Description = xPO.Description,
			IsDone = xPO.IsDone,
			IdUser = xPO.User?.Id,
		};

		return task;
	}

	/// <summary>
	/// TasksModel to ORM_TasksModel mapper.
	/// </summary>
	/// <param name="model"></param>
	/// <param name="db"></param>
	/// <returns></returns>
	internal static TasksXPO? ToEntity(this TasksDTO model, UnitOfWork db)
	{
		if (model == null) return null;

		UsersXPO user = db.GetObjectByKey<UsersXPO>(model.IdUser);
		TasksXPO entity = db.GetObjectByKey<TasksXPO>(model.Id);

		if (entity == null)
		{
			entity = new TasksXPO(db);
			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
		}

		entity.Description = model.Description;
		entity.IsDone = model.IsDone;
		entity.User = user;

		return entity;
	}

}
