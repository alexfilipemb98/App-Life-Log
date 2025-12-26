using Core.Models;
using Data.DTOs;
using Data.XPO.ORMDataModelCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappers;

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
