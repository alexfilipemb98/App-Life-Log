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
    /// Commands Data Query
    /// </summary>
    public class CommandsQuery : DataQueryBase<CommandsEntity>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public CommandsQuery(UnitOfWork uow, SqlDataAccessBase sql) : base(uow, sql)
        {
        }

        #region OVERRIDES

        /// <summary>
        /// Custom GetAll method
        /// </summary>
        /// <returns></returns>
        public override List<CommandsEntity> GetAll()
        {
            List<CommandsEntity> resultsList = base.GetAll();

            foreach (CommandsEntity commands in resultsList)
            {
                commands.ExternalProgram = _UOW.GetObjectByKey<ExternalProgramsEntity>(commands.IdExternalProgram);
                if (commands.ExternalProgram != null)
                    commands.ExternalProgram.Image = _UOW.GetObjectByKey<ImagesEntity>(commands.ExternalProgram.IdImage);
            }

            return resultsList;
        }

        #endregion
    }
}
