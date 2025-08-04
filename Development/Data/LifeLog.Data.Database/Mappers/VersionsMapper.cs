using DevExpress.Xpo;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Database.Models;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// VersionsMapper class to convert between VersionsEntity and VersionsModel.
	/// </summary>
	public static class VersionsMapper
	{
		/// <summary>
		/// VersionsEntity to VersionsModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static VersionsModel ToModel(this VersionsEntity entity)
		{
			if (entity == null) return null;

			return new VersionsModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				ProgramId = entity.ProgramId,
				Name = entity.Name,
				Version = entity.Version
			};
		}

		/// <summary>
		/// VersionsModel to VersionsEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		public static VersionsEntity ToEntity(this VersionsModel model, Session session)
		{
			if (model == null) return null;

			VersionsEntity entity = session.GetObjectByKey<VersionsEntity>(model.Id);
			if (entity == null)
			{
				entity = new VersionsEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.ProgramId = model.ProgramId;
			entity.Name = model.Name;
			entity.Version = model.Version;

			return entity;
		}
	}
}
