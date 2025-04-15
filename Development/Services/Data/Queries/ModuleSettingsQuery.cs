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
    public class ModuleSettingsQuery : DataQueryBase<ORM_ModuleSettings>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public ModuleSettingsQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
        {
        }

        #region QUERIES

        /// <summary>
        /// Returns the user module settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ORM_ModuleSettings GetUserModuleSettings(Guid userId)
        {
            ORM_Users user = _UOW.GetObjectByKey<ORM_Users>(userId);
            if (user == null)
                throw new ArgumentException("User does not exist!");

            ORM_ModuleSettings modulesettings = QueryBase.FirstOrDefault(x => x.User.Id == userId) ;

            if (modulesettings == null)
            {
                modulesettings = new ORM_ModuleSettings(_UOW)
                {
                    User = user,
                    EnableNotes = true,
                    EnablePasswords = true
                };
            }
            
            return modulesettings;
        }

        #endregion
    }
}
