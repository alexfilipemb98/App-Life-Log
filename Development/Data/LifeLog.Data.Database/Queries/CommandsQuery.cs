using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Database.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Commands data query
	/// </summary>
	public class CommandsQuery : DataQueryBase<CommandsModel, Guid>
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param fName="uow"></param>
		/// <param fName="sql"></param>
		public CommandsQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
		{
		}
		 
		#endregion

		#region BASE

		/// <summary>
		/// Get the entity by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(CommandsModel,string)> GetByKey(Guid key)
		{
			CommandsEntity result = await _UOW.GetObjectByKeyAsync<CommandsEntity>(key);
			CommandsModel model = result != null ? result.ToModel() : new CommandsModel();
			string message = result != null ? "Command retrieved successfully." : "Command not found.";
			return (model, message);
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<CommandsModel>, string)> GetAll()
		{
			List<CommandsModel> results = await _UOW.Query<CommandsEntity>()
				.Select(s => s.ToModel())
				.ToListAsync() ?? new List<CommandsModel>();

			string message = results.Count > 0 ? $"Commands retrieved successfully, {results.Count} found." : "No commands found.";
			return (results, message);
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
			await base.Save(model);

			CommandsEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Command entity is null");

			if (entity.User == null)
				throw new ArgumentException("User id is invalid!");

			//Set saving
			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();
			(bool saved, _) = await Exists(model.Id);
			string message = saved ? "Command saved successfully." : "Command not found after saving.";

			return (saved, message);
		}

		/// <summary>
		/// Duplicates the entity by key and returns the duplicated entity
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(CommandsModel, string)> Duplicate(Guid key)
		{
			(CommandsModel model, _) = await base.Duplicate(key);
			CommandsEntity entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			entity.Name += " (Copy)";
			model.Id = entity.Id;
			model.Name = entity.Name;
			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			(bool saved, _) = await Exists(model.Id);
			string message = saved ? "Command duplicated successfully." : "Command not found after duplication.";
			return (model, message);
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param fName="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(List<CommandsModel>,string)> GetUserCommands(Guid userId)
		{
			UsersEntity userEntity = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userEntity == null)
				throw new ArgumentException("User id is invalid!");

			List<CommandsModel> results = await _UOW.Query<CommandsEntity>()
				.Where(w => w.User.Id == userEntity.Id)
				.Select(s => s.ToModel())
				.ToListAsync() ?? new List<CommandsModel>();

			string message = results.Count > 0 ? $"Commands retrieved successfully, {results.Count} found." : "No commands found.";

			return (results, message);
		}

		#endregion
	}
}
