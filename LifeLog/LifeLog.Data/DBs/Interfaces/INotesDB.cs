using LifeLog.Data.Bases;
using LifeLog.Data.DTOs;

namespace LifeLog.Data.DBs.Interfaces;

/// <summary>
/// Notes database operations
/// </summary>
public interface INotesDB : IBaseDB<NotesDTO>
{
	#region QUERIES

	/// <summary>
	/// Gets notes for a user
	/// </summary>
	/// <param name="idUser"></param>
	/// <returns></returns>
	Task<(List<NotesDTO?>?, string)> GetUserNotes(Guid idUser);

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Save list of notes
	/// </summary>
	/// <param name="list"></param>
	/// <returns></returns>
	Task<(bool, string)> SaveList(List<NotesDTO> list);

	#endregion
}
