using LifeLog.Core.Entities;
using LifeLog.Core.Interfaces;
using LifeLog.Core.Models;
using LifeLog.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.Data.Repos;

internal class UserRepo : IUserRepo
{
    private DbContext _db;

    public UserRepo(DbContext db)
    {
        _db = db;
    }

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

    public Task<(bool logged, LoggedUserModel? user, string message)> Login(object value1, object value2)
    {
        throw new NotImplementedException();
    }

    public Task<(bool, string)> Save(User obj)
    {
        throw new NotImplementedException();
    }
}
