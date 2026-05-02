using LifeLog.Core.Enums;
using LifeLog.Core.Interfaces;
using LifeLog.Data.Contexts;
using LifeLog.Data.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;
using System;

namespace LifeLog.Data;

/// <summary>
/// Main engine class responsible for initializing the database and ensuring it is up to date with the latest migrations. 
/// This class should be instantiated at the start of the application to set up the data layer properly.
/// </summary>
public partial class Engine : IDisposable
{
    #region MAIN

    //PRIVATE
    private readonly IServiceProvider _ServiceProvider;
    private readonly AppDbContext _db;

    /// <summary>
    /// MAIN CONSTRUCTOR
    /// </summary>
    public Engine(string dbPath, string dbPassword, DatabaseTypeEnum dbtype)
    {
        Batteries_V2.Init();

        _db = new AppDbContext(dbPath, dbPassword, dbtype);
        _db.Database.EnsureCreated();
        _db.Database.Migrate();

        ServiceCollection services = new();

        services.AddSingleton<AppDbContext>(_ => _db);

        services.AddTransient<IUserRepo, UserRepo>();

        _ServiceProvider = services.BuildServiceProvider();
    }

    #endregion

    /// <summary>
    /// User repository for managing user-related data operations. 
    /// </summary>
    public IUserRepo Users => _ServiceProvider.GetRequiredService<IUserRepo>();
    
    #region FUNCTIONS

    /// <summary>
    /// Dispose
    /// </summary>
    public void Dispose()
    {
        _db?.Dispose();
    } 

    #endregion
}
