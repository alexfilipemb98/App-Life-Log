using DevExpress.Xpo;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs;

public class CommandsDB : ICommandsDB
{
	private IUsersDB _userDB;
	private IExternalProgramsDB _externalProgramsDB;
	private UnitOfWork _db;

	public CommandsDB(IUsersDB usersDB, IExternalProgramsDB externalProgramsDB, UnitOfWork db)
	{
		_userDB = usersDB;
		_externalProgramsDB = externalProgramsDB;
		_db = db;
	}

	public Task<bool> Delete(Guid? id)
	{
		throw new NotImplementedException();
	}

	public Task<List<CommandsDTO>> GetUserCommands(Guid id)
	{
		throw new NotImplementedException();
	}

	public Task<bool> Save(CommandsDTO crtCommands)
	{
		throw new NotImplementedException();
	}

	public Task<bool> SaveList(List<CommandsDTO> commandsJson)
	{
		throw new NotImplementedException();
	}

	public Task<bool> ToggleEnabledState(Guid? id)
	{
		throw new NotImplementedException();
	}
}
