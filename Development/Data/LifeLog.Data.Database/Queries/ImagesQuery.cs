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
	public class ImagesQuery : DataQueryBase, IBaseQuery<ImagesEntity, ImagesModel, Guid>
	{
		#region MAIN

		//PROPERTIES
		public string TableName
		{
			get
			{
				PersistentAttribute attr = (PersistentAttribute)typeof(ImagesQuery)
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
		public ImagesQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
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
		public async Task<ImagesModel> GetByKey(Guid key)
		{
			ImagesEntity result = await _UOW.GetObjectByKeyAsync<ImagesEntity>(key);
			return result != null ? result.ToModel() : new ImagesModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public async Task<List<ImagesModel>> GetAll()
		{
			return await _UOW.Query<ImagesEntity>()
				.Select(s => s.ToModel())
				.ToListAsync();
		}

		/// <summary>
		/// Save the image object
		/// </summary>
		/// <param name="image"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public async Task<(bool saved, string message)> Save(ImagesEntity image, Guid userId, bool isTransaction = false)
		{
			if (image == null)
				throw new ArgumentNullException("Notes model is null");

			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);

			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			ImagesEntity imageDB = await _UOW.GetObjectByKeyAsync<ImagesEntity>(image.Id);

			if (!image.EditingMode || imageDB == null)
			{
				imageDB = new ImagesEntity(_UOW);
				image.Id = Guid.NewGuid();
				imageDB.Id = image.Id;
			}

			image.User = userDb;

			image.MapTo(imageDB);

			//Class
			imageDB.User = userDb;

			//Set saving
			imageDB.Saving = true;

			await _UOW.SaveAsync(imageDB);
			await _UOW.CommitChangesAsync();

			return (true, "Image as been saved!"); ;
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

			ImagesEntity noteDb = await _UOW.GetObjectByKeyAsync<ImagesEntity>(id);

			if (noteDb == null)
				throw new ArgumentException("Note does not exists!");

			noteDb.User = null;

			await _UOW.DeleteAsync(noteDb);
			await _UOW.CommitChangesAsync();

			noteDb = await _UOW.GetObjectByKeyAsync<ImagesEntity>(id);

			return (noteDb == null, noteDb == null ? "Image as been deleted" : "Fail to delete image!");
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Gets users notes
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public async Task<List<ImagesModel>> GetUserImages(Guid userId)
		{
			UsersEntity userDb = await _UOW.GetObjectByKeyAsync<UsersEntity>(userId);
			if (userDb == null)
				throw new ArgumentException("User id is invalid!");

			return await _UOW.Query<ImagesEntity>().Where(w => w.User.Id == userDb.Id).ToListAsync();
		}

		#endregion
	}
}
