using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Data.Helpers;
using LifeLog.Data.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using SQLitePCL;
using System.Data;

namespace LifeLog.Data;

/// <summary>
/// Data engine
/// </summary>
public class Engine : IDisposable
{
    #region MAIN

    //PRIVATE
    private readonly IServiceProvider ServiceProvider;

    //PUBLIC
    public IDbConnection Connection { get; private set; }
    public string DBName { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="configs"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public Engine(DatabaseConfigModel configs)
    {
        if (configs == null)
            throw new ArgumentNullException("Configs for data base are null");

        if (!configs.IsValid())
            throw new ArgumentException("Configurations are not valid");

        string? conn = configs.ToString();

        if (string.IsNullOrWhiteSpace(conn))
            throw new ArgumentNullException("Connection string is empty!");

        conn = $"XpoProvider={configs.XpoProvider()};{conn}";

        Batteries_V2.Init();

        DbHelper.GenerateStore(conn, out IDataStore provider, out ReflectionDictionary dictionary);

        DbHelper.UpdateDB(provider, dictionary);

        Connection = DbHelper.ConnectDb(provider, dictionary);

        DBName = configs.DatabaseType == DatabaseTypeEnum.SQLLITE
            ? $"(local) {Path.GetFileNameWithoutExtension(((SqliteConnection)Connection).DataSource)}"
            : ((SqlConnection)Connection).Database;

        ServiceCollection services = new();

        services.ConfigureServices(Connection);

        ServiceProvider = services.BuildServiceProvider();
    }

    #endregion

    #region CONTEXT

    //Users
    public IUserRepository Users => ServiceProvider.GetRequiredService<IUserRepository>();

    //Geral
    public IDataRepository Geral => ServiceProvider.GetRequiredService<IDataRepository>();

    //Notes
    public INoteRepository Notes => ServiceProvider.GetRequiredService<INoteRepository>();

    //Tasks
    public ITodoRepository Tasks => ServiceProvider.GetRequiredService<ITodoRepository>();

    //ExternalPrograms
    public IExternalProgramRepository ExternalPrograms => ServiceProvider.GetRequiredService<IExternalProgramRepository>();

    //Commands
    public ICommandRepository Commands => ServiceProvider.GetRequiredService<ICommandRepository>();

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Dispose
    /// </summary>
    public void Dispose()
    {
        Connection.Dispose();
    }

    #endregion
}
