using DataService.Bases;
using DevExpress.Xpo;
using LifeLog.Base.Utils;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Entities;
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
	public class NotesQuery : DataQueryBase
	{
		#region MAIN

		/// <summary>
		/// Default Constructor
		/// </summary>
		public NotesQuery() : base()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public NotesQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		/// <summary>
		/// Data layer e outro constructor
		/// </summary>
		/// <param name="dataLayer"></param>
		/// <param name="connection"></param>
		public NotesQuery(IDataLayer dataLayer, IDbConnection connection) : base(dataLayer, connection)
		{
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<NotesEntity>> GetUserNotes(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			return await _UOW.Query<NotesEntity>().Where(w => w.User.Id == userDb.Id).ToListAsync();
		}

		/// <summary>
		/// Saves notes list
		/// </summary>
		/// <param name="notesList"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		public async Task<(bool, string)> SaveList(List<NotesEntity> notesList, Guid userId)
		{
			using (DataQueryBase query = new DataQueryBase())
			{
				foreach (NotesEntity obj in notesList)
				{
					await Save(obj, userId);
				}

				return (true, "Notes have been saved!");
			}
		}

		#endregion

		#region GLOBAL

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<List<NotesEntity>> GetAll()
		{
			return await _UOW.Query<NotesEntity>()
					.ToListAsync();
		}

		/// <summary>
		/// Get note by id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public async Task<NotesEntity> GetByKey(Guid id)
		{
			if (id == Guid.Empty)
				throw new ArgumentNullException("Notes is inválid!");

			return await _UOW.GetObjectByKeyAsync<NotesEntity>(id);
		}

		/// <summary>
		/// Save the notes by user
		/// </summary>
		/// <param name="note"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(bool, string)> Save(NotesEntity note, Guid userId)
		{
			if (note == null)
				throw new ArgumentNullException("Notes model is null");

			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);

			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			NotesEntity noteDB = await _UOW.GetObjectByKeyAsync<NotesEntity>(note.Id);

			if (!note.EditingMode || noteDB == null)
			{
				noteDB = new NotesEntity(_UOW);
				note.Id = Guid.NewGuid();
				noteDB.Id = note.Id;
			}

			note.User = userDb;

			note.MapTo(noteDB);

			//Class
			noteDB.User = userDb;

			//Set saving
			noteDB.Saving = true;

			await _UOW.SaveAsync(noteDB);
			await _UOW.CommitChangesAsync();

			return (true, "Note as been saved!"); ;
		}

		/// <summary>
		/// Delete the notes
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<(bool deleted, string message)> Delete(Guid id)
		{

			if (id == Guid.Empty)
				throw new ArgumentNullException("Notes is inválid!");

			NotesEntity noteDb = await _UOW.GetObjectByKeyAsync<NotesEntity>(id);

			if (noteDb == null)
				throw new ArgumentException("Note does not exists!");

			noteDb.User = null;

			await _UOW.DeleteAsync(noteDb);
			await _UOW.CommitChangesAsync();

			noteDb = await _UOW.GetObjectByKeyAsync<NotesEntity>(id);

			return (noteDb == null, noteDb == null ? "Note was been deleted" : "Fail to delete note!");
		}

		#endregion
	}
}
