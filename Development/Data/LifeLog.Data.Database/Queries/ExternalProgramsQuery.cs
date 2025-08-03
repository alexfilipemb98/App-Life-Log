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
	/// Images data query
	/// </summary>
	public class ExternalProgramsQuery : DataQueryBase
	{
		#region MAIN

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ExternalProgramsQuery() : base()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public ExternalProgramsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		/// <summary>
		/// Data layer e outro constructor
		/// </summary>
		/// <param name="dataLayer"></param>
		/// <param name="connection"></param>
		public ExternalProgramsQuery(IDataLayer dataLayer, IDbConnection connection) : base(dataLayer, connection)
		{
		}

		#endregion

		#region GLOBAL

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<List<ExternalProgramsEntity>> GetAll()
		{
			return await _UOW.Query<ExternalProgramsEntity>()
				.ToListAsync();
		}


		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<ExternalProgramsEntity>> GetUserExternalPrograms(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			return await _UOW.Query<ExternalProgramsEntity>().Where(w => w.User.Id == userDb.Id).ToListAsync();
		}

		/// <summary>
		/// Save the externalProgram object
		/// </summary>
		/// <param name="externalProgram"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(bool saved, string message)> Save(ExternalProgramsEntity externalProgram, Guid userId)
		{
			try
			{
				if (externalProgram == null)
					throw new ArgumentNullException("Notes model is null");

				UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);

				if (userDb == null)
					throw new ArgumentException("User id is invalid!");

				ExternalProgramsEntity externalProgramDB = await _UOW.GetObjectByKeyAsync<ExternalProgramsEntity>(externalProgram.Id);

				if (!externalProgram.EditingMode || externalProgramDB == null)
				{
					externalProgramDB = new ExternalProgramsEntity(_UOW);
					externalProgram.Id = Guid.NewGuid();
					externalProgramDB.Id = externalProgram.Id;
				}

				externalProgram.User = userDb;

				externalProgram.MapTo(externalProgramDB);

				//Class
				externalProgramDB.User = userDb;

				if (externalProgram.Image == null || externalProgram.Image.Data == null)
				{
					externalProgramDB.Image = null;
				}
				else
				{
					ImagesEntity imgDB = await _UOW.GetObjectByKeyAsync<ImagesEntity>(externalProgram.IdImage);

					if (!externalProgram.Image.EditingMode || imgDB == null)
					{
						imgDB = new ImagesEntity(_UOW);
						externalProgram.Image.Id = Guid.NewGuid();
						imgDB.Id = externalProgram.Image.Id;
					}

					externalProgram.Image.User = userDb;

					externalProgram.Image.MapTo(imgDB);

					externalProgramDB.Image = imgDB;

					externalProgramDB.Image.Saving = true;
				}

				//Set saving
				
				externalProgramDB.Saving = true;

				await _UOW.SaveAsync(externalProgramDB);
				await _UOW.CommitChangesAsync();

				return (true, "Note as been saved!");
			}
			finally
			{
				_UOW.RollbackTransaction();
			}
		}

		#endregion
	}
}