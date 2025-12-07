using DevExpress.Xpo;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Tasks data query
	/// </summary>
	public sealed class TasksQuery : DataQueryBase<TasksModel>
	{
		#region BASE

		/// <summary>
		/// Get the note by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<(TasksModel, string)> GetByKey(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_TasksModel result = await db.GetObjectByKeyAsync<ORM_TasksModel>(key);
				TasksModel model = result != null ? result.ToModel() : new TasksModel();
				string message = result != null ? "Task retrieved successfully." : "Task not found.";
				return (model, message);
			}
		}

		/// <summary>
		/// Save the tasks
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public override async Task<(bool, string)> Save(TasksModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				await base.Save(model);

				return await SaveHelper(model, db);
			}
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users tasks
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(List<TasksModel>, string)> GetUserTasks(Guid userId)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_UsersModel userDb = await db.GetObjectByKeyAsync<ORM_UsersModel>(userId);
				if (userDb == null)
					throw new ArgumentException("User id is invalid!");

				List<TasksModel> results = await db.Query<ORM_TasksModel>()
					.Where(w => w.User.Id == userDb.Id)
					.Select(s => s.ToModel())
					.ToListAsync() ?? new List<TasksModel>();

				string message = results.Count > 0 ? $"Tasks retrieved successfully, {results.Count} found." : "No tasks found for the user.";
				return (results, message);
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Save helper
		/// </summary>
		/// <param name="model"></param>
		/// <param name="db"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		private async Task<(bool, string)> SaveHelper(TasksModel model, UnitOfWork db)
		{
			ORM_TasksModel entity = model.ToEntity(db);

			if (entity == null)
				throw new ArgumentNullException("Tasks entity is null");

			await db.SaveAsync(entity);
			await db.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Task saved successfully." : "Task not found after saving.";

			return (exists, message);
		}

		#endregion
	}
}
