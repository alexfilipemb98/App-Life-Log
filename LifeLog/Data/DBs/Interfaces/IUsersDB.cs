using LifeLog.Core.Models;
using LifeLog.Data.DTOs;

namespace LifeLog.Data.DBs.Interfaces;

public interface IUsersDB
{
	Task<bool> RegisterUser(string username, string email, string password);

	Task<LoggedUserModel?> Login(string email, string password);

	Task<UsersDTO?> UserById(Guid id);

	Task<UsersDTO?> UserByEmail(string email);

}
