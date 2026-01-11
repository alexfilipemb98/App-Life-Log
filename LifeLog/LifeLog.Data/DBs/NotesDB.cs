using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Bases;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Helpers;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.DBs;

/// <summary>
/// Notes database operations
/// </summary>
public class NotesDB : BaseDB<NotesDTO>, INotesDB
{
	#region MAIN

	//PRIVATE
	private IUsersDB _userDB;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="userDB"></param>
	/// <param name="db"></param>
	/// <param name="sql"></param>
	public NotesDB(IUsersDB userDB, UnitOfWork db, SqlDataAccessHelper sql) : base(db, sql)
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
		bool exists = await _db.Query<NotesXPO>().AnyAsync(w => w.Id == key);
		return (exists, exists ? "Note exists" : "Note does not exist");
	}

	/// <summary>
	/// Get note by key
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(NotesDTO?, string)> GetByKey(Guid id)
	{
		NotesXPO? note;
		note = await _db.FindObjectAsync<NotesXPO>(id);
		bool found = note is not null;
		return (note?.ToModel(), found ? "Note found" : "Note not found");
	}

	/// <summary>
	/// Get all notes
	/// </summary>
	/// <returns></returns>
	public async Task<(List<NotesDTO?>?, string)> GetAll()
	{
		List<NotesXPO> notes = await _db.Query<NotesXPO>().ToListAsync();
		bool found = notes.Count > 0;
		List<NotesDTO?>? result = notes.ConvertAll(u => u.ToModel());
		return (result, found ? notes.Count + " notes found" : "No notes found");
	}

	/// <summary>
	/// Get the last dto on the database
	/// </summary>
	/// <returns></returns>
	public async Task<(NotesDTO?, string)> GetLast()
	{
		NotesDTO? note = await base.GetLastInsert();
		string message = note != null ? "Last note retrieved successfully" : "No note found";
		return (note, message);
	}

	/// <summary>
	/// Save note
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Save(NotesDTO model)
	{
		if (!model.IsValid())
			return (false, "Model is not valid");

		NotesXPO? entity = model.ToEntity(_db);

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
	public async Task<(NotesDTO?, string)> Duplicate(Guid key)
	{
		NotesXPO existingNote = await _db.FindObjectAsync<NotesXPO>(key);
		if (existingNote == null)
			return (null, "User not found");

		existingNote.Id = Guid.NewGuid();

		await _db.SaveAsync(existingNote);
		await _db.CommitChangesAsync();

		NotesXPO? duplicateNote = await _db.FindObjectAsync<NotesXPO>(existingNote.Id);
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
		NotesXPO note = await _db.FindObjectAsync<NotesXPO>(key);

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
	public async Task<(List<NotesDTO?>?, string)> GetUserNotes(Guid idUser)
	{
		(bool userexist, _) = await _userDB.Exists(idUser);
		if (!userexist)
			return (null, "User not found");

		List<NotesDTO?> notes = await _db.Query<NotesXPO>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();
		return (notes, notes.Count > 0 ? notes.Count + " notes found" : "No notes found");
	}

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Save list of notes
	/// </summary>
	/// <param name="list"></param>
	/// <returns></returns>
	public async Task<(bool, string)> SaveList(List<NotesDTO> list)
	{
		bool saved = false;

		foreach (NotesDTO obj in list)
			(saved, _) = await Save(obj);

		return (saved, saved ? "Notes saved successfully" : "Error saving notes");
	}

	#endregion
}
