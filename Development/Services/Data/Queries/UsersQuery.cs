using Data.Bases;
using Data.ORM.DataModelCode;
using DevExpress.Xpo;
using Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Utils;
using Utils.Extensions;

namespace Data.Queries
{
    /// <summary>
    /// Users
    /// </summary>
    public class UsersQuery : DataQueryBase<ORM_Users>
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="sql"></param>
        public UsersQuery(UnitOfWork uow, DataSqlAccessBase sql) : base(uow, sql)
        {
        }

        #region QUERIES

        /// <summary>
        /// Register a new user
        /// </summary>
        /// <param name="model"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool RegisterUser(LoginModel model, out string message)
        {
            if (!model.IsValid(out List<ValidationResult> results))
                throw new Exceptions.ValidationException(results);

            ORM_Users newUser = new ORM_Users();

            newUser.Username = model.Username;
            newUser.Email = model.Email;
            newUser.Salt = SecurityUtil.GenerateSalt();
            newUser.Password = SecurityUtil.Sha512_EncryptPasswordWithSalt(model.Password, newUser.Salt);

            return Save(newUser, out message);
        }

        /// <summary>
        /// Validate user login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUserLogin(LoginModel model, out ORM_Users userModel, out string message)
        {
            if (!model.IsValid(out List<ValidationResult> results))
                throw new Exceptions.ValidationException(results);

            userModel = null;

            if (!model.Email.IsEmailValid())
            {
                message = "E-mail is not Valid!";
                return false;
            }

            ORM_Users user = QueryBase.FirstOrDefault(w => w.Email == model.Email);

            if (user == null)
            {
                message = "User not found!";
                return false;
            }

            if (!SecurityUtil.CompareStringEncryptedWithSalt(model.Password, user.Password, user.Salt))
            {
                message = "Login failed, password is incorrect!";
                return false;
            }

            userModel = user;

            message = "User is valid to login!";
            return true;
        }

        #endregion
    }
}
