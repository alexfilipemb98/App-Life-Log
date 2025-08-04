using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
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
	public class CommandsQuery : DataQueryBase, IBaseQuery<CommandsEntity, CommandsModel, Guid>
	{
		#region MAIN

		//PROPERTIES
		public string TableName
		{
			get
			{
				PersistentAttribute attr = (PersistentAttribute)typeof(CommandsEntity)
					.GetCustomAttributes(typeof(PersistentAttribute), inherit: false)
					.FirstOrDefault();

				return attr?.MapTo;
			}
		}

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
		/// Ches if the command exists
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public async Task<bool> Exists(Guid key)
		{
			string sql = $"SELECT COUNT(*) FROM {TableName} WHERE Id = @Id";
			int count = await _SQL.GetValueAsync<int, object>(sql, new { Id = key });
			return count > 0;
		}

		/// <summary>
		/// Get the command by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public async Task<CommandsModel> GetByKey(Guid key)
		{
			CommandsEntity result = await _UOW.GetObjectByKeyAsync<CommandsEntity>(key);
			return result != null ? result.ToModel() : new CommandsModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public async Task<List<CommandsModel>> GetAll()
		{
			List<CommandsModel> results = await _UOW.Query<CommandsEntity>()
				.Select(s => s.ToModel())
				.ToListAsync();

			return results ?? new List<CommandsModel>();
		}

		/// <summary>
		/// Get the last command on the database
		/// </summary>
		/// <returns></returns>
		public async Task<CommandsModel> GetLast()
		{
			string sql = $"SELECT TOP 1 * FROM {TableName} ORDER BY CreatedAt DESC";
			CommandsModel command = await _SQL.GetValueAsync<CommandsModel>(sql);
			return command ?? new CommandsModel();
		}

		/// <summary>
		/// Save the notes by user
		/// </summary>
		/// <param name="model"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public async Task<bool> Save(CommandsModel model)
		{
			if (model == null)
				throw new ArgumentNullException("Notes model is null");

			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(model.IdUser);

			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			CommandsEntity commandDB = model.ToEntity(_UOW);

			if (commandDB == null)
				throw new ArgumentNullException("Command entity is null");

			//Set saving
			commandDB.Saving = true;

			await _UOW.SaveAsync(commandDB);
			await _UOW.CommitChangesAsync();

			return await Exists(model.Id);
		}

		/// <summary>
		/// Duplicates the command by key and returns the duplicated command
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<CommandsModel> Duplicate(Guid key)
		{
			CommandsEntity command = await _UOW.GetObjectByKeyAsync<CommandsEntity>(key);
			if (command == null)
				throw new ArgumentException("Command id is invalid!");

			command.Id = Guid.NewGuid();
			command.Saving = true;

			await _UOW.SaveAsync(command);
			await _UOW.CommitChangesAsync();

			return command.ToModel();
		}

		/// <summary>
		/// Deletes the command by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<bool> Delete(Guid key)
		{
			CommandsEntity command = await _UOW.GetObjectByKeyAsync<CommandsEntity>(key);

			if (command == null)
				throw new ArgumentException("Command id is invalid!");

			await _UOW.DeleteAsync(command);
			await _UOW.CommitChangesAsync();

			return !await Exists(key);
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
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			List<CommandsModel> resuls = await _UOW.Query<CommandsEntity>()
				.Where(w => w.User.Id == userDb.Id)
				.Select(s => s.ToModel())
				.ToListAsync();

			return resuls ?? new List<CommandsModel>();
		}

		#endregion
	}
}
