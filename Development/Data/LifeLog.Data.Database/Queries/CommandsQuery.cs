using DataService.Bases;
using DevExpress.Xpo;
using LifeLog.Base.Utils;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Commands data query
	/// </summary>
	public class CommandsQuery : DataQueryBase
	{
		#region MAIN

		/// <summary>
		/// Default Constructor
		/// </summary>
		public CommandsQuery() : base()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public CommandsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		/// <summary>
		/// Data layer e outro constructor
		/// </summary>
		/// <param name="dataLayer"></param>
		/// <param name="connection"></param>
		public CommandsQuery(IDataLayer dataLayer, IDbConnection connection) : base(dataLayer, connection)
		{
		}

		#endregion

		#region GLOBAL
		
		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public async Task<List<CommandsEntity>> GetAll()
		{
			return await _UOW.Query<CommandsEntity>()
				.ToListAsync();
		}

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<CommandsEntity>> GetUserCommands(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			return await _UOW.Query<CommandsEntity>().Where(w => w.User.Id == userDb.Id).ToListAsync();
		}

		/// <summary>
		/// Save the notes by user
		/// </summary>
		/// <param name="model"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(bool, string)> Save(CommandsEntity model, Guid userId)
		{
			if (model == null)
				throw new ArgumentNullException("Notes model is null");

			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);

			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			CommandsEntity commandDB = await _UOW.GetObjectByKeyAsync<CommandsEntity>(model.Id);

			if (!model.EditingMode || commandDB == null)
			{
				commandDB = new CommandsEntity(_UOW);
				model.Id = Guid.NewGuid();
				commandDB.Id = model.Id;
			}

			model.User = userDb;

			ExternalProgramsEntity externalProgramsEntity = null;
			if (model.ExternalProgram != null)
			{
				externalProgramsEntity = await _UOW.GetObjectByKeyAsync<ExternalProgramsEntity>(model.ExternalProgram.Id);
			}

			model.MapTo(commandDB);

			//Class
			commandDB.User = userDb;
			commandDB.ExternalProgram = externalProgramsEntity;

			//Set saving
			commandDB.Saving = true;

			await _UOW.SaveAsync(commandDB);
			await _UOW.CommitChangesAsync();

			return (true, "Command as been saved!"); ;
		}

		#endregion
	}
}
