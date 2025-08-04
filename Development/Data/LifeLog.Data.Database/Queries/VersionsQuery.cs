using DataService.Bases;
using DevExpress.Xpo;
using LifeLog.Data.Database.Bases;
using LifeLog.Data.Database.Entities;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LifeLog.Data.Database.Queries
{
	/// <summary>
	/// Versions data query
	/// </summary>
	public class VersionsQuery : DataQueryBase
	{
		#region MAIN

		/// <summary>
		/// Default Constructor
		/// </summary>
		public VersionsQuery() : base()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="uow"></param>
		/// <param name="sql"></param>
		public VersionsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
		{
		}

		/// <summary>
		/// Data layer e outro constructor
		/// </summary>
		/// <param name="dataLayer"></param>
		/// <param name="connection"></param>
		public VersionsQuery(IDataLayer dataLayer, IDbConnection connection) : base(dataLayer, connection)
		{
		}

		#endregion

		#region QUERIES

		/// <summary>
		/// Validate Version
		/// </summary>
		/// <param ddlName="programId"></param>
		/// <param ddlName="version"></param>
		/// <returns></returns>
		public bool ValidateVersion(Guid ddlId, string ddlName, string dllVersion)
		{
			VersionsEntity version = new VersionsEntity(_UOW);
			version.Id = Guid.NewGuid();
			version.Version = dllVersion;
			version.ProgramId = ddlId;
			version.Name = ddlName;
			version.CreatedAt = DateTime.Now;
			version.UpdatedAt = DateTime.Now;

			VersionsEntity currentVerison = _UOW.Query<VersionsEntity>()
				.Where(w => w.ProgramId == version.ProgramId && w.Version == version.Version)
				.OrderByDescending(w => w.CreatedAt)
				.FirstOrDefault();

			VersionsEntity lastVersion = _UOW.Query<VersionsEntity>()
				.Where(w => w.ProgramId == version.ProgramId)
				.OrderByDescending(w => w.CreatedAt)
				.FirstOrDefault();

			if (currentVerison == null)
			{
				_UOW.SaveAsync(version);
				_UOW.CommitChangesAsync ();
				return true;
			}

			if (lastVersion == currentVerison)
				return true;

			return false;
		}

		#endregion

		#region GLOBAL

		#endregion
	}
}
