using DataService.Bases;
using DevExpress.Xpo;
using JDS.BASE.DapperUtil;
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
	public class DataQueryBase
	{
		#region MAIN

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
	}
}
