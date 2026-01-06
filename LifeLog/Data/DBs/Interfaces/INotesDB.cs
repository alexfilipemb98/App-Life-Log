using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;

public interface INotesDB
{
	#region QUERIES

	/// <summary>
	/// Gets notes for a user
	/// </summary>
	/// <param name="idUser"></param>
	/// <returns></returns>
	Task<(List<NotesDTO?>?, string)> GetUserNotes(Guid idUser);

	#endregion

	Task<bool> Delete(Guid guid);


	Task<bool> Save(NotesDTO note);
	Task<bool> SaveList(List<NotesDTO> list);
}
