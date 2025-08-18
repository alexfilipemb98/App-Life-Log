using DevExpress.Xpo;
using LifeLog.Base.Models;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Mappers;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// NotesMapper class to convert between NotesEntity and NotesModel.
	/// </summary>
	internal static class NotesMapper
	{
		/// <summary>
		/// NotesEntity to NotesModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		internal static NotesModel ToModel(this NotesEntity entity)
		{
			if (entity == null) return null;

			return new NotesModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Title = entity.Title,
				Text = entity.Text,
				User = entity.User.ToLoggedInModel()
			};
		}

		/// <summary>
		/// NotesModel to NotesEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		internal static NotesEntity ToEntity(this NotesModel model, Session session)
		{
			if (model == null) return null;

			UsersEntity user = session.GetObjectByKey<UsersEntity>(model.User.Id);
			NotesEntity entity = session.GetObjectByKey<NotesEntity>(model.Id);

			if (entity == null)
			{
				entity = new NotesEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Title = model.Title;
			entity.Text = model.Text;
			entity.User = user;

			return entity;
		}
	}
}
