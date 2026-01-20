using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Data.Interfaces;
using LifeLog.Data.Mappers;
using LifeLog.Data.Xpo.Model;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.Repositories;

/// <summary>
/// Notes database operations
/// </summary>
public class NoteRepository : BaseRepository<Note>, INoteRepository
{
    #region MAIN

    //PRIVATE
    private IUserRepository _userDB;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="userDB"></param>
    /// <param name="db"></param>
    /// <param name="sql"></param>
    public NoteRepository(IUserRepository userDB, UnitOfWork db, SqlDataAccess sql) : base(db, sql)
    {
        _userDB = userDB;
    }

    #endregion

    #region BASE

    /// <summary>
    /// Exists note by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Exists(Guid key)
    {
        bool exists = await _db.Query<NoteXpo>().AnyAsync(w => w.Id == key);
        return (exists, exists ? "Note exists" : "Note does not exist");
    }

    /// <summary>
    /// Get note by key
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<(Note?, string)> GetByKey(Guid id)
    {
        NoteXpo? note;
        note = await _db.GetObjectByKeyAsync<NoteXpo>(id);
        bool found = note is not null;
        return (note?.ToModel(), found ? "Note found" : "Note not found");
    }

    /// <summary>
    /// Get all notes
    /// </summary>
    /// <returns></returns>
    public async Task<(List<Note?>?, string)> GetAll()
    {
        List<NoteXpo> notes = await _db.Query<NoteXpo>().ToListAsync();
        bool found = notes.Count > 0;
        List<Note?>? result = notes.ConvertAll(u => u.ToModel());
        return (result, found ? notes.Count + " notes found" : "No notes found");
    }

    /// <summary>
    /// Get the last dto on the database
    /// </summary>
    /// <returns></returns>
    public async Task<(Note?, string)> GetLast()
    {
        Note? note = await base.GetLastInsert();
        string message = note != null ? "Last note retrieved successfully" : "No note found";
        return (note, message);
    }

    /// <summary>
    /// Save note
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Save(Note model)
    {
        if (!model.IsValid())
            return (false, "Model is not valid");

        NoteXpo? entity = model.ToEntity(_db);

        if (entity is null)
            return (false, "Notes entity is null");

        await _db.SaveAsync(entity);
        await _db.CommitChangesAsync();

        (bool exists, _) = await Exists(entity.Id);

        return (exists, exists ? "Note saved successfully" : "Error saving note");
    }

    /// <summary>
    /// Duplicate note by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(Note?, string)> Duplicate(Guid key)
    {
        NoteXpo existingNote = await _db.GetObjectByKeyAsync<NoteXpo>(key);
        if (existingNote == null)
            return (null, "User not found");

        existingNote.Id = Guid.NewGuid();

        await _db.SaveAsync(existingNote);
        await _db.CommitChangesAsync();

        NoteXpo? duplicateNote = await _db.GetObjectByKeyAsync<NoteXpo>(existingNote.Id);
        bool found = duplicateNote is not null;

        return (duplicateNote?.ToModel(), found ? "Note duplicated successfully" : "Error duplicating note");
    }

    /// <summary>
    /// Delete the object by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Delete(Guid key)
    {
        NoteXpo note = await _db.GetObjectByKeyAsync<NoteXpo>(key);

        if (note is null)
            return (false, "Note not found");

        note.Delete();

        await _db.CommitChangesAsync();

        (bool exists, _) = await Exists(key);

        return (!exists, !exists ? "Note deleted successfully" : "Error deleting note");
    }

    #endregion

    #region QUERIES

    /// <summary>
    /// Devolve all note notes
    /// </summary>
    /// <param name="idUser"></param>
    /// <returns></returns>
    public async Task<(List<Note?>?, string)> GetUserNotes(Guid idUser)
    {
        (bool userexist, _) = await _userDB.Exists(idUser);
        if (!userexist)
            return (null, "User not found");

        List<Note?> notes = await _db.Query<NoteXpo>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();
        return (notes, notes.Count > 0 ? notes.Count + " notes found" : "No notes found");
    }

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Save list of notes
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public async Task<(bool, string)> SaveList(List<Note> list)
    {
        bool saved = false;

        foreach (Note obj in list)
            (saved, _) = await Save(obj);

        return (saved, saved ? "Notes saved successfully" : "Error saving notes");
    }

    #endregion
}
