using DevExpress.Xpo;
using LifeLog.Data.Models;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Mappers;
using LifeLog.Data.Database.ORMDataModel;
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
	public class ExternalProgramsQuery : DataQueryBase<ExternalProgramsModel, Guid>
	{
		#region BASE

		/// <summary>
		/// Get the model by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(ExternalProgramsModel, string)> GetByKey(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				ORM_ExternalProgramModel result = await db.GetObjectByKeyAsync<ORM_ExternalProgramModel>(key);
				string message = result != null ? "External program retrieved successfully." : "External program not found.";
				return (result != null ? result.ToModel() : new ExternalProgramsModel(), message);
			}
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<ExternalProgramsModel>, string)> GetAll()
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				List<ExternalProgramsModel> results = await db.Query<ORM_ExternalProgramModel>()
				   .Select(s => s.ToModel())
				   .ToListAsync();
				string message = results.Count > 0 ? $"External programs retrieved successfully, {results.Count} found." : "No external programs found.";
				return (results ?? new List<ExternalProgramsModel>(), message);
			}
		}

		/// <summary>
		/// Save the model object
		/// </summary>
		/// <param fName="model"></param>
		/// <param fName="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(bool, string)> Save(ExternalProgramsModel model)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				await base.Save(model);

				ORM_ExternalProgramModel entity = model.ToEntity(db);

				if (entity == null)
					throw new ArgumentNullException("External Programs entity is null");

				await db.SaveAsync(entity);
				await db.CommitChangesAsync();

				(bool saved, _) = await Exists(model.Id);
				string message = saved ? "External program saved successfully." : "External program not found after saving.";
				
				return (saved, message);
			}
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(ExternalProgramsModel, string)> Duplicate(Guid key)
		{
			using (UnitOfWork db = new UnitOfWork(Engine.Instance.DataLayer))
			{
				(ExternalProgramsModel model, _) = await base.Duplicate(key);
				ORM_ExternalProgramModel entity = model.ToEntity(db);

				entity.Id = Guid.NewGuid();
				entity.Name += " (Copy)";

				model.Id = entity.Id;
				model.Name = entity.Name;
				
				await db.SaveAsync(model);
				await db.CommitChangesAsync();

				(bool exists, _) = await Exists(model.Id);
				string message = exists ? "External program duplicated successfully." : "External program not found after duplication.";

				return (model, message);
			}
		}

		#endregion
	}
}