using LifeLog.Core.Entities;
using LifeLog.Core.Enums;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace LifeLog.Data.Contexts;

/// <summary>
/// Data
/// </summary>
internal class AppDbContext : DbContext, IDisposable
{
    //PRIVATE
    private string _dbPath;
    private string _dbPassword;
    private DatabaseTypeEnum _dbType;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="dbPath"></param>
    /// <param name="dbPassword"></param>
    /// <param name="dbtype"></param>
    internal AppDbContext(string dbPath, string dbPassword, DatabaseTypeEnum dbtype)
    {
        _dbPath = dbPath;
        _dbPassword = dbPassword;
        _dbType = dbtype;
    }

    /// <summary>
    /// On Configuring method to set up the database.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    /// <exception cref="NotSupportedException"></exception>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        switch (_dbType)
        {
            case DatabaseTypeEnum.SQLLITE:
                SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder
                {
                    DataSource = _dbPath,
                    Password = _dbPassword
                };

                optionsBuilder.UseSqlite(connectionStringBuilder.ToString());
                break;
            case DatabaseTypeEnum.MSSQL:
                //TODO: Implement MSSQL connection string and options
                break;
            default:
                throw new NotSupportedException($"Database type {_dbType} is not supported.");
        }
  
    }

    /// <summary>
    /// Users
    /// </summary>
   internal DbSet<User> Users { get; set; }

}
