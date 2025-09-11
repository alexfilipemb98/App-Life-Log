using DevExpress.Xpo;
using LifeLog.Base.Models;
using LifeLog.Data.Models;
using LifeLog.Data.Database.ORMDataModel;
using System;

namespace LifeLog.Data.Mappers
{
	/// <summary>
	/// User mapper class to convert between ORM_UsersModel and UsersModel.
	/// </summary>
	internal static class UsersMapper
	{
		/// <summary>
		/// UsesEntity to UsersModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static UsersModel ToModel(this ORM_UsersModel entity)
		{
			if (entity == null) return null;

			return new UsersModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Username = entity.Username,
				Email = entity.Email,
				Salt = entity.Salt,
				Password = entity.Password
			};
		}

		/// <summary>
		/// UsesEntity to LoggedUserModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static LoggedUserModel ToLoggedInModel(this ORM_UsersModel entity)
		{
			if (entity == null) return null;

			return new LoggedUserModel
			{
				Id = entity.Id,
				Username = entity.Username,
				Email = entity.Email,
			};
		}

		/// <summary>
		/// UsersModel to ORM_UsersModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="db"></param>
		/// <returns></returns>
		internal static ORM_UsersModel ToEntity(this UsersModel model, UnitOfWork db)
		{
			if (model == null) return null;

			ORM_UsersModel entity = db.GetObjectByKey<ORM_UsersModel>(model.Id);

			if (entity == null)
			{
				entity = new ORM_UsersModel(db);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Username = model.Username;
			entity.Email = model.Email;
			entity.Salt = model.Salt;
			entity.Password = model.Password;

			return entity;
		}
	}
}
