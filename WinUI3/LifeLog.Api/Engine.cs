using LifeLog.Services.Api.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.WebUI;

namespace LifeLog.Services.Api;

/// <summary>
/// Web API engine for managing the application lifecycle
/// </summary>
public sealed class Engine : IAsyncDisposable
{
    //CONSTANTS
    internal const string JwtKey = "hLzKwn1m05QHwzfKX651u831J2dPnTGmuIXbcol3cBYDx4GMp1";
    internal const string JwtIssuer = "Web_Api";
    internal const string JwtAudience = "Web_Api_Clients";
    internal const int JwtRefreshTokenDays = 7;
    internal const int JwtAccessTokenMinutes = 15;

    #region MAIN

    //PRIVATE
    private WebApplication _app;

    /// <summary>
    /// Starts the web application asynchronously
    /// </summary>
    /// <param name="connection">Database connection</param>
    /// <param name="url">URL to host the application</param>
    public async Task StartAsync(IDbConnection connection, string url)
    {
        if (_app != null) return;

        WebApplicationBuilder builder = WebApplication.CreateBuilder(new WebApplicationOptions
        {
            ApplicationName = typeof(Engine).Assembly.FullName
        });

        // Configure URL
        builder.WebHost.UseUrls(url);

        // Configure services
        ConfigureServices(builder.Services, JwtKey, JwtIssuer, JwtAudience, connection);

        // Build application
        _app = builder.Build();

        // Configure middleware pipeline
        ConfigureMiddleware(_app);

        await _app.StartAsync();
    }

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

        _app.MapGet("/", async () =>
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

    #region FUNCTIONS

    /// <summary>
    /// Configures application services
    /// </summary>
    private static void ConfigureServices(IServiceCollection services, string jwtKey, string jwtIssuer, string jwtAudience, IDbConnection connection)
    {
        // Add controllers and API explorer
        services.AddControllers();
        services.AddEndpointsApiExplorer();

        // Configure JWT authentication
        ConfigureAuthentication(services, jwtKey, jwtIssuer, jwtAudience);

        // Add token services
        services.AddSingleton<IRefreshTokenStore, InMemoryRefreshTokenStore>();
        services.AddScoped<ITokenService, TokenService>();

        // Configure JSON serialization
        ConfigureJsonSerialization(services);

        // Configure CORS
        ConfigureCors(services);

        // Configure Swagger
        ConfigureSwagger(services);

        // Configure database services
        services.ConfigureServices(connection);

        // Add authorization
        services.AddAuthorization();
    }

    /// <summary>
    /// Configures JWT authentication
    /// </summary>
    private static void ConfigureAuthentication(IServiceCollection services, string jwtKey, string jwtIssuer, string jwtAudience)
    {
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtIssuer,
                    ValidAudience = jwtAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });
    }

    /// <summary>
    /// Configures JSON serialization with Newtonsoft.Json
    /// </summary>
    private static void ConfigureJsonSerialization(IServiceCollection services)
    {
        services.AddControllers()
            .AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                o.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                o.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
    }

    /// <summary>
    /// Configures CORS policy to allow all origins
    /// </summary>
    private static void ConfigureCors(IServiceCollection services)
    {
        services.AddCors(opt =>
            opt.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
    }

    /// <summary>
    /// Configures Swagger/OpenAPI documentation
    /// </summary>
    private static void ConfigureSwagger(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(o =>
        {
            o.EnableAnnotations();

            o.CustomSchemaIds(type =>
               type.GetCustomAttribute<SwaggerSchemaAttribute>()?.Title ?? type.Name
            );

            o.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Life Log API",
                Version = "v1",
                Description = "Simple API integration"
            });

            // Include XML comments if available
            string xml = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            string xmlPath = Path.Combine(AppContext.BaseDirectory, xml);
            if (File.Exists(xmlPath))
                o.IncludeXmlComments(xmlPath);

            // Configure JWT Bearer authentication
            o.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Description = "Enter: Bearer {your_token}"
            });

            // Add security requirement for Swashbuckle v10 / .NET 10
            o.AddSecurityRequirement(document => new OpenApiSecurityRequirement
            {
                [new OpenApiSecuritySchemeReference("Bearer", document)] = []
            });
        });
    }

    /// <summary>
    /// Configures the middleware pipeline
    /// </summary>
    private static void ConfigureMiddleware(WebApplication app)
    {
        // Enable CORS
        app.UseCors("AllowAll");

        // Enable Swagger UI
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
            c.DocumentTitle = "API - Life Log";
            c.DisplayRequestDuration();
            c.RoutePrefix = "";
            c.EnablePersistAuthorization();
        });

        // Enable authentication and authorization
        app.UseAuthentication();
        app.UseAuthorization();

        // Enable HTTPS redirection
        app.UseHttpsRedirection();

        // Map controllers
        app.MapControllers();
        app.MapControllerRoute(
            name: "DefaultApi",
            pattern: "api/{controller}/{action}/{id?}"
        );
    }

    #endregion
}