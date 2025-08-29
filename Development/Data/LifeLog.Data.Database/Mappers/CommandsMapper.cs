using DevExpress.Xpo;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Mappers;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// CommandsMapper class to convert between ORM_CommandsModel and CommandsModel.
	/// </summary>
	internal static class CommandsMapper
	{
		/// <summary>
		/// ORM_CommandsModel to CommandsModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static CommandsModel ToModel(this ORM_CommandsModel entity)
		{
			if (entity == null) return null;

			return new CommandsModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Name = entity.Name,
				Description = entity.Description,
				Command = entity.Command,
				IsEnabled = entity.IsEnabled,
				User = entity.User.ToLoggedInModel(),
				NeedsAdmin = entity.NeedsAdmin,
				ExternalProgram = entity.ExternalProgram.ToModel(),
				Icon = entity.Icon,
			};
		}

		/// <summary>
		/// CommandsModel to ORM_CommandsModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="db"></param>
		/// <returns></returns>
		internal static ORM_CommandsModel ToEntity(this CommandsModel model, UnitOfWork db)
		{
			if (model is null) return null;

			ORM_UsersModel user = db.GetObjectByKey<ORM_UsersModel>(model.User.Id);

			if (user is null)
				throw new ArgumentNullException("User not found!");

			ORM_ExternalProgramModel program = null;

			if (model.ExternalProgram != null)
			{
				program = db.GetObjectByKey<ORM_ExternalProgramModel>(model.ExternalProgram.Id);

				if (program is null)
					throw new ArgumentNullException("External program not found!");

			}

			ORM_CommandsModel entity = db.GetObjectByKey<ORM_CommandsModel>(model.Id);

			if (entity == null)
			{
				entity = new ORM_CommandsModel(db);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Name = model.Name;
			entity.Description = model.Description;
			entity.Command = model.Command;
			entity.IsEnabled = model.IsEnabled;
			entity.User = user;
			entity.ExternalProgram = program;
			entity.NeedsAdmin = model.NeedsAdmin;

			return entity;
		}
	}
}
