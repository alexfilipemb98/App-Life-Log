using DevExpress.Xpo;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Mappers
{
	/// <summary>
	/// Tasks mapper
	/// </summary>
	internal static class TasksMapper
	{
		/// <summary>
		/// ORM_TasksModel to TasksModel mapper.
		/// </summary>
		/// <param fName="entity"></param>
		/// <returns></returns>
		internal static TasksModel ToModel(this ORM_TasksModel entity)
		{
			if (entity == null) return null;

			return new TasksModel
			{
				Id = entity.Id,
				CreatedAt = entity.CreatedAt,
				UpdatedAt = entity.UpdatedAt,
				Description = entity.Description,
				IsDone = entity.IsDone	
			};
		}

		/// <summary>
		/// TasksModel to ORM_TasksModel mapper.
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="db"></param>
		/// <returns></returns>
		internal static ORM_TasksModel ToEntity(this TasksModel model, UnitOfWork db)
		{
			if (model == null) return null;

			ORM_UsersModel user = db.GetObjectByKey<ORM_UsersModel>(model.User.Id);
			ORM_TasksModel entity = db.GetObjectByKey<ORM_TasksModel>(model.Id);

			if (entity == null)
			{
				entity = new ORM_TasksModel(db);
				entity.Id = model.Id != Guid.Empty ? model.Id : Guid.NewGuid();
				entity.CreatedAt = model.CreatedAt;
				model.Id = entity.Id;
			}

			entity.User = user;
			entity.UpdatedAt = model.UpdatedAt;
			entity.Description = model.Description;
			entity.IsDone = model.IsDone;

			return entity;
		}
	}
}
