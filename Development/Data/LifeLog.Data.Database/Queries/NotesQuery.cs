using DevExpress.Xpo;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
using LifeLog.Data.Models;
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
	public sealed class NotesQuery : DataQueryBase<NotesModel>, INotesQuery<NotesModel, Guid>
	{
		#region BASE

		/// <summary>
		/// Get the note by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(NotesModel, string)> GetByKey(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_NotesModel result = await db.GetObjectByKeyAsync<ORM_NotesModel>(key);
				NotesModel model = result != null ? result.ToModel() : new NotesModel();
				string message = result != null ? "Note retrieved successfully." : "Note not found.";
				return (model, message);
			}
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<NotesModel>, string)> GetAll()
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				List<NotesModel> results = await db.Query<ORM_NotesModel>()
				   .Select(s => s.ToModel())
				   .ToListAsync() ?? new List<NotesModel>();

				string message = results.Count > 0 ? $"Notes retrieved successfully, {results.Count} found." : "No notes found.";
				return (results, message);
			}
		}

		/// <summary>
		/// Save the notes
		/// </summary>
		/// <param fName="model"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public override async Task<(bool, string)> Save(NotesModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				await base.Save(model);

				return await SaveHelper(model, db);
			}
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(NotesModel, string)> Duplicate(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				(NotesModel model, _) = await base.Duplicate(key);
				ORM_NotesModel entity = model.ToEntity(db);
				entity.Id = Guid.NewGuid();
				entity.Title += " (Copy)";
				model.Id = entity.Id;
				model.Title = entity.Title;

				await db.SaveAsync(model);
				await db.CommitChangesAsync();

				(bool exists, _) = await Exists(model.Id);
				string message = exists ? "Note duplicated successfully." : "Note not found after duplication.";

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
		public async Task<(List<NotesModel>, string)> GetUserNotes(Guid userId)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_UsersModel userDb = await db.GetObjectByKeyAsync<ORM_UsersModel>(userId);
				if (userDb == null)
					throw new ArgumentException("User id is invalid!");

				List<NotesModel> results = await db.Query<ORM_NotesModel>()
					.Where(w => w.User.Id == userDb.Id)
					.OrderBy(o=>o.Position)
					.Select(s => s.ToModel())
					.ToListAsync() ?? new List<NotesModel>();

				string message = results.Count > 0 ? $"Notes retrieved successfully, {results.Count} found." : "No notes found for the user.";
				return (results, message);
			}
		}

		/// <summary>
		/// Saves notes list
		/// </summary>
		/// <param fName="notesList"></param>
		/// <param fName="userId"></param>
		/// <returns></returns>
		public async Task<(bool, string)> SaveList(List<NotesModel> notesList)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				bool saved = false;
				
				foreach (NotesModel obj in notesList)
				{
					(saved, _) = await SaveHelper(obj, db);
				}

				string message = saved ? "Notes list saved successfully." : "Failed to save notes list.";
				return (saved, message);
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
		private async Task<(bool, string)> SaveHelper(NotesModel model, UnitOfWork db)
		{
			ORM_NotesModel entity = model.ToEntity(db);

			if (entity == null)
				throw new ArgumentNullException("Notes entity is null");

			await db.SaveAsync(entity);
			await db.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Note saved successfully." : "Note not found after saving.";

			return (exists, message);
		}

		#endregion
	}
}
