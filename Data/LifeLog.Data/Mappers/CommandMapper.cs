using DevExpress.Xpo;
using LifeLog.Data.Entities;
using LifeLog.Data.Xpo.Model;

namespace LifeLog.Data.Mappers;

/// <summary>
/// Mapper for CommandsEntity
/// </summary>
internal static class CommandMapper
{
    /// <summary>
    /// CommandXpo to Commands mapper.
    /// </summary>
    /// <param name="xPO"></param>
    /// <returns></returns>
    internal static Command? ToModel(this CommandXpo xPO)
    {
        if (xPO is null)
            return null;

        Command note = new()
        {
            Id = xPO.Id,
            IdUser = xPO.User?.Id,
            Text = xPO.Text,
            Description = xPO.Description,
            Name = xPO.Name,
            IsEnabled = xPO.IsEnabled,
            NeedsAdmin = xPO.NeedsAdmin,
            ExternalProgram = xPO.ExternalProgram?.ToModel(),
            Position = xPO.Position,
        };

        return note;
    }
    /// <summary>
    /// Notes to ORM_Notes mapper.
    /// </summary>
    /// <param fName="model"></param>
    /// <param fName="db"></param>
    /// <returns></returns>
    internal static CommandXpo? ToEntity(this Command model, UnitOfWork db)
    {
        if (model == null) return null;

        UserXpo user = db.GetObjectByKey<UserXpo>(model.IdUser);
        CommandXpo entity = db.GetObjectByKey<CommandXpo>(model.Id);
        ExternalProgramXpo program = db.GetObjectByKey<ExternalProgramXpo>(model.IdExternalProgram);

        if (entity == null)
        {
            entity = new CommandXpo(db);
            entity.Id = Guid.NewGuid();
            model.Id = entity.Id;
        }

        entity.Text = model.Text;
        entity.Description = model.Description;
        entity.Name = model.Name;
        entity.IsEnabled = model.IsEnabled;
        entity.NeedsAdmin = model.NeedsAdmin;
        entity.ExternalProgram = program;
        entity.Position = model.Position;
        entity.Position = model.Position;
        entity.User = user;

        return entity;
    }
}
