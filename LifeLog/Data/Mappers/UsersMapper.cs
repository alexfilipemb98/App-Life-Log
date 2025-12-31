using LifeLog.Core.Models;
using LifeLog.Data.DTOs;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Mappers;

/// <summary>
/// UsersXPO mappers.
/// </summary>
internal static class UsersMapper
{

	/// <summary>
	/// UsersXPO to LoggedUserModel mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static LoggedUserModel? ToLoggedModel(this UsersXPO xPO)
	{
		if (xPO is null) 
			return null;
		
		LoggedUserModel user = new()
		{
			Id = xPO.Id,
			Username = xPO.Username,
			Email = xPO.Email,
		};

		return user;
	}

	/// <summary>
	/// UsersXPO to UsersDTO mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static UsersDTO? ToModel(this UsersXPO xPO)
	{
		if (xPO is null)
			return null;

		UsersDTO user = new()
		{
			Id = xPO.Id,
			Username = xPO.Username,
			Email = xPO.Email,
		};

		return user;
	}
}
