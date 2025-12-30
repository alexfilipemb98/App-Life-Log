using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.DBs.Interfaces;
using LifeLog.Data.DTOs;
using LifeLog.Data.Mappers;
using LifeLog.Data.XPO.ORMDataModelCode;
using DevExpress.Xpo;

namespace LifeLog.Data.DBs;

internal class UsersDB : IUsersDB
{
	//PRIVATE
	private UnitOfWork _db;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="db"></param>
	public UsersDB(UnitOfWork db)
	{
		_db = db;
	}

	#region AUTH

	/// <summary>
	/// Register user 
	/// </summary>
	/// <param name="model"></param>
	/// <returns></returns>
	public async Task<bool> RegisterUser(string username, string email, string password)
	{
		if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
			throw new ArgumentNullException("Inválid user to register");

		UsersXPO? user;
		user = await GetUserByEmailHelper(email);

		if (user != null)
			throw new ArgumentException("Email already in use");

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

		return true;
	}

	/// <summary>
	/// Login user
	/// </summary>
	/// <param name="email"></param>
	/// <param name="password"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException"></exception>
	public async Task<LoggedUserModel?> Login(string email, string password)
	{
		UsersXPO? user;
		user = await GetUserByEmailHelper(email);

		if (user is null)
			throw new ArgumentException("User not found");

		if (!SecurityUtil.CompareStringEncryptedWithSalt(password, user.Password, user.Salt))
			return null;

		return user.ToLoggedModel();
	}

	#endregion

	#region QUERIES

	public async Task<UsersDTO?> UserById(Guid id)
	{
		UsersXPO? user;
		user = await _db.FindObjectAsync<UsersXPO>(id);
		return user.ToModel();
	}

	public async Task<UsersDTO?> UserByEmail(string email)
	{
		UsersXPO? user;
		user = await GetUserByEmailHelper(email);
		return user!.ToModel();
	}

	public async Task<bool> UserExistsById(Guid id)
	{
		return await _db.Query<UsersXPO>().AnyAsync(w => w.Id == id);
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
