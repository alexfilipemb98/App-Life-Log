using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Bases;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Helpers;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.DBs;

/// <summary>
/// External Programs database operations
/// </summary>
public class ExternalProgramsDB : BaseDB<ExternalProgramsDTO>, IExternalProgramsDB
{
	#region MAIN

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="usersDB"></param>
	/// <param name="externalProgramsDB"></param>
	/// <param name="db"></param>
	/// <param name="sql"></param>
	public ExternalProgramsDB(UnitOfWork db, SqlDataAccess sql) : base(db, sql)
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
		bool exists = await _db.Query<ExternalProgramsXPO>().AnyAsync(w => w.Id == key);
		return (exists, exists ? "External program exists" : "External program does not exist");
	}

	/// <summary>
	/// Get external program by key
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(ExternalProgramsDTO?, string)> GetByKey(Guid id)
	{
		ExternalProgramsXPO? note;
		note = await _db.GetObjectByKeyAsync<ExternalProgramsXPO>(id);
		bool found = note is not null;
		return (note?.ToModel(), found ? "External program found" : "External program not found");
	}

	/// <summary>
	/// Get all external program
	/// </summary>
	/// <returns></returns>
	public async Task<(List<ExternalProgramsDTO?>?, string)> GetAll()
	{
		List<ExternalProgramsXPO> notes = await _db.Query<ExternalProgramsXPO>().ToListAsync();
		bool found = notes.Count > 0;
		List<ExternalProgramsDTO?>? result = notes.ConvertAll(u => u.ToModel());
		return (result, found ? notes.Count + " external programs found" : "No external programs found");
	}

	/// <summary>
	/// Get the last dto on the database
	/// </summary>
	/// <returns></returns>
	public async Task<(ExternalProgramsDTO?, string)> GetLast()
	{
		ExternalProgramsDTO? note = await base.GetLastInsert();
		string message = note != null ? "Last external program retrieved successfully" : "No external program found";
		return (note, message);
	}

	/// <summary>
	/// Save external program
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Save(ExternalProgramsDTO model)
	{
		if (!model.IsValid())
			return (false, "Model is not valid");

		ExternalProgramsXPO? entity = model.ToEntity(_db);

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
	public async Task<(ExternalProgramsDTO?, string)> Duplicate(Guid key)
	{
		ExternalProgramsXPO existingExternalProgram = await _db.GetObjectByKeyAsync<ExternalProgramsXPO>(key);
		if (existingExternalProgram == null)
			return (null, "User not found");

		existingExternalProgram.Id = Guid.NewGuid();

		await _db.SaveAsync(existingExternalProgram);
		await _db.CommitChangesAsync();

		ExternalProgramsXPO? duplicateExternalProgram = await _db.GetObjectByKeyAsync<ExternalProgramsXPO>(existingExternalProgram.Id);
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
		ExternalProgramsXPO externalProgram = await _db.GetObjectByKeyAsync<ExternalProgramsXPO>(key);

		externalProgram.Delete();

		await _db.CommitChangesAsync();

		(bool exists, _) = await Exists(key);

		return (!exists, !exists ? "External program deleted successfully" : "Error deleting external program");
	}

	#endregion
}
