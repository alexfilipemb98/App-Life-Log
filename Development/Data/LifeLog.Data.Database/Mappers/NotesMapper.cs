using DevExpress.Xpo;
using LifeLog.Data.Models;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Mappers;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// NotesMapper class to convert between ORM_NotesModel and NotesModel.
	/// </summary>
	internal static class NotesMapper
	{
		/// <summary>
		/// ORM_NotesModel to NotesModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static NotesModel ToModel(this ORM_NotesModel entity)
		{
			if (entity == null) return null;

			return new NotesModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Title = entity.Title,
				Text = entity.Text,
				Color = entity.Color,
				Position = entity.Position,
				User = entity.User.ToLoggedInModel()
			};
		}

		/// <summary>
		/// NotesModel to ORM_NotesModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="db"></param>
		/// <returns></returns>
		internal static ORM_NotesModel ToEntity(this NotesModel model, UnitOfWork db)
		{
			if (model == null) return null;

			ORM_UsersModel user = db.GetObjectByKey<ORM_UsersModel>(model.User.Id);
			ORM_NotesModel entity = db.GetObjectByKey<ORM_NotesModel>(model.Id);

			if (entity == null)
			{
				entity = new ORM_NotesModel(db);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Title = model.Title;
			entity.Text = model.Text;
			entity.Color = model.Color;
			entity.Position = model.Position;
			entity.User = user;

			return entity;
		}
	}
}
