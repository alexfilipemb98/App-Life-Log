using DevExpress.Xpo;
using LifeLog.Data.Entities;
using LifeLog.Data.Xpo.ModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// Notes mappers.
/// </summary>
internal static class NoteMapper
{
    /// <summary>
    /// NoteXpo to NotesModel mapper.
    /// </summary>
    /// <param name="xPO"></param>
    /// <returns></returns>
    internal static Note? ToModel(this NoteXpo xPO)
    {
        if (xPO is null)
            return null;

        Note note = new()
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
    internal static NoteXpo? ToEntity(this Note model, UnitOfWork db)
    {
        if (model == null) return null;

        UserXpo user = db.GetObjectByKey<UserXpo>(model.IdUser);
        NoteXpo entity = db.GetObjectByKey<NoteXpo>(model.Id);

        if (entity == null)
        {
            entity = new NoteXpo(db);
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
