using DataService.Bases;
using DevExpress.Xpo;
using LifeLog.Base.Infrastructure.Enums;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Bases
{
	/// <summary>
	/// Base data query
	/// </summary>
	public class DataQueryBase : IDisposable
	{
		#region MAIN

		//INTERNAL
		internal readonly UnitOfWork _UOW;
		internal readonly DataSqlAccessBase _SQL;

		//PRIVATE
		private bool canDispose;

		/// <summary>
		/// Default constuctor
		/// </summary>
		public DataQueryBase()
		{
			canDispose = true;

			_UOW = new UnitOfWork(Engine.Instance.DataLayer);
			_SQL = new DataSqlAccessBase(Engine.Instance.Connection);
		}

		/// <summary>
		/// Contructor internal
		/// </summary>
		public DataQueryBase(UnitOfWork uow, DataSqlAccessBase sql)
		{
			canDispose = false;

			_UOW = uow;
			_SQL = sql;
		}

		/// <summary>
		/// Contructor
		/// </summary> 
		public DataQueryBase(IDataLayer dataLayer, IDbConnection connection)
		{
			canDispose = true;

			_UOW = new UnitOfWork(dataLayer);

			if (connection != null)
				_SQL = new DataSqlAccessBase(connection);
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Dispose conections
		/// </summary>
		public void Dispose()
		{
			if (canDispose)
			{
				_UOW?.Disconnect();
				_UOW?.Dispose();

				_SQL?.Disconect();
				_SQL?.Dispose();
			}
		}

		#endregion
	}
}
