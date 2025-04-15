using Core.Extensions;
using Data.Bases;
using Data.ORM.DataModelCode;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Data.Queries
{
    /// <summary>
    /// Notes Queries
    /// </summary>
    public class NotesQuery : DataQueryBase<ORM_Notes>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public NotesQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
        {
        }

        #region QUERIES

        /// <summary>
        /// Returns the user notes
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public List<ORM_Notes> GetUserNotes(Guid userID)
        {
            ORM_Users user = _UOW.GetLoadedObjectByKey<ORM_Users>(userID);
            if (user == null)
                throw new ArgumentException("User not found!");

            List<ORM_Notes> notes = user.User_Notes.ToList() ?? new List<ORM_Notes>();

            return notes;
        }

        /// <summary>
        /// Save notes by list
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="Core.Exceptions.ValidationException"></exception>
        public bool Save(List<ORM_Notes> notes, out string message )
        {
            foreach (ORM_Notes obj in notes)
            {
                if (!obj.IsValid(out List<ValidationResult> results))
                    throw new Core.Exceptions.ValidationException(results);
            
                obj.SavingMode = true;
                
                _UOW.Save(obj);
            }

            _UOW.CommitChanges();

            message = "Notes have been saved!";

            return true;
        }

        #endregion
    }
}
