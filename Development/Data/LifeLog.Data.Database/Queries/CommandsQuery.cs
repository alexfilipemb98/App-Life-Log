using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
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
	public class CommandsQuery : DataQueryBase<CommandsEntity, CommandsModel, Guid>
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public CommandsQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
		{
		}

		#endregion

		#region BASE

		/// <summary>
		/// Get the entity by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<CommandsModel> GetByKey(Guid key)
		{
			CommandsEntity result = await _UOW.GetObjectByKeyAsync<CommandsEntity>(key);
			return result != null ? result.ToModel() : new CommandsModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<List<CommandsModel>> GetAll()
		{
			List<CommandsModel> results = await _UOW.Query<CommandsEntity>()
				.Select(s => s.ToModel())
				.ToListAsync();

			return results ?? new List<CommandsModel>();
		}

		/// <summary>
		/// Save the notes by user
		/// </summary>
		/// <param name="model"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<bool> Save(CommandsModel model)
		{
			bool isvalid = await base.Save(model);

			CommandsEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Command entity is null");

			if (entity.User == null)
				throw new ArgumentException("User id is invalid!");

			//Set saving
			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			return await Exists(model.Id);
		}

		/// <summary>
		/// Duplicates the entity by key and returns the duplicated entity
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<CommandsModel> Duplicate(Guid key)
		{
			CommandsModel model = await base.Duplicate(key);
			CommandsEntity entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			return model;
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<CommandsModel>> GetUserCommands(Guid userId)
		{
			UsersEntity userEntity = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userEntity == null)
				throw new ArgumentException("User id is invalid!");

			List<CommandsModel> resuls = await _UOW.Query<CommandsEntity>()
				.Where(w => w.User.Id == userEntity.Id)
				.Select(s => s.ToModel())
				.ToListAsync();

			return resuls ?? new List<CommandsModel>();
		}

		#endregion
	}
}
