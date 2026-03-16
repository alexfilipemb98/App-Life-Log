using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLog.Data.Contexts;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext IDisposable
{
    public DbContext()
    {
    }

}
