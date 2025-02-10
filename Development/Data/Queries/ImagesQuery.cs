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
    /// Images Data Query
    /// </summary>
    public class ImagesQuery : DataQueryBase<ImagesEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public ImagesQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }
    }
}
