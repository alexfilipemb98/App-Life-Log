using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using DevExpress.Xpo;
using LifeLog.Data.Bases;
using LifeLog.Data.Helpers;

namespace LifeLog.Data.DBs;

/// <summary>
/// Users database operations
/// </summary>
public class UsersDB : BaseDB<UsersDTO>, IUsersDB
{
	#region MAIN

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="db"></param>
	/// <param name="sql"></param>
	public UsersDB(UnitOfWork db, SqlDataAccessHelper sql) : base(db, sql)
	{
	}

	#endregion

	#region BASE

	/// <summary>
	/// Exists user by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Exists(Guid key)
	{
		bool exists = await _db.Query<UsersXPO>().AnyAsync(w => w.Id == key);
		return (exists, exists ? "User exists" : "User does not exist");
	}

	/// <summary>
	/// Get user by key
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public async Task<(UsersDTO?, string)> GetByKey(Guid id)
	{
		UsersXPO? user;
		user = await _db.GetObjectByKeyAsync<UsersXPO>(id);
		bool found = user is not null;
		return (user?.ToModel(), found ? "User found" : "User not found");
	}

	/// <summary>
	/// Get all users
	/// </summary>
	/// <returns></returns>
	public async Task<(List<UsersDTO?>?, string)> GetAll()
	{
		List<UsersXPO> users = await _db.Query<UsersXPO>().ToListAsync();
		bool found = users.Count > 0;
		List<UsersDTO?>? result = users.ConvertAll(u => u.ToModel());
		return (result, found ? users.Count + " users found" : "No users found");
	}

	/// <summary>
	/// Get the last dto on the database
	/// </summary>
	/// <returns></returns>
	public async Task<(UsersDTO?, string)> GetLast()
	{
		UsersDTO? user = await base.GetLastInsert();
		string message = user != null ? "Last user retrieved successfully" : "No user found";
		return (user, message);
	}

	/// <summary>
	/// Save user
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Save(UsersDTO model)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Duplicate user by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(UsersDTO?, string)> Duplicate(Guid key)
	{
		UsersXPO existingUser = await _db.GetObjectByKeyAsync<UsersXPO>(key);
		if (existingUser == null)
			return (null, "User not found");
		existingUser.Id = Guid.NewGuid();
		
		await _db.SaveAsync(existingUser);
		await _db.CommitChangesAsync();

		UsersXPO? duplicateUser = await _db.GetObjectByKeyAsync<UsersXPO>(existingUser.Id);
		bool found = duplicateUser is not null;

		return (duplicateUser?.ToModel(), found ? "User duplicated successfully" : "Error duplicating user");
	}

	/// <summary>
	/// Delete the object by key
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	public async Task<(bool, string)> Delete(Guid key)
	{
		throw new NotImplementedException();
	}

	#endregion

	#region AUTH

	/// <summary>
	/// Register user 
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<(bool, string)> RegisterUser(string username, string email, string password)
	{
		if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
			return (false, "Inválid user to register");

		UsersXPO? user;
		user = await GetUserByEmailHelper(email);

		if (user != null)
			return (false, "Email already in use");

		UsersXPO newUser = new UsersXPO(_db)
		{
			Id = Guid.NewGuid(),
			Username = username,
			Email = email,
			Salt = SecurityUtil.GenerateSalt(),
		};

		newUser.Password = SecurityUtil.Sha512_EncryptPasswordWithSalt(password!, newUser.Salt);

		await _db.SaveAsync(newUser);
		await _db.CommitChangesAsync();

		(bool exists, _) = await Exists(newUser.Id);

		return exists ? (true, "User registered successfully") : (false, "Error registering user");
	}

	/// <summary>
	/// Login user
	/// </summary>
	/// <param name="email"></param>
	/// <param name="password"></param>
	/// <returns></returns>
	public async Task<(bool, LoggedUserModel?, string)> Login(string email, string password)
	{
		UsersXPO? user;
		user = await GetUserByEmailHelper(email);

		if (user is null)
			return (false, null, "User not found");

		if (!SecurityUtil.CompareStringEncryptedWithSalt(password, user.Password, user.Salt))
			return (false, null, "Invalid credentials");

		return (true, user.ToLoggedModel(), "Login successful");
	}

	#endregion

	#region QUERIES

	/// <summary>
	/// Get user by email
	/// </summary>
	/// <param name="email"></param>
	/// <returns></returns>
	public async Task<(UsersDTO?, string)> UserByEmail(string email)
	{
		UsersXPO? user;
		user = await GetUserByEmailHelper(email);
		bool found = user is not null;
		return (user?.ToModel(), found ? "User found" : "User not found");
	}

	#endregion

	#region FUNCTIONS

	/// <summary>
	/// Helper to the the use by email
	/// </summary>
	/// <param name="db"></param>
	/// <param name="email"></param>
	/// <returns></returns>
	private async Task<UsersXPO?> GetUserByEmailHelper(string email)
	{
		UsersXPO? user = await _db.Query<UsersXPO>().FirstOrDefaultAsync(w => w.Email == email);

		return user;
	}

	#endregion
}
