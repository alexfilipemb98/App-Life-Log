using DevExpress.Xpo;
using LifeLog.Base.Models;
using LifeLog.Data.Database.Entities;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// ExternalProgramsMapper class to convert between ExternalProgramsEntity and ExternalProgramsModel.
	/// </summary>
	internal static class ExternalProgramsMapper
	{
		/// <summary>
		/// ExternalProgramsEntity to ExternalProgramsModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		internal static ExternalProgramsModel ToModel(this ExternalProgramsEntity entity)
		{
			if (entity == null) return null;

			return new ExternalProgramsModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Name = entity.Name,
				FileExtension = entity.FileExtension,
				PathToProgram = entity.PathToProgram,
				Arguments = entity.Arguments,
				IdImage = entity.Image?.Id ?? Guid.Empty,
				Icon = entity.Icon
			};
		}

		/// <summary>
		/// ExternalProgramsModel to ExternalProgramsEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		internal static ExternalProgramsEntity ToEntity(this ExternalProgramsModel model, Session session)
		{
			if (model == null) return null;

			ImagesEntity image = session.GetObjectByKey<ImagesEntity>(model.IdImage);

			ExternalProgramsEntity entity = session.GetObjectByKey<ExternalProgramsEntity>(model.Id);
			if (entity == null)
			{
				entity = new ExternalProgramsEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Name = model.Name;
			entity.FileExtension = model.FileExtension;
			entity.PathToProgram = model.PathToProgram;
			entity.Arguments = model.Arguments;
			entity.Image = image;

			return entity;
		}
	}
}
