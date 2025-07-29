using DataService.Bases;
using DevExpress.Xpo;
using LifeLog.Data.Database.Bases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Commands data query
	/// </summary>
	public class CommandsQuery : DataQueryBase
	{
		#region MAIN

		/// <summary>
		/// Default Constructor
		/// </summary>
		public CommandsQuery() : base()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public CommandsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		/// <summary>
		/// Data layer e outro constructor
		/// </summary>
		/// <param name="dataLayer"></param>
		/// <param name="connection"></param>
		public CommandsQuery(IDataLayer dataLayer, IDbConnection connection) : base(dataLayer, connection)
		{
		}

		#endregion
	}
}
