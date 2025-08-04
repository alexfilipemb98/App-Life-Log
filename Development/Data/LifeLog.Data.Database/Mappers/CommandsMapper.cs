using DevExpress.Xpo;
using LifeLog.Base.Models;
using LifeLog.Data.Database.Entities;
using System;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// CommandsMapper class to convert between CommandsEntity and CommandsModel.
	/// </summary>
	internal static class CommandsMapper
	{
		/// <summary>
		/// CommandsEntity to CommandsModel mapper.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		internal static CommandsModel ToModel(this CommandsEntity entity)
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
				IdUser = entity.User?.Id ?? Guid.Empty,
				IdExternalProgram = entity.ExternalProgram?.Id ?? Guid.Empty,
				IdImage = entity.ExternalProgram?.IdImage ?? Guid.Empty,
				Icon = entity.Icon,
				EditingMode = entity.Id != Guid.Empty
			};
		}

		/// <summary>
		/// CommandsModel to CommandsEntity mapper.
		/// </summary>
		/// <param name="model"></param>
		/// <param name="session"></param>
		/// <returns></returns>
		internal static CommandsEntity ToEntity(this CommandsModel model, UnitOfWork session)
		{
			if (model == null) return null;

			UsersEntity user = session.GetObjectByKey<UsersEntity>(model.IdUser);
			ExternalProgramsEntity program = session.GetObjectByKey<ExternalProgramsEntity>(model.IdExternalProgram);

			CommandsEntity entity = session.GetObjectByKey<CommandsEntity>(model.Id);
			
			if (entity == null)
			{
				entity = new CommandsEntity(session);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
			}

			entity.UpdatedAt = model.UpdatedAt;
			entity.Name = model.Name;
			entity.Description = model.Description;
			entity.Command = model.Command;
			entity.IsEnabled = model.IsEnabled;
			entity.User = user;
			entity.ExternalProgram = program;
			entity.EditingMode = model.EditingMode;

			return entity;
		}
	}
}
