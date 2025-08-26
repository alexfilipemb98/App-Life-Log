using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Models.Data;
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
	public class ImagesQuery : DataQueryBase<ImagesModel, Guid>
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param fName="uow"></param>
		/// <param fName="sql"></param>
		public ImagesQuery(UnitOfWork uow, SqlDataAccess sql) : base(uow, sql)
		{
		}

		#endregion

		#region BASE

		/// <summary>
		/// Get the command by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(ImagesModel, string)> GetByKey(Guid key)
		{
			ORM_ImagesModel result = await _UOW.GetObjectByKeyAsync<ORM_ImagesModel>(key);
			var model = result != null ? result.ToModel() : new ImagesModel();
			string message = result != null ? "Image retrieved successfully." : "Image not found.";
			return (model, message);
		}

		/// <summary>
		/// Get all notes
		/// </summary>
		/// <returns></returns>
		public override async Task<(List<ImagesModel>, string)> GetAll()
		{
			List<ImagesModel> resutls = await _UOW.Query<ORM_ImagesModel>()
				   .Select(s => s.ToModel())
				   .ToListAsync() ?? new List<ImagesModel>();
			string message = resutls.Count > 0 ? $"Images retrieved successfully, {resutls.Count} found." : "No images found.";
			
			return (resutls, message);
		}

		/// <summary>
		/// Save the image object
		/// </summary>
		/// <param fName="image"></param>
		/// <param fName="userId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public override async Task<(bool, string)> Save(ImagesModel model)
		{
			await base.Save(model);

			ORM_ImagesModel entity = model.ToEntity(_UOW);

			if (entity == null)
				throw new ArgumentNullException("Images entity is null");

			entity.Saving = true;

			await _UOW.SaveAsync(entity);
			await _UOW.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Image saved successfully." : "Image not found after saving.";

			return (exists, message);
		}

		/// <summary>
		/// Duplicates the model by key and returns the duplicated model
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public override async Task<(ImagesModel, string)> Duplicate(Guid key)
		{
			(ImagesModel model, _) = await base.Duplicate(key);
			ORM_ImagesModel entity = model.ToEntity(_UOW);

			entity.Id = Guid.NewGuid();
			entity.Name += " (Copy)";

			model.Id = entity.Id;
			model.Name = entity.Name;

			entity.Saving = true;

			await _UOW.SaveAsync(model);
			await _UOW.CommitChangesAsync();

			(bool exists, _) = await Exists(model.Id);
			string message = exists ? "Image duplicated successfully." : "Image not found after duplication.";

			return (model, message);
		}

		#endregion
	}
}
