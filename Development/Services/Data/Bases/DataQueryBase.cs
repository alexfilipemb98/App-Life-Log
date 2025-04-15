using Core.Extensions;
using Core.Interfaces;
using Data.ORM.DataModelCode;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static Dapper.SqlMapper;

namespace Data.Bases
{
    /// <summary>
    /// Data Query Base
    /// </summary>
    /// <typeparam name="Model"></typeparam>
    public abstract class DataQueryBase<Model> : IBaseQuery<Model, Guid> where Model : BasePersistentObject
    {
        #region MAIN

        //PROPERTIES

        internal UnitOfWork _UOW { get; private set; }
        internal DataSqlAccessBase _SQL { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public DataQueryBase(UnitOfWork uow, DataSqlAccessBase sql)
        {
            _UOW = uow;
            _SQL = sql;
        }

        #endregion

        #region INTERFACES

        public virtual string TableName => typeof(Model).GetTableName() ?? "Model";

        public virtual IQueryable<Model> QueryBase =>
             _UOW.Query<Model>();

        public virtual bool TableExists(out string message)
        {
            string query = string.Empty;
            string? tableName = typeof(Model).GetTableName();

            if (string.IsNullOrWhiteSpace(tableName))
            {
                message = "Table name is null or empty.";
                return false;
            }

            if (_SQL.IsSqlite)
            {
                query = $@"
                    SELECT CASE 
                        WHEN EXISTS (SELECT 1 FROM sqlite_master WHERE type='table' AND name='{tableName}') 
                        THEN 1 ELSE 0 
                    END AS TableExists;
                ";
            }
            else
            {
                query = $@"
                    SELECT CASE 
                        WHEN EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}') 
                        THEN 1 ELSE 0 
                    END AS TableExists;            
                ";
            }

            bool results = _SQL.GetValue<bool>(query);

            message = results ? "Table exists" : "Table does not exist";
            return results;
        }

        public virtual bool Exists(Guid key, out string message)
        {
            bool exists = _UOW.GetObjectByKey<Model>(key) != null;
            message = exists ? $"{TableName} exists!" : $"{TableName} does not exist!";
            return exists;
        }

        public virtual Model GetByKey(Guid key, out string message)
        {
            Model entity = _UOW.GetObjectByKey<Model>(key);
            message = entity == null ? $"{TableName} not found!" : $"{TableName} found!";
            return entity;
        }

        public virtual List<Model> GetAll(out string message)
        {
            List<Model> results = QueryBase.ToList();
            message = results.Count > 0 ? $"{TableName} found ({results.Count})!" : $"{TableName} not found!";
            return results;
        }

        public virtual Model GetLast(out string message)
        {
            Model? entity = QueryBase.OrderByDescending(x => x.CreatedAt).FirstOrDefault();
            message = entity == null ? $"{TableName} not found!" : $"{TableName} found!";
            return entity;
        }

        public virtual bool Save(Model obj, out string message)
        {
            if (!obj.IsValid(out List<ValidationResult> results))
                throw new Core.Exceptions.ValidationException(results);

            obj.SavingMode = true;

            _UOW.Save(obj);
            _UOW.CommitChanges();

            message = !obj.SavingMode ? $"{TableName} saved!" : $"{TableName} was not saved!";
            return !obj.SavingMode;
        }

        public virtual Model Duplicate(Guid key, out string message)
        {
            Model entity;

            if (!Exists(key, out message))
                throw new Exception(message);

            entity = _UOW.GetObjectByKey<Model>(key);

            PropertyInfo keyinfo = entity.GetType().GetKey();
            keyinfo.SetValue(entity, Guid.NewGuid());

            entity.GetType().SetEditingMode(false);

            return entity;
        }

        public virtual bool Delete(Guid key, out string message)
        {
            if (!Exists(key, out message))
                return false;

            Model entity = _UOW.GetObjectByKey<Model>(key);

            _UOW.Delete(entity);
            _UOW.CommitChanges();

            bool deleted = !Exists(key, out _);
            message = deleted
                ? $"{TableName} has been deleted."
                : $"Unable to delete the {TableName}!";

            return deleted;
        }

        #endregion
    }
}
