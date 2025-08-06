using DevExpress.Xpo;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Database.Models;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// ExternalProgramsMapper class to convert between ExternalProgramsEntity and ExternalProgramsModel.
	/// </summary>
	public static class ExternalProgramsMapper
	{
		/// <summary>
		/// ExternalProgramsEntity to ExternalProgramsModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static ExternalProgramsModel ToModel(this ExternalProgramsEntity entity)
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
				IdUser = entity.User?.Id ?? Guid.Empty,
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
		public static ExternalProgramsEntity ToEntity(this ExternalProgramsModel model, Session session)
		{
			if (model == null) return null;

			UsersEntity user = session.GetObjectByKey<UsersEntity>(model.IdUser);
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
			entity.User = user;
			entity.Image = image;

			return entity;
		}

		/// <summary>
		/// ExternalProgramsEntity update method to update properties from ExternalProgramsModel.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="model"></param>
		/// <param name="user"></param>
		/// <param name="image"></param>
		public static void UpdateEntity(this ExternalProgramsEntity entity, ExternalProgramsModel model, UsersEntity user, ImagesEntity image)
		{
			if (entity == null || model == null) return;

			entity.Name = model.Name;
			entity.FileExtension = model.FileExtension;
			entity.PathToProgram = model.PathToProgram;
			entity.Arguments = model.Arguments;
			entity.User = user;
			entity.Image = image;
		}
	}
}
