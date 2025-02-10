using Core.Extensions;
using Core.Interfaces;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Data.Bases
{
    /// <summary>
    /// Base Query for Data Base
    /// </summary>
    public abstract class DataQueryBase<Entity> : IBaseQuery<Entity, Guid> where Entity : DataEntityBase
    {
        #region MAIN

        //PROTECTED
        protected readonly UnitOfWork _UOW;
        protected readonly SqlDataAccessBase _SQL;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        public DataQueryBase(UnitOfWork uow, SqlDataAccessBase sql)
        {
            _UOW = uow;
            _SQL = sql;
        }

        #endregion

        #region INTERFACES

        /// <summary>
        /// Query Base
        /// </summary>
        public virtual IQueryable<Entity> QueryBase =>
            _UOW.Query<Entity>();

        /// <summary>
        /// Gets the entity by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual Entity GetByKey(Guid key)
        {
            Entity entity = _UOW.GetObjectByKey<Entity>(key);
            entity.EditingMode = true;
            return entity;
        }

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        public virtual List<Entity> GetAll()
        {
            List<Entity> results = QueryBase.ToList();
            results.ForEach(w => w.EditingMode = true);
            return results;
        }

        /// <summary>
        /// Checks if the object exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual bool Exists(Guid key) =>
            _UOW.GetObjectByKey<Entity>(key) != null;

        /// <summary>
        /// Get's the last insert object
        /// </summary>
        /// <returns></returns>
        public virtual Entity GetLast() =>
            QueryBase.LastOrDefault();

        /// <summary>
        /// Save the object
        /// </summary>
        /// <param name="obj">The entity object to save.</param>
        /// <returns>True if the object exists after saving; otherwise, false.</returns>
        public virtual bool Save(Entity obj)
        {
            if (!obj.IsValid(out List<ValidationResult> results))
                throw new Core.Exceptions.ValidationException(results);

            if (obj.EditingMode)
                obj.UpdatedAt = DateTime.Now;
            else
                obj.CreatedAt = DateTime.Now;


            _UOW.Save(obj);
            _UOW.CommitChanges();

            obj.EditingMode = true;

            return Exists(obj.Id);
        }

        /// <summary>
        /// Duplicates the object by key and returns the duplicated0
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public virtual Entity Duplicate(Guid key)
        {
            Entity entity;

            if (!Exists(key))
                throw new Exception("The object does not exist");

            entity = _UOW.GetObjectByKey<Entity>(key);

            PropertyInfo keyinfo = entity.GetType().GetKey();
            keyinfo.SetValue(entity, Guid.NewGuid());

            entity.GetType().SetEditingMode(false);

            return entity;
        }

        /// <summary>
        /// Detetes the object by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public virtual bool Delete(Guid key)
        {
            Entity entity;

            if (!Exists(key))
                throw new Exception("The object does not exist");

            entity = _UOW.GetObjectByKey<Entity>(key);

            _UOW.Delete(entity);
            _UOW.CommitChanges();

            return !Exists(key);
        }

        #endregion
    }
}
