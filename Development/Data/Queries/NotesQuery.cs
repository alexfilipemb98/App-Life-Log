using Data.Bases;
using Data.Entities;
using DevExpress.Xpo;
using System;

namespace Data.Queries
{
    /// <summary>
    /// Notes Data Query
    /// </summary>
    public class NotesQuery : DataQueryBase<NotesEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public NotesQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }
    }
}
