using LifeLog.Core.Entities;
using LifeLog.Core.Interfaces;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.Data.Repos;

internal class UserRepo : IUserRepo
{
    #region MAIN

    private AppDbContext _db;

    public UserRepo(AppDbContext db)
    {
        _db = db;
    }

    #endregion

    #region BASE

    public string TableName => "Users";

    public Task<(bool, string)> Delete(Guid key)
    {
        throw new NotImplementedException();
    }

    public Task<(User, string)> Duplicate(Guid key)
    {
        throw new NotImplementedException();
    }

    public Task<(bool, string)> Exists(Guid key)
    {
        throw new NotImplementedException();
    }

    public Task<(List<User>, string)> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<(User, string)> GetByKey(Guid key)
    {
        throw new NotImplementedException();
    }

    public Task<(User, string)> GetLast()
    {
        throw new NotImplementedException();
    }
    public Task<(bool, string)> Save(User obj)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region AUTH

    public Task<(bool registered, string message)> Register(RegisterModel model)
    {
        bool valid = model.IsValid(out string message);
        
        if (!valid)
            return Task.FromResult((false, message));

        if (_db.Users.Any(u => u.Email == model.Email))
            return Task.FromResult((false, "A user with this email already exists."));

        string salt = SecurityUtil.GenerateSalt();
        string encryptedPassword = SecurityUtil.Sha512_EncryptPasswordWithSalt(model.Password!, salt);
        User newUser = new User
        {
            Id = Guid.NewGuid(),
            Username = model.Username!,
            Email = model.Email!,
            Password = encryptedPassword,
            Salt = salt
        };

        _db.Users.Add(newUser);
        _db.SaveChanges();

        return Task.FromResult((true, "Registration successful."));
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public Task<(bool logged, LoggedUserModel? user, string message)> Login(LoginModel model)
    {
        bool valid = model.IsValid(out string message);
        if (!valid)
            return Task.FromResult((false, (LoggedUserModel?)null, message));

        User? user = _db.Users.FirstOrDefault(u => u.Email == model.Email);

        if (user is null)
            return Task.FromResult((false, (LoggedUserModel?)null, "No user found with the provided email."));

        if (!SecurityUtil.CompareStringEncryptedWithSalt(model.Password, user.Password, user.Salt))
            return Task.FromResult((false, (LoggedUserModel?)null, "Incorrect password."));

        LoggedUserModel? loggedUser = new LoggedUserModel
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email
        };

        return Task.FromResult((true, (LoggedUserModel?)loggedUser, "Login successful."));
    }

    #endregion
}
