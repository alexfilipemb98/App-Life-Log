using DevExpress.Xpo;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Data.Interfaces;
using LifeLog.Data.Mappers;
using LifeLog.Data.Xpo.Model;
using LifeLog.Services.SqlData;

namespace LifeLog.Data.Repositories;

/// <summary>
/// Commands database operations
/// </summary>
public class CommandRepository : BaseRepository<Command>, ICommandRepository
{
	#region MAIN

	//PRIVATE
	private IUserRepository _userDB;
	private IExternalProgramRepository _externalProgramsDB;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="usersDB"></param>
	/// <param name="externalProgramsDB"></param>
	/// <param name="db"></param>
	/// <param name="sql"></param>
	public CommandRepository(IUserRepository usersDB, IExternalProgramRepository externalProgramsDB, UnitOfWork db, SqlDataAccess sql) : base(db, sql)
	{
		_userDB = usersDB;
		_externalProgramsDB = externalProgramsDB;
	}

	#endregion

	#region BASE

	/// <summary>
	/// Exists command by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Exists(Guid key)
	{
		bool exists = await _db.Query<CommandXpo>().AnyAsync(w => w.Id == key);
		return (exists, exists ? "Command exists" : "Command does not exist");
	}

	/// <summary>
	/// Get command by key
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(Command?, string)> GetByKey(Guid id)
	{
		CommandXpo? command;
		command = await _db.GetObjectByKeyAsync<CommandXpo>(id);
		bool found = command is not null;
		return (command?.ToModel(), found ? "Command found" : "Command not found");
	}

	/// <summary>
	/// Get all commands
	/// </summary>
	/// <returns></returns>
	public async Task<(List<Command?>?, string)> GetAll()
	{
		List<CommandXpo> commands = await _db.Query<CommandXpo>().ToListAsync();
		bool found = commands.Count > 0;
		List<Command?>? result = commands.ConvertAll(u => u.ToModel());
		return (result, found ? commands.Count + " commands found" : "No commands found");
	}

	/// <summary>
	/// Get the last dto on the database
	/// </summary>
	/// <returns></returns>
	public async Task<(Command?, string)> GetLast()
	{
		Command? command = await base.GetLastInsert();
		string message = command != null ? "Last command retrieved successfully" : "No command found";
		return (command, message);
	}

	/// <summary>
	/// Save command
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Save(Command model)
	{
		if (!model.IsValid())
			return (false, "Model is not valid");

		CommandXpo? entity = model.ToEntity(_db);

		if (entity is null)
			return (false, "Commands entity is null");

		await _db.SaveAsync(entity);
		await _db.CommitChangesAsync();

		(bool exists, _) = await Exists(entity.Id);

		return (exists, exists ? "Command saved successfully" : "Error saving command");
	}

	/// <summary>
	/// Duplicate command by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(Command?, string)> Duplicate(Guid key)
	{
		CommandXpo existingCommand = await _db.GetObjectByKeyAsync<CommandXpo>(key);
		if (existingCommand == null)
			return (null, "User not found");

		existingCommand.Id = Guid.NewGuid();

		await _db.SaveAsync(existingCommand);
		await _db.CommitChangesAsync();

		CommandXpo? duplicateCommand = await _db.GetObjectByKeyAsync<CommandXpo>(existingCommand.Id);
		bool found = duplicateCommand is not null;

		return (duplicateCommand?.ToModel(), found ? "Command duplicated successfully" : "Error duplicating command");
	}

	/// <summary>
	/// Delete the object by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Delete(Guid key)
	{
		CommandXpo command = await _db.GetObjectByKeyAsync<CommandXpo>(key);

		command.Delete();

		await _db.CommitChangesAsync();

		(bool exists, _) = await Exists(key);

		return (!exists, !exists ? "Command deleted successfully" : "Error deleting command");
	}

	#endregion

	#region QUERIES

	/// <summary>
	/// Devolve all command commands
	/// </summary>
	/// <param name="idUser"></param>
	/// <returns></returns>
	public async Task<(List<Command?>?, string)> GetUserCommands(Guid idUser)
	{
		(bool userexist, _) = await _userDB.Exists(idUser);
		if (!userexist)
			return (null, "User not found");

		List<Command?> commands = await _db.Query<CommandXpo>().Where(w => w.User.Id == idUser).Select(s => s.ToModel()).ToListAsync();
		return (commands, commands.Count > 0 ? commands.Count + " commands found" : "No commands found");
	}

	/// <summary>
	/// Toggle enabled state
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(bool, string)> ToggleEnabledState(Guid id)
	{
		CommandXpo? command = await _db.GetObjectByKeyAsync<CommandXpo>(id);
		if (command == null)
			return (false, "Command not found");

		command.IsEnabled = !command.IsEnabled;

		await _db.SaveAsync(command);
		await _db.CommitChangesAsync();

		return (command.IsEnabled, command.IsEnabled ? "Command is enabled" : "Command is disabled");
	}

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Save list of commands
	/// </summary>
	/// <param name="list"></param>
	/// <returns></returns>
	public async Task<(bool, string)> SaveList(List<Command> list)
	{
		bool saved = false;

		foreach (Command obj in list)
			(saved, _) = await Save(obj);

		return (saved, saved ? "Commands saved successfully" : "Error saving commands");
	}

	#endregion
}
