using LifeLog.Core.Models;
using LifeLog.Data.Entities;
using LifeLog.Data.Xpo.Model;

namespace LifeLog.Data.Mappers;

/// <summary>
/// UserXpo mappers.
/// </summary>
internal static class UserMapper
{

	/// <summary>
	/// UserXpo to LoggedUserModel mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static LoggedUserModel? ToLoggedModel(this UserXpo xPO)
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
	/// UserXpo to User mapper.
	/// </summary>
	/// <param name="xPO"></param>
	/// <returns></returns>
	internal static User? ToModel(this UserXpo xPO)
	{
		if (xPO is null)
			return null;

		User user = new()
		{
			Id = xPO.Id,
			Username = xPO.Username,
			Email = xPO.Email,
		};

		return user;
	}
}
