using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DBs.Interfaces;

public interface IGeralDB
{
	Task<List<T>> LoadSql(string sql);

	Task<T?> ExecuteSql<T>(string sql);
}
