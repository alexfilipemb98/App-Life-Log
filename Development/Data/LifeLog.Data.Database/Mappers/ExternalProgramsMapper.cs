using DevExpress.Xpo;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.ORMDataModel;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// ExternalProgramsMapper class to convert between ORM_ExternalProgramModel and ExternalProgramsModel.
	/// </summary>
	internal static class ExternalProgramsMapper
	{
		/// <summary>
		/// ORM_ExternalProgramModel to ExternalProgramsModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static ExternalProgramsModel ToModel(this ORM_ExternalProgramModel entity)
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
				Image = entity.Image.ToModel(),
				Icon = entity.Icon
			};
		}

		/// <summary>
		/// ExternalProgramsModel to ORM_ExternalProgramModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="uow"></param>
		/// <returns></returns>
		internal static ORM_ExternalProgramModel ToEntity(this ExternalProgramsModel model, UnitOfWork uow)
		{
			if (model == null) return null;

			ORM_ImagesModel image = model.Image.ToEntity(uow);

			ORM_ExternalProgramModel entity = uow.GetObjectByKey<ORM_ExternalProgramModel>(model.Id);

			if (entity == null)
			{
				entity = new ORM_ExternalProgramModel(uow);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt =  DateTime.Now;
				model.CreatedAt = entity.CreatedAt;
				model.Id = entity.Id;
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
