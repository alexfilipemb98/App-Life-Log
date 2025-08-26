using DevExpress.Xpo;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.ORMDataModel;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// VersionsMapper class to convert between ORM_VersionsModel and VersionsModel.
	/// </summary>
	internal static class VersionsMapper
	{
		/// <summary>
		/// ORM_VersionsModel to VersionsModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static VersionsModel ToModel(this ORM_VersionsModel entity)
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
		/// VersionsModel to ORM_VersionsModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="session"></param>
		/// <returns></returns>
		internal static ORM_VersionsModel ToEntity(this VersionsModel model, Session session)
		{
			if (model == null) return null;

			ORM_VersionsModel entity = session.GetObjectByKey<ORM_VersionsModel>(model.Id);
			if (entity == null)
			{
				entity = new ORM_VersionsModel(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.ProgramId = model.ProgramId;
			entity.Name = model.Name;
			entity.Version = model.Version;

			return entity;
		}
	}
}
