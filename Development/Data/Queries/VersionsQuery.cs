using Data.Bases;
using Data.Entities;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries
{
    /// <summary>
    /// Versions Query
    /// </summary>
    public class VersionsQuery : DataQueryBase<VersionsEntity>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public VersionsQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }

        #region QUERIES

        /// <summary>
        /// Validate Version
        /// </summary>
        /// <param name="programId"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public bool ValidateVersion(VersionsEntity version)
        {
            VersionsEntity currentVerison = _UOW.Query<VersionsEntity>()
                .Where(w => w.ProgramId == version.ProgramId && w.Version == version.Version)
                .OrderByDescending(w => w.CreatedAt)
                .FirstOrDefault();
            
            VersionsEntity lastVersion = _UOW.Query<VersionsEntity>()
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
