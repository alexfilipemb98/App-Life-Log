using DevExpress.Xpo;
using LifeLog.Data.Entities;
using LifeLog.Data.Xpo.ModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// TodoXpo mappers.
/// </summary>
internal static class TodoMapper
{
    /// <summary>
    /// TodoXpo to Todo mapper.
    /// </summary>
    /// <param name="xPO"></param>
    /// <returns></returns>
    internal static Todo? ToModel(this TodoXpo xPO)
    {
        if (xPO is null)
            return null;

        Todo task = new()
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
    internal static TodoXpo? ToEntity(this Todo model, UnitOfWork db)
    {
        if (model == null) return null;

        UserXpo user = db.GetObjectByKey<UserXpo>(model.IdUser);
        TodoXpo entity = db.GetObjectByKey<TodoXpo>(model.Id);

        if (entity == null)
        {
            entity = new TodoXpo(db);
            entity.Id = Guid.NewGuid();
            model.Id = entity.Id;
        }

        entity.Description = model.Description;
        entity.IsDone = model.IsDone;
        entity.User = user;

        return entity;
    }

}
