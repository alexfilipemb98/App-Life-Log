using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Bases
{
	/// <summary>
	/// Base data query
	/// </summary>
	public class DataQueryBase<Entity, Object, Key> : IBaseQuery<Entity, Object, Guid>
	{
		#region MAIN

		//PROPERTIES
		public string TableName
		{
			get
			{
				PersistentAttribute attr = (PersistentAttribute)typeof(Entity)
					.GetCustomAttributes(typeof(PersistentAttribute), inherit: false)
					.FirstOrDefault();

				return attr?.MapTo;
			}
		}

		//INTERNAL
		internal readonly UnitOfWork _UOW;
		internal readonly SqlDataAccess _SQL;

		//PRIVATE
		private bool canDispose;

		/// <summary>
		/// Contructor internal
		/// </summary>
		public DataQueryBase(UnitOfWork uow, SqlDataAccess sql)
		{
			_UOW = uow;
			_SQL = sql;
		}

		#endregion

		#region QUERIES BASE

		/// <summary>
		/// Ches if the command exists
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public virtual async Task<bool> Exists(Guid key)
		{
			string sql = $"SELECT COUNT(*) FROM {TableName} WHERE Id = @Id";
			int count = await _SQL.GetValueAsync<int, object>(sql, new { Id = key });
			return count > 0;
		}

		/// <summary>
		/// Get the object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<Object> GetByKey(Guid key)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
			Object result = await _SQL.GetValueAsync<Object, object>(sql, new { Id = key });
			if (result == null)
				throw new ArgumentException($"No object found with key {key}");

			return result;
		}

		/// <summary>
		/// Get all objects
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<List<Object>> GetAll()
		{
			string sql = $"SELECT * FROM {TableName}";
			List<Object> results = await _SQL.LoadDataListAsync<Object>(sql);
			return results ?? new List<Object>();
		}

		/// <summary>
		/// Get the last command on the database
		/// </summary>
		/// <returns></returns>
		public virtual async Task<Object> GetLast()
		{
			string sql = $"SELECT TOP 1 * FROM {TableName} ORDER BY CreatedAt DESC";
			Object command = await _SQL.GetValueAsync<Object>(sql);
			return command;
		}

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<bool> Save(Object model)
		{
			bool isValid = model == null;

			if (!isValid)
				throw new ArgumentNullException("Notes model is null");

			isValid = model.ValidateModel(out List<ValidationResult> validationResults);
			if (!isValid)
				throw new Exception("Model is not valid: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));

			return isValid;
		}

		/// <summary>
		/// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<Object> Duplicate(Guid key)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
			Object original = await _SQL.GetValueAsync<Object, object>(sql, new { Id = key });
			if (original == null)
				throw new ArgumentException($"No object found with key {key}");

			Object duplicate = (Object)Activator.CreateInstance(typeof(Object), original);

			return duplicate;
		}

		/// <summary>
		/// Delete the object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<bool> Delete(Guid key)
		{
			string sql = $"DELETE FROM {TableName} WHERE Id = @Id";
			int rowsAffected = await _SQL.SaveDataAsync(sql, new { Id = key });
			return rowsAffected > 0;
		}

		#endregion
	}
}
