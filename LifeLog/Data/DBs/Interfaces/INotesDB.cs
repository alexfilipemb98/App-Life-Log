using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;

public interface INotesDB
{
	Task<bool> Delete(Guid guid);
	Task<List<NotesDTO?>> GetUserNotes(Guid idUser);
	Task<bool> Save(NotesDTO note);
	Task<bool> SaveList(List<NotesDTO> list);
}
