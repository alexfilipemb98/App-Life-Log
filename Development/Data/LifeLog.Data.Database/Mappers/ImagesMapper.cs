using DevExpress.Xpo;
using LifeLog.Data.Database.Entities;
using LifeLog.Base.Models;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// ImagesMapper class to convert between ImagesEntity and ImagesModel.
	/// </summary>
	internal static class ImagesMapper
	{
		/// <summary>
		/// ImagesEntity to ImagesModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		internal static ImagesModel ToModel(this ImagesEntity entity)
		{
			if (entity == null) return null;

			ImagesModel model = new ImagesModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Name = entity.Name,
				Data = entity.Data,
				FileExtension = entity.FileExtension,
				IdUser = entity.User?.Id ?? Guid.Empty,
			};

			return model;
		}

		/// <summary>
		/// ImagesModel to ImagesEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		internal static ImagesEntity ToEntity(this ImagesModel model, Session session)
		{
			if (model == null) return null;

			ImagesEntity entity = session.GetObjectByKey<ImagesEntity>(model.Id);
			
			if (entity == null)
			{
				entity = new ImagesEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				model.Id = entity.Id;
				entity.CreatedAt = model.CreatedAt;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Name = model.Name;
			entity.Data = model.Data;
			entity.FileExtension = model.FileExtension;

			return entity;
		}
	}

}
