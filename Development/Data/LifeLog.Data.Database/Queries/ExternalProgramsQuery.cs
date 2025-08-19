using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
using LifeLog.Base.Models.Data;
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
		public override async Task<(ExternalProgramsModel, string)> GetByKey(Guid key)
		{
			ExternalProgramsEntity result = await _UOW.GetObjectByKeyAsync<ExternalProgramsEntity>(key);
			string message = result != null ? "External program retrieved successfully." : "External program not found.";
			return (result != null ? result.ToModel() : new ExternalProgramsModel(), message);
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<ExternalProgramsModel>, string)> GetAll()
		{
			List<ExternalProgramsModel> results = await _UOW.Query<ExternalProgramsEntity>()
				   .Select(s => s.ToModel())
				   .ToListAsync();
			string message = results.Count > 0 ? $"External programs retrieved successfully, {results.Count} found." : "No external programs found.";
			return (results ?? new List<ExternalProgramsModel>(), message);
		}

		/// <summary>
		/// Save the model object
		/// </summary>
		/// <param name="model"></param>
		/// <param name="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(bool, string)> Save(ExternalProgramsModel model)
		{
			await base.Save(model);

			ExternalProgramsEntity entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("External Programs entity is null");

			//Set saving
			entity.Saving = true;

			if (entity.Image != null)
				entity.Image.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();
			(bool saved, _ ) = await Exists(model.Id);
			string message = saved ? "External program saved successfully." : "External program not found after saving.";
			return (saved,message);
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override async Task<(ExternalProgramsModel,string)> Duplicate(Guid key)
		{
			(ExternalProgramsModel model,_) = await base.Duplicate(key);
			ExternalProgramsEntity entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			entity.Name += " (Copy)";
			
			model.Id = entity.Id;
			model.Name = entity.Name;

			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "External program duplicated successfully." : "External program not found after duplication.";

			return (model, message);
		}

		#endregion
	}
}