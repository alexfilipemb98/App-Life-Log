using Data.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
    /// <summary>
    /// Database helper
    /// </summary>
    public static class DbHelper
    {
        public static List<string> GetDatabases(string connectionString)
        {
            using (SqlDataAccessBase dataAccess = new SqlDataAccessBase(connectionString))
            {
                return  dataAccess.LoadDataList<string>("SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')");
            }
        }

    }
}
