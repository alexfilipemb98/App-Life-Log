using Core.Models;
using Data.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBs.Interfaces;

public interface IUsersDB
{
	Task<bool> RegisterUser(string username, string email, string password);

	Task<LoggedUserModel?> Login(string email, string password);

	Task<UsersDTO?> UserById(Guid id);

	Task<UsersDTO?> UserByEmail(string email);

}
