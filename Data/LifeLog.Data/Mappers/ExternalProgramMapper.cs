using DevExpress.Xpo;
using LifeLog.Data.Entities;
using LifeLog.Data.Xpo.ModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// Commnads Mapper
/// </summary>
internal static class ExternalProgramMapper
{
    /// <summary>
    /// CommandXpo to CommandsModel mapper.
    /// </summary>
    /// <param name="xPO"></param>
    /// <returns></returns>
    internal static ExternalProgram? ToModel(this ExternalProgramXpo xPO)
    {
        if (xPO is null)
            return null;

        ExternalProgram note = new()
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
    internal static ExternalProgramXpo? ToEntity(this ExternalProgram model, UnitOfWork db)
    {
        if (model == null) return null;

        ExternalProgramXpo entity = db.GetObjectByKey<ExternalProgramXpo>(model.Id);

        if (entity == null)
        {
            entity = new ExternalProgramXpo(db);
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