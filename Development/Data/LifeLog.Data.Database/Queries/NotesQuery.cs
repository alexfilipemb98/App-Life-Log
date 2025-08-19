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
		/// Get the note by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<(NotesModel, string)> GetByKey(Guid key)
		{
			NotesEntity result = await _UOW.GetObjectByKeyAsync<NotesEntity>(key);
			NotesModel model = result != null ? result.ToModel() : new NotesModel();
			string message = result != null ? "Note retrieved successfully." : "Note not found.";
			return (model, message);
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<NotesModel>, string)> GetAll()
		{
			List<NotesModel> results = await _UOW.Query<NotesEntity>()
				   .Select(s => s.ToModel())
				   .ToListAsync() ?? new List<NotesModel>();

			string message = results.Count > 0 ? $"Notes retrieved successfully, {results.Count} found." : "No notes found.";
			return (results, message);
		}

		/// <summary>
		/// Save the notes
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public override async Task<(bool, string)> Save(NotesModel model)
		{
			await base.Save(model);

			NotesEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Notes entity is null");

			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Note saved successfully." : "Note not found after saving.";
			return (exists, message);
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<(NotesModel, string)> Duplicate(Guid key)
		{
			(NotesModel model, _) = await base.Duplicate(key);
			NotesEntity entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			entity.Title += " (Copy)";
			model.Id = entity.Id;
			model.Title = entity.Title;
			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Note duplicated successfully." : "Note not found after duplication.";

			return (model, message);
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(List<NotesModel>, string)> GetUserNotes(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			List<NotesModel> results = await _UOW.Query<NotesEntity>()
				.Where(w => w.User.Id == userDb.Id)
				.Select(s => s.ToModel())
				.ToListAsync() ?? new List<NotesModel>();

			string message = results.Count > 0 ? $"Notes retrieved successfully, {results.Count} found." : "No notes found for the user.";
			return (results, message);
		}

		/// <summary>
		/// Saves notes list
		/// </summary>
		/// <param name="notesList"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		public async Task<(bool, string)> SaveList(List<NotesModel> notesList)
		{
			bool saved = false;
			foreach (NotesModel obj in notesList)
			{
				(saved, _) = await Save(obj);
			}
			string message = saved ? "Notes list saved successfully." : "Failed to save notes list.";
			return (saved, message);
		}

		#endregion
	}
}
