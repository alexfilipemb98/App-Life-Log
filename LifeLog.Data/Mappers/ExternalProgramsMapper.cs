using DevExpress.Xpo;
using LifeLog.Data.DTOs;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// Commnads Mapper
/// </summary>
internal static class ExternalProgramsMapper
{
	/// <summary>
	/// CommandsXPO to CommandsModel mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static ExternalProgramsDTO? ToModel(this ExternalProgramsXPO xPO)
	{
		if (xPO is null)
			return null;

		ExternalProgramsDTO note = new()
		{
			Id = xPO.Id,
			Name = xPO.Name,
			Arguments = xPO.Arguments,
			FileExtension = xPO.FileExtension,
			ImageExtension = xPO.ImageExtension,
			ImageData = xPO.ImageData,
			PathToProgram = xPO.PathToProgram,
		};

		return note;
	}

	/// <summary>
	/// NotesModel to ORM_NotesModel mapper.
	/// </summary>
	/// <param fName="model"></param>
	/// <param fName="db"></param>
	/// <returns></returns>
	internal static ExternalProgramsXPO? ToEntity(this ExternalProgramsDTO model, UnitOfWork db)
	{
		if (model == null) return null;

		ExternalProgramsXPO entity = db.GetObjectByKey<ExternalProgramsXPO>(model.Id);

		if (entity == null)
		{
			entity = new ExternalProgramsXPO(db);
			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
		}

		entity.Name = model.Name;
		entity.Arguments = model.Arguments;
		entity.FileExtension = model.FileExtension;
		entity.ImageExtension = model.ImageExtension;
		entity.ImageData = model.ImageData;
		entity.PathToProgram = model.PathToProgram;

		return entity;
	}
}