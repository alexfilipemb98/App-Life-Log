using LifeLog.Core.Entities;
using LifeLog.Core.Interfaces;
using LifeLog.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

	public Task<(bool, string)> Save(User obj)
	{
		throw new NotImplementedException();
	}
}
