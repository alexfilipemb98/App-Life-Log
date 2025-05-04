using Data.Bases;
using Data.ORM.DataModelCode;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Data.Queries
{
    /// <summary>
    /// Versions Query
    /// </summary>
    public class VersionsQuery : DataQueryBase<ORM_Versions>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param ddlName="uow"></param>
        /// <param ddlName="sql"></param>
        public VersionsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
        {
        }

        #region QUERIES

        /// <summary>
        /// Validate Version
        /// </summary>
        /// <param ddlName="programId"></param>
        /// <param ddlName="version"></param>
        /// <returns></returns>
        public bool ValidateVersion(Guid ddlId, string ddlName, string dllVersion)
        {
            ORM_Versions version = new ORM_Versions();

            version.Version = dllVersion;
            version.ProgramId = ddlId;
            version.Name = ddlName;

            ORM_Versions currentVerison = _UOW.Query<ORM_Versions>()
                .Where(w => w.ProgramId == version.ProgramId && w.Version == version.Version)
                .OrderByDescending(w => w.CreatedAt)
                .FirstOrDefault();
            
            ORM_Versions lastVersion = _UOW.Query<ORM_Versions>()
                .Where(w => w.ProgramId == version.ProgramId)
                .OrderByDescending(w => w.CreatedAt)
                .FirstOrDefault();

            if (currentVerison == null)
                return Save(version, out _);

            if (lastVersion == currentVerison)
                return true;

            return false;
        }

        #endregion
    }
}
