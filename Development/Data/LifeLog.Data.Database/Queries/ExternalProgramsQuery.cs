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
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{

	/// <summary>
	/// Images data query
	/// </summary>
	public class ExternalProgramsQuery : DataQueryBase<ExternalProgramsEntity, ExternalProgramsModel, Guid>
	{
		#region MAIN

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
		/// Get the model by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<ExternalProgramsModel> GetByKey(Guid key)
		{
			ExternalProgramsEntity result = await _UOW.GetObjectByKeyAsync<ExternalProgramsEntity>(key);
			return result != null ? result.ToModel() : new ExternalProgramsModel();
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<List<ExternalProgramsModel>> GetAll()
		{
			List<ExternalProgramsModel> results = await _UOW.Query<ExternalProgramsEntity>()
				   .Select(s => s.ToModel())
				   .ToListAsync();
			return results ?? new List<ExternalProgramsModel>();
		}

		/// <summary>
		/// Save the model object
		/// </summary>
		/// <param name="model"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<bool> Save(ExternalProgramsModel model)
		{
			bool isvalid = await base.Save(model);

			ExternalProgramsEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("External Programs entity is null");

			//Set saving
			entity.Saving = true;

			if (entity.Image != null)
				entity.Image.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			return await Exists(model.Id);
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<ExternalProgramsModel> Duplicate(Guid key)
		{
			ExternalProgramsModel model = await base.Duplicate(key);
			ExternalProgramsEntity entity = model.ToEntity(_UOW);

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