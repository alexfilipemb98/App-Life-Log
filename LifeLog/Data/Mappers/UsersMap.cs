using LifeLog.Core.Models;
using LifeLog.Data.DTOs;
using LifeLog.Data.XPO.ORMDataModelCode;

namespace LifeLog.Data.Mappers;

internal static class UsersMap
{
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
