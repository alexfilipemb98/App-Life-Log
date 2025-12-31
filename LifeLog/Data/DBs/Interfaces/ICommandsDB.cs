using LifeLog.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;
public interface ICommandsDB
{
	Task<bool> Delete(Guid? id);
	Task<List<CommandsDTO>> GetUserCommands(Guid id);
	Task<bool> Save(CommandsDTO crtCommands);
	Task<bool> SaveList(List<CommandsDTO> commandsJson);
	Task<bool> ToggleEnabledState(Guid? id);
}
