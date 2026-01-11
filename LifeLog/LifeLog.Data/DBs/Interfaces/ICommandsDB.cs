using LifeLog.Data.Bases;
using LifeLog.Data.DTOs;

namespace LifeLog.Data.DBs.Interfaces;

/// <summary>
/// Commands DB Interface
/// </summary>
public interface ICommandsDB : IBaseDB<CommandsDTO>
{
	#region QUERIES

	/// <summary>
	/// Devolve all user commands
	/// </summary>
	/// <param name="idUser"></param>
	/// <returns></returns>
	Task<(List<CommandsDTO?>?, string)> GetUserCommands(Guid idUser);

	/// <summary>
	/// Toggle enabled state
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	Task<(bool, string)> ToggleEnabledState(Guid id);

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Save list of commands
	/// </summary>
	/// <param name="commands"></param>
	/// <returns></returns>
	Task<(bool, string)> SaveList(List<CommandsDTO> commands);

	#endregion
}
