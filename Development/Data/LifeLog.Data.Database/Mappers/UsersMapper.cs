using DevExpress.Xpo;
using LifeLog.Data.Database.Entities;
using LifeLog.Base.Models;
using System;

namespace LifeLog.Data.Mappers
{
	/// <summary>
	/// User mapper class to convert between UsersEntity and UsersModel.
	/// </summary>
	internal static class UsersMapper
	{
		/// <summary>
		/// UsesEntity to UsersModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		internal static UsersModel ToModel(this UsersEntity entity)
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
		/// UsersModel to UsersEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		internal static UsersEntity ToEntity(this UsersModel model, Session session)
		{
			if (model == null) return null;

			UsersEntity entity = session.GetObjectByKey<UsersEntity>(model.Id);
			if (entity == null)
			{
				entity = new UsersEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
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
