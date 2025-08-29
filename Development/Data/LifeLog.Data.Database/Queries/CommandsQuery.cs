using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.CannotLoadObjectsHelper;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Commands data query
	/// </summary>
	public class CommandsQuery : DataQueryBase<CommandsModel, Guid>
	{
		#region BASE

		/// <summary>
		/// Get the entity by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(CommandsModel, string)> GetByKey(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_CommandsModel result = await db.GetObjectByKeyAsync<ORM_CommandsModel>(key);
				CommandsModel model = result != null ? result.ToModel() : new CommandsModel();
				string message = result != null ? "Command retrieved successfully." : "Command not found.";
				return (model, message);
			}
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<CommandsModel>, string)> GetAll()
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				List<CommandsModel> results = await db.Query<ORM_CommandsModel>()
				.Select(s => s.ToModel())
				.ToListAsync() ?? new List<CommandsModel>();

				string message = results.Count > 0 ? $"Commands retrieved successfully, {results.Count} found." : "No commands found.";
				return (results, message);
			}
		}

		/// <summary>
		/// Save the notes by user
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(bool, string)> Save(CommandsModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				return await SaveHelper(model, db);
			}
		}

		/// <summary>
		/// Duplicates the entity by key and returns the duplicated entity
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(CommandsModel, string)> Duplicate(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				(CommandsModel model, _) = await base.Duplicate(key);
				ORM_CommandsModel entity = model.ToEntity(db);

				entity.Id = Guid.NewGuid();
				entity.Name += " (Copy)";
				model.Id = entity.Id;
				model.Name = entity.Name;

				await db.SaveAsync(model);
				await db.CommitChangesAsync();

				(bool saved, _) = await Exists(model.Id);
				string message = saved ? "Command duplicated successfully." : "Command not found after duplication.";
				return (model, message);
			}
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param fName="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(List<CommandsModel>, string)> GetUserCommands(Guid userId)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_UsersModel userEntity = await db.GetObjectByKeyAsync<ORM_UsersModel>(userId);
				if (userEntity == null)
					throw new ArgumentException("User id is invalid!");

				List<CommandsModel> results = await db.Query<ORM_CommandsModel>()
					.Where(w => w.User.Id == userEntity.Id)
					.Select(s => s.ToModel())
					.ToListAsync() ?? new List<CommandsModel>();

				string message = results.Count > 0 ? $"Commands retrieved successfully, {results.Count} found." : "No commands found.";

				return (results, message);
			}
		}

		/// <summary>
		/// Toggles the enabled state
		/// </summary>
		/// <param name="commandId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(bool, string)> ToggleEnabledState(Guid commandId)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_CommandsModel commad = await db.GetObjectByKeyAsync<ORM_CommandsModel>(commandId);

				if (commad == null)
					throw new ArgumentException("Command id is invalid!");

				commad.IsEnabled = !commad.IsEnabled;

				await db.SaveAsync(commad);
				await db.CommitChangesAsync();

				string message = commad.IsEnabled ? "Command enabled!" : "Command disabled!";

				return (commad.IsEnabled, message);
			}
		}

		/// <summary>
		/// Save commands by a list
		/// </summary>
		/// <param name="commands"></param>
		/// <returns></returns>
		public async Task<(bool, string)> SaveList(List<CommandsModel> commands)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				bool saved = false;

				foreach (CommandsModel model in commands)
				{
					(saved, _) = await SaveHelper(model, db);
				}

				string message = saved ? "Commands list saved successfully." : "Failed to save commands list.";

				return (saved, message);
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Helper to save commands
		/// </summary>
		/// <param name="model"></param>
		/// <param name="db"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		private async Task<(bool, string)> SaveHelper(CommandsModel model, UnitOfWork db)
		{
			await base.Save(model);

			ORM_CommandsModel entity = model.ToEntity(db);

			if (entity == null)
				throw new ArgumentNullException("Command entity is null");

			if (entity.User == null)
				throw new ArgumentException("User id is invalid!");

			await db.SaveAsync(entity);
			await db.CommitChangesAsync();

			(bool saved, _) = await Exists(model.Id);
			string message = saved ? "Command saved successfully." : "Command not found after saving.";

			return (saved, message);
		}

		#endregion
	}
}
