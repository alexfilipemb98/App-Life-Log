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
    /// Settings 
    /// </summary>
    public class PasswordsQuery : DataQueryBase<PasswordsEntity>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public PasswordsQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }
    }
}
