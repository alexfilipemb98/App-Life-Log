using LifeLog.Core.Models;
using LifeLog.Data.Bases;
using LifeLog.Data.DTOs;

namespace LifeLog.Data.DBs.Interfaces;

/// <summary>
/// Users DB Interface
/// </summary>
public interface IUsersDB : IBaseDB<UsersDTO>
{
	#region AUTH

	/// <summary>
	/// Register user
	/// </summary>
	/// <param name="username"></param>
	/// <param name="email"></param>
	/// <param name="password"></param>
	/// <returns></returns>
	Task<(bool, string)> RegisterUser(string username, string email, string password);

	/// <summary>
	/// Login user
	/// </summary>
	/// <param name="email"></param>
	/// <param name="password"></param>
	/// <returns></returns>
	Task<(bool, LoggedUserModel?, string)> Login(string email, string password);

	#endregion

	#region QUERIES

	/// <summary>
	/// Gets user by email
	/// </summary>
	/// <param name="email"></param>
	/// <returns></returns>
	Task<(UsersDTO?, string)> UserByEmail(string email);

	#endregion
}
