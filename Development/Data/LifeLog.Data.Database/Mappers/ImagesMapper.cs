using DevExpress.Xpo;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.ORMDataModel;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// ImagesMapper class to convert between ORM_ImagesModel and ImagesModel.
	/// </summary>
	internal static class ImagesMapper
	{
		/// <summary>
		/// ORM_ImagesModel to ImagesModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static ImagesModel ToModel(this ORM_ImagesModel entity)
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
			};

			return model;
		}

		/// <summary>
		/// ImagesModel to ORM_ImagesModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="db"></param>
		/// <returns></returns>
		internal static ORM_ImagesModel ToEntity(this ImagesModel model, UnitOfWork db)
		{
			if (model == null) return null;

			ORM_ImagesModel entity = db.GetObjectByKey<ORM_ImagesModel>(model.Id);
			
			if (entity == null)
			{
				entity = new ORM_ImagesModel(db);
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
