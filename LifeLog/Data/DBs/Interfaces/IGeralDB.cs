using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.DBs.Interfaces;

public interface IGeralDB
{
	Task<List<T>> LoadSql<T>(string sql);

	Task<T?> ExecuteSql<T>(string sql);
}
