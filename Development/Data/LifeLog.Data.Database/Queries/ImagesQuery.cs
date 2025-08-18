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
	/// Images data query
	/// </summary>
	public class ImagesQuery : DataQueryBase<ImagesEntity, ImagesModel, Guid>
	{
		#region MAIN

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
		/// Get the command by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<ImagesModel> GetByKey(Guid key)
		{
			ImagesEntity result = await _UOW.GetObjectByKeyAsync<ImagesEntity>(key);
			return result != null ? result.ToModel() : new ImagesModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<List<ImagesModel>> GetAll()
		{
			List<ImagesModel> resutls = await _UOW.Query<ImagesEntity>()
				   .Select(s => s.ToModel())
				   .ToListAsync();
			return resutls ?? new List<ImagesModel>();
		}

		/// <summary>
		/// Save the image object
		/// </summary>
		/// <param name="image"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<bool> Save(ImagesModel model)
		{
			bool isvalid = await base.Save(model);

			ImagesEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Images entity is null");

			//Set saving
			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			return await Exists(model.Id);
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<ImagesModel> Duplicate(Guid key)
		{
			ImagesModel model = await base.Duplicate(key);
			ImagesEntity entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			model.Id = entity.Id;
			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			return model;
		}

		#endregion
	}
}
