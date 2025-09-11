using DevExpress.Xpo;
using LifeLog.Base.Models;
using LifeLog.Base.Models.Data;
using LifeLog.Base.Utils;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Users data query
	/// </summary>
	public class UsersQuery : DataQueryBase<UsersModel, Guid>
	{
		#region BASE

		/// <summary>
		/// Get all users
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<UsersModel>, string)> GetAll()
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				List<UsersModel> results = await db.Query<ORM_UsersModel>()
				   .Select(s => s.ToModel())
				   .ToListAsync() ?? new List<UsersModel>();

				string message = results.Count > 0 ? $"Users retrieved successfully, {results.Count} found." : "No users found.";
				return (results, message);
			}
		}

		#endregion

		#region AUTH

		/// <summary>
		/// This is the register method
		/// </summary>
		/// <param fName="model"></param>
		/// <returns></returns>
		public async Task<(bool, string)> RegisterUser(AuthModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				bool emailExits = await db.Query<ORM_UsersModel>().AnyAsync(w => w.Email == model.Email);

				if (emailExits)
					return (false, "Email already exists.");

				ORM_UsersModel newUser = new ORM_UsersModel(db)
				{
					Id = Guid.NewGuid(),
					Username = model.Username,
					Email = model.Email,
					Salt = SecurityUtil.GenerateSalt(),
					CreatedAt = DateTime.Now,
					UpdatedAt = DateTime.Now,
				};

				newUser.Password = SecurityUtil.Sha512_EncryptPasswordWithSalt(model.Password, newUser.Salt);

				await db.SaveAsync(newUser);
				await db.CommitChangesAsync();

				emailExits = await db.Query<ORM_UsersModel>().AnyAsync(w => w.Email == model.Email);

				return (emailExits, emailExits ? "User registered successfully." : "Failed to create the user!");
			}
		}

		/// <summary>
		/// Validate user login
		/// </summary>
		/// <param fName="email"></param>
		/// <param fName="password"></param>
		/// <returns></returns>
		public async Task<(bool, string, LoggedUserModel)> ValidateUserLogin(AuthModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				if (!model.ValidateModel(out List<ValidationResult> results))
					throw new LifeLog.Base.Infrastructure.Exceptions.ValidationException(results);

				if (!model.Email.IsValidEmail())
					return (false, "E-mail is not Valid!", null);

				ORM_UsersModel user = await db.Query<ORM_UsersModel>().FirstOrDefaultAsync(w => w.Email == model.Email);

				if (user == null)
					return (false, "User not found!", null);

				if (!SecurityUtil.CompareStringEncryptedWithSalt(model.Password, user.Password, user.Salt))
					return (false, "Login failed, password is incorrect!", null);

				LoggedUserModel loggedUser = new LoggedUserModel();
				loggedUser.Id = user.Id;
				loggedUser.Username = user.Username;
				loggedUser.Email = user.Email;

				return (user != null, "User is valid to login!", loggedUser);
			}
		}

		#endregion
	}
}
