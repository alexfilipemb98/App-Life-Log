using Data.Bases;
using Data.Entities;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries
{
    /// <summary>
    /// External Programs Data Query
    /// </summary>
    public class ExternalProgramsQuery : DataQueryBase<ExternalProgramsEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public ExternalProgramsQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }

        #region OVERRIDES

        /// <summary>
        /// Override Save method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Save(ExternalProgramsEntity obj)
        {
            if (obj.Image != null)
            {
                if (obj.Image.EditingMode)
                    obj.Image.UpdatedAt = DateTime.Now;
                else
                    obj.Image.CreatedAt = DateTime.Now;
            }

            return base.Save(obj);
        }

        #endregion
    }
}
