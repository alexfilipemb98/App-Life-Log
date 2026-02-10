using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LifeLog.Services.Api;

/// <summary>
/// Web API engine for managing the application lifecycle
/// </summary>
public sealed class Engine : IAsyncDisposable
{

    #region MAIN

    //PRIVATE
    private WebApplication? _app;

    /// <summary>
    /// Starts the web application for a json file asynchronously
    /// </summary>
    /// <param name="connection">Database connection</param>
    /// <param name="url">URL to host the application</param>
    public async Task StartAsync(string url, string jsonFile)
    {
        if (_app != null) return;

        WebApplicationBuilder builder = WebApplication.CreateBuilder(new WebApplicationOptions
        {
            ApplicationName = typeof(Engine).Assembly.FullName
        });

        // Configure URL
        builder.WebHost.UseUrls(url);

        builder.Services.AddCors(opt =>
         opt.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

        // Build application
        _app = builder.Build();

        _app.UseCors("AllowAll");

        _app.MapGet("/json", async () =>
        {
            if (!File.Exists(jsonFile))
                return Results.NotFound("File not found");

            string json = await File.ReadAllTextAsync(jsonFile);
            return Results.Content(json, "application/json");
        });

        await _app.StartAsync();
    }

    /// <summary>
    /// Stops the web application asynchronously
    /// </summary>
    public async Task StopAsync()
    {
        if (_app == null) return;
        await _app.StopAsync();
        await _app.DisposeAsync();
        _app = null;
    }

    /// <summary>
    /// Disposes the engine asynchronously
    /// </summary>
    public async ValueTask DisposeAsync() => await StopAsync();

    #endregion
}