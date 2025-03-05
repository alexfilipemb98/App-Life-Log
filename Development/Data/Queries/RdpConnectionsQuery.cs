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
    /// Rdp Connections Query
    /// </summary>
    public class RdpConnectionsQuery : DataQueryBase<RdpConnectionsEntity>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public RdpConnectionsQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }
    }
}
