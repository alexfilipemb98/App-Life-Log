using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Base.Models;
using System;
using System.Collections.Generic;
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
			throw new NotImplementedException("GetByKey method is not implemented in the base class. Please implement it in the derived class.");
		}

		/// <summary>
		/// Get all objects
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<List<Object>> GetAll()
		{
			throw new NotImplementedException("GetAll method is not implemented in the base class. Please implement it in the derived class.");
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
			throw new NotImplementedException("Save method is not implemented in the base class. Please implement it in the derived class.");
		}

		/// <summary>
		/// Duplicates the object by key and returns the duplicated
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<Object> Duplicate(Guid key)
		{
			throw new NotImplementedException("Duplicate method is not implemented in the base class. Please implement it in the derived class.");
		}

		/// <summary>
		/// Delete the object by key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public virtual async Task<bool> Delete(Guid key)
		{
			throw new NotImplementedException("Delete method is not implemented in the base class. Please implement it in the derived class.");
		}

		#endregion
	}
}
