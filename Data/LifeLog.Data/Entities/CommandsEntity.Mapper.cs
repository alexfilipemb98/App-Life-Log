using DevExpress.Xpo;

using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Entities;

/// <summary>
/// Mapper for CommandsEntity
/// </summary>
public partial class CommandsEntity
{
	/// <summary>
	/// CommandsXPO to CommandsModel mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static CommandsEntity? ToModel(this CommandsXPO xPO)
	{
		if (xPO is null)
			return null;

		CommandsEntity note = new()
		{
			Id = xPO.Id,
			IdUser = xPO.User?.Id,
			Command = xPO.Command,
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
	/// NotesModel to ORM_NotesModel mapper.
	/// </summary>
	/// <param fName="model"></param>
	/// <param fName="db"></param>
	/// <returns></returns>
	internal static CommandsXPO? ToEntity(this CommandsEntity model, UnitOfWork db)
	{
		if (model == null) return null;

		UsersXPO user = db.GetObjectByKey<UsersXPO>(model.IdUser);
		CommandsXPO entity = db.GetObjectByKey<CommandsXPO>(model.Id);
		ExternalProgramsXPO program = db.GetObjectByKey<ExternalProgramsXPO>(model.IdExternalProgram);

		if (entity == null)
		{
			entity = new CommandsXPO(db);
			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
		}

		entity.Command = model.Command;
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
