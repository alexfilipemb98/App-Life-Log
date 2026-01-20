using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Data.Interfaces;
using LifeLog.Data.Mappers;
using LifeLog.Data.Xpo.Model;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.Repositories;

/// <summary>
/// External Programs database operations
/// </summary>
public class ExternalProgramRepository : BaseRepository<ExternalProgram>, IExternalProgramRepository
{
    #region MAIN

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="usersDB"></param>
    /// <param name="externalProgramsDB"></param>
    /// <param name="db"></param>
    /// <param name="sql"></param>
    public ExternalProgramRepository(UnitOfWork db, SqlDataAccess sql) : base(db, sql)
    {
    }

    #endregion

    #region BASE

    /// <summary>
    /// Exists external program by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Exists(Guid key)
    {
        bool exists = await _db.Query<ExternalProgramXpo>().AnyAsync(w => w.Id == key);
        return (exists, exists ? "External program exists" : "External program does not exist");
    }

    /// <summary>
    /// Get external program by key
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<(ExternalProgram?, string)> GetByKey(Guid id)
    {
        ExternalProgramXpo? note;
        note = await _db.GetObjectByKeyAsync<ExternalProgramXpo>(id);
        bool found = note is not null;
        return (note?.ToModel(), found ? "External program found" : "External program not found");
    }

    /// <summary>
    /// Get all external program
    /// </summary>
    /// <returns></returns>
    public async Task<(List<ExternalProgram?>?, string)> GetAll()
    {
        List<ExternalProgramXpo> notes = await _db.Query<ExternalProgramXpo>().ToListAsync();
        bool found = notes.Count > 0;
        List<ExternalProgram?>? result = notes.ConvertAll(u => u.ToModel());
        return (result, found ? notes.Count + " external programs found" : "No external programs found");
    }

    /// <summary>
    /// Get the last dto on the database
    /// </summary>
    /// <returns></returns>
    public async Task<(ExternalProgram?, string)> GetLast()
    {
        ExternalProgram? note = await base.GetLastInsert();
        string message = note != null ? "Last external program retrieved successfully" : "No external program found";
        return (note, message);
    }

    /// <summary>
    /// Save external program
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Save(ExternalProgram model)
    {
        if (!model.IsValid())
            return (false, "Model is not valid");

        ExternalProgramXpo? entity = model.ToEntity(_db);

        if (entity is null)
            return (false, "External program entity is null");

        await _db.SaveAsync(entity);
        await _db.CommitChangesAsync();

        (bool exists, _) = await Exists(entity.Id);

        return (exists, exists ? "External program saved successfully" : "Error saving external program");
    }

    /// <summary>
    /// Duplicate externalProgram by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(ExternalProgram?, string)> Duplicate(Guid key)
    {
        ExternalProgramXpo existingExternalProgram = await _db.GetObjectByKeyAsync<ExternalProgramXpo>(key);
        if (existingExternalProgram == null)
            return (null, "User not found");

        existingExternalProgram.Id = Guid.NewGuid();

        await _db.SaveAsync(existingExternalProgram);
        await _db.CommitChangesAsync();

        ExternalProgramXpo? duplicateExternalProgram = await _db.GetObjectByKeyAsync<ExternalProgramXpo>(existingExternalProgram.Id);
        bool found = duplicateExternalProgram is not null;

        return (duplicateExternalProgram?.ToModel(), found ? "Note duplicated successfully" : "Error duplicating note");
    }

    /// <summary>
    /// Delete the object by key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<(bool, string)> Delete(Guid key)
    {
        ExternalProgramXpo externalProgram = await _db.GetObjectByKeyAsync<ExternalProgramXpo>(key);

        externalProgram.Delete();

        await _db.CommitChangesAsync();

        (bool exists, _) = await Exists(key);

        return (!exists, !exists ? "External program deleted successfully" : "Error deleting external program");
    }

    #endregion
}
