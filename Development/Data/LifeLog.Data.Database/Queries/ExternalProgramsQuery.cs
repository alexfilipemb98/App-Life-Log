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
	/// Images data query
	/// </summary>
	public class ExternalProgramsQuery : DataQueryBase, IBaseQuery<ExternalProgramsEntity, ExternalProgramsModel, Guid>
	{
		#region MAIN

		//PROPERTIES
		public string TableName
		{
			get
			{
				PersistentAttribute attr = (PersistentAttribute)typeof(ExternalProgramsEntity)
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
		public ExternalProgramsQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
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
		public async Task<ExternalProgramsModel> GetByKey(Guid key)
		{
			ExternalProgramsEntity result = await _UOW.GetObjectByKeyAsync<ExternalProgramsEntity>(key);
			return result != null ? result.ToModel() : new ExternalProgramsModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public async Task<List<ExternalProgramsModel>> GetAll()
		{
			return await _UOW.Query<ExternalProgramsEntity>()
				.Select(s => s.ToModel())
				.ToListAsync();
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