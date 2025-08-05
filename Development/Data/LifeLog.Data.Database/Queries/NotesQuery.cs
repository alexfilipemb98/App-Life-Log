using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
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
	/// Notes data query
	/// </summary>
	public class NotesQuery : DataQueryBase<NotesEntity, NotesModel, Guid>
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public NotesQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
		{
		}

		#endregion

		#region BASE

		/// <summary>
		/// Get the command by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<NotesModel> GetByKey(Guid key)
		{
			NotesEntity result = await _UOW.GetObjectByKeyAsync<NotesEntity>(key);
			return result != null ? result.ToModel() : new NotesModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<List<NotesModel>> GetAll()
		{
			List<NotesModel> resutls = await _UOW.Query<NotesEntity>()
				   .Select(s => s.ToModel())
				   .ToListAsync();
			return resutls ?? new List<NotesModel>();
		}

		/// <summary>
		/// Save the notes
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public override async Task<bool> Save(NotesModel model)
		{
			bool isvalid = await base.Save(model);

			NotesEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Notes entity is null");

			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			return await Exists(model.Id);
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<NotesModel>> GetUserNotes(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			List<NotesModel> results = await _UOW.Query<NotesEntity>()
				.Where(w => w.User.Id == userDb.Id)
				.Select(s => s.ToModel())
				.ToListAsync();

			return results ?? new List<NotesModel>();
		}

		/// <summary>
		/// Saves notes list
		/// </summary>
		/// <param name="notesList"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		public async Task<bool> SaveList(List<NotesModel> notesList)
		{
			bool saved = false;
			foreach (NotesModel obj in notesList)
			{
				saved = await Save(obj);
			}
			return saved;
		}

		#endregion
	}
}
