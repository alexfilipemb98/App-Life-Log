using LifeLog.Base.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
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
	public class DataQueryBase<Object> : IBaseQuery<Object, Guid>
	{
		/// <summary>
		/// TABLE NAME
		/// </summary>
		public string TableName => typeof(Object).GetTableName();

		#region QUERIES BASE

		/// <summary>
		/// Ches if the command exists
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		public virtual async Task<(bool, string)> Exists(Guid key)
		{
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"SELECT 1 FROM {TableName} WHERE Id = @Id";
				int count = await db.ExecuteScalarAsync<int, object>(sql, new { Id = key.ToString() });
				bool exists = count > 0;
				string message = exists ? $"{TableName} with key {key} exists." : $"{TableName} with key {key} does not exist.";
				return (exists, message);
			}
		}

		/// <summary>
		/// Get the object by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(Object, string)> GetByKey(Guid key)
		{
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
				Object result = await db.GetValueAsync<Object, object>(sql, new { Id = key.ToString() });
				if (result == null)
					throw new ArgumentException($"No object found with key {key}");

				string message = result != null ? $"{TableName} with key {key} found." : $"{TableName} with key {key} not found.";

				return (result, message);
			}
		}

		/// <summary>
		/// Get all objects
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(List<Object>, string)> GetAll()
		{
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"SELECT * FROM {TableName}";
				List<Object> results = await db.LoadDataListAsync<Object>(sql) ?? new List<Object>();
				string message = results.Any() ? $"{results.Count} {TableName} found." : $"No {TableName} found.";
				return (results, message);
			}
		}

		/// <summary>
		/// Get the last command on the database
		/// </summary>
		/// <returns></returns>
		public virtual async Task<(Object, string)> GetLast()
		{
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"SELECT TOP 1 * FROM {TableName} ORDER BY CreatedAt DESC";
				Object command = await db.GetValueAsync<Object>(sql);
				string message = command != null ? $"{TableName} retrieved successfully." : $"{TableName} not found.";
				return (command, message);
			}
		}

		/// <summary>
		/// Save the object
		/// </summary>
		/// <param fName="model"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(bool, string)> Save(Object model)
		{
			bool isValid = model != null;

			if (!isValid)
				throw new ArgumentNullException("Model is null");

			isValid = model.ValidateModel(out List<ValidationResult> validationResults);
			if (!isValid)
				throw new Exception($"Model is not valid: {string.Join(", ", validationResults.Select(v => v.ErrorMessage))}");

			await Task.CompletedTask;

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
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"SELECT * FROM {TableName} WHERE Id = @Id";
				Object original = await db.GetValueAsync<Object, object>(sql, new { Id = key.ToString() });
				if (original == null)
					throw new ArgumentException($"No object found with key {key}");

				Object duplicate = (Object)Activator.CreateInstance(typeof(Object), original);

				return (duplicate, null);
			}
		}

		/// <summary>
		/// Delete the object by key
		/// </summary>
		/// <param fName="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<(bool, string)> Delete(Guid key)
		{
			using (SqlDataAccess db = new SqlDataAccess(Engine.Instance.Connection))
			{
				string sql = $"DELETE FROM {TableName} WHERE Id = @Id";
				int rowsAffected = await db.SaveDataAsync(sql, new { Id = key.ToString() });
				bool isDeleted = rowsAffected > 0;
				string message = isDeleted ? $"{TableName} with key {key} deleted successfully." : $"{TableName} with key {key} not found.";
				return (isDeleted, message);
			}
		}

		#endregion
	}
}
