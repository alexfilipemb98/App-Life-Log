using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Bases
{
	/// <summary>
	/// Base data query
	/// </summary>
	public class DataQueryBase<Object, Key> : IBaseQuery<Object, Guid>
	{
		#region MAIN

		//PROPERTIES
		public string TableName
		{
			get
			{
				TableAttribute attr = (TableAttribute)typeof(Object)
					.GetCustomAttributes(typeof(TableAttribute), inherit: false)
					.FirstOrDefault();

				return attr?.Name;
			}
		}

		//INTERNAL
		internal readonly UnitOfWork _UOW;
		internal readonly SqlDataAccess _SQL;

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
		/// <param fName="key"></param>
		/// <returns></returns>
		public virtual async Task<(bool, string)> Exists(Guid key)
		{
			string sql = $"SELECT COUNT(*) FROM {TableName} WHERE Id = @Id";
			int count = await _SQL.GetValueAsync<int, object>(sql, new { Id = key });
			bool exists = count > 0;
			string message = exists ? $"{TableName} with key {key} exists." : $"{TableName} with key {key} does not exist.";
			return (exists, message);
		}

		/// <summary>
		/// Get the object by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(Object, string)> GetByKey(Guid key)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
			Object result = await _SQL.GetValueAsync<Object, object>(sql, new { Id = key });
			if (result == null)
				throw new ArgumentException($"No object found with key {key}");

			string message = result != null ? $"{TableName} with key {key} found." : $"{TableName} with key {key} not found.";

			return (result, message);
		}

		/// <summary>
		/// Get all objects
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(List<Object>, string)> GetAll()
		{
			string sql = $"SELECT * FROM {TableName}";
			List<Object> results = await _SQL.LoadDataListAsync<Object>(sql) ?? new List<Object>();
			string message = results.Any() ? $"{results.Count} {TableName} found." : $"No {TableName} found.";
			return (results, message);
		}

		/// <summary>
		/// Get the last command on the database
		/// </summary>
		/// <returns></returns>
		public virtual async Task<(Object, string)> GetLast()
		{
			string sql = $"SELECT TOP 1 * FROM {TableName} ORDER BY CreatedAt DESC";
			Object command = await _SQL.GetValueAsync<Object>(sql);
			string message = command != null ? $"{TableName} retrieved successfully." : $"{TableName} not found.";
			return (command, message);
		}

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param fName="model"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(bool, string)> Save(Object model)
		{
			bool isValid = model == null;

			if (!isValid)
				throw new ArgumentNullException("Notes model is null");

			isValid = model.ValidateModel(out List<ValidationResult> validationResults);
			if (!isValid)
				throw new Exception($"Model is not valid: {string.Join(", ", validationResults.Select(v => v.ErrorMessage))}");

			return (isValid, null);
		}

		/// <summary>
		/// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(Object, string)> Duplicate(Guid key)
		{
			string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
			Object original = await _SQL.GetValueAsync<Object, object>(sql, new { Id = key });
			if (original == null)
				throw new ArgumentException($"No object found with key {key}");

			Object duplicate = (Object)Activator.CreateInstance(typeof(Object), original);

			return (duplicate, null);
		}

		/// <summary>
		/// Delete the object by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(bool, string)> Delete(Guid key)
		{
			string sql = $"DELETE FROM {TableName} WHERE Id = @Id";
			int rowsAffected = await _SQL.SaveDataAsync(sql, new { Id = key });
			bool isDeleted = rowsAffected > 0;
			string message = isDeleted ? $"{TableName} with key {key} deleted successfully." : $"{TableName} with key {key} not found.";
			return (isDeleted, message);
		}

		#endregion
	}
}
