using DevExpress.Xpo;
using LifeLog.Data.Bases;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Helpers;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.DBs;

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

























	#region QUERIES

	/// <summary>
	/// Devolve all user notes
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





	public async Task<bool> Delete(Guid guid)
	{
		NotesXPO note = await _db.FindObjectAsync<NotesXPO>(guid);

		note.Delete();

		await _db.CommitChangesAsync();

		return true;
	}

	
	public async Task<bool> Save(NotesDTO note)
	{
		NotesXPO? entity = note.ToEntity(_db);

		if (entity is null)
			throw new ArgumentNullException("Notes entity is null");

		await _db.SaveAsync(entity);
		await _db.CommitChangesAsync();

		return true;
	}

	public async Task<bool> SaveList(List<NotesDTO> list)
	{
		bool saved = false;

		foreach (NotesDTO obj in list)
			saved = await Save(obj);

		return saved;
	}
}
