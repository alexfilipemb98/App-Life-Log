using LifeLog.Data.Entities;

namespace LifeLog.Data.Interfaces;

/// <summary>
/// Notes database operations
/// </summary>
public interface INoteRepository : IBaseRepository<Note>
{
    #region QUERIES

    /// <summary>
    /// Gets notes for a user
    /// </summary>
    /// <param name="idUser"></param>
    /// <returns></returns>
    Task<(List<Note?>?, string)> GetUserNotes(Guid idUser);

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Save list of notes
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    Task<(bool, string)> SaveList(List<Note> list);

    #endregion
}
