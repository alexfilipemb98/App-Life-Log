using Data.Bases;
using Data.ORM.DataModelCode;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries
{
	/// <summary>
	/// Notes Queries
	/// </summary>
	public class ExternalProgramsQuery : DataQueryBase<ORM_ExternalPrograms>
	{
		/// <summary>
		/// Construtor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public ExternalProgramsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		#region QUERIES

		/// <summary>
		/// Returns the user notes
		/// </summary>
		/// <param name="userID"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public List<ORM_ExternalPrograms> GetUserExternalPrograms(Guid userID)
		{
			ORM_Users user = _UOW.GetLoadedObjectByKey<ORM_Users>(userID);
			if (user == null)
				throw new ArgumentException("User not found!");

			List<ORM_ExternalPrograms> notes = user.User_ExternalPrograms.ToList() ?? new List<ORM_ExternalPrograms>();

			return notes;
		}

		#endregion
	}
}
