using DevExpress.Xpo;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.DBs;

public class NotesDB : INotesDB
{
	private IUsersDB _userDB;
	private UnitOfWork _db;

	public NotesDB(IUsersDB usersDB, UnitOfWork db)
	{
		_userDB = usersDB;
		_db = db;
	}

	public async Task<bool> Delete(Guid guid)
	{
		var note = await _db.FindObjectAsync<NotesXPO>(guid);

		note.Delete();

		await _db.CommitChangesAsync();

		return true;
	}

	public async Task<List<NotesDTO?>> GetUserNotes(Guid idUser)
	{
		bool userexist = await _userDB.UserExistsById(idUser);
		if (!userexist)
			throw new ArgumentOutOfRangeException("User not found");

		List<NotesDTO?> notes = await _db.Query<NotesXPO>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();

		return notes;
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
