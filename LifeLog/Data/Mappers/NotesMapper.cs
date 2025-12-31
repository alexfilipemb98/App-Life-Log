using DevExpress.Xpo;
using LifeLog.Data.DTOs;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// Notes mappers.
/// </summary>
internal static class NotesMapper
{
	/// <summary>
	/// NotesXPO to NotesModel mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static NotesDTO? ToModel(this NotesXPO xPO)
	{
		if (xPO is null)
			return null;

		NotesDTO note = new()
		{
			Id = xPO.Id,
			IdUser = xPO.User?.Id,
			Title = xPO.Title,
			Text = xPO.Text,
			Color = xPO.Color,
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
	internal static NotesXPO? ToEntity(this NotesDTO model, UnitOfWork db)
	{
		if (model == null) return null;

		UsersXPO user = db.GetObjectByKey<UsersXPO>(model.IdUser);
		NotesXPO entity = db.GetObjectByKey<NotesXPO>(model.Id);

		if (entity == null)
		{
			entity = new NotesXPO(db);
			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
		}

		entity.Title = model.Title;
		entity.Text = model.Text;
		entity.Color = model.Color;
		entity.Position = model.Position;
		entity.User = user;

		return entity;
	}
}
