using LifeLog.Core.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace LifeLog.Data.Contexts;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext, IDisposable
{
    public DbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        string dbPath = Path.Combine(AppContext.BaseDirectory, "lifelog_database.db");
        string dbPassword = "yV7GqK5Yvgd0CWsJnfFRHjp7EtF0EJ";

        SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder
        {
            DataSource = dbPath,
            Password = dbPassword
        };

        optionsBuilder.UseSqlite(connectionStringBuilder.ToString());
    }

    DbSet<User> Users { get; set; }

}
