using LifeLog.Api;
using LifeLog.Data.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Data;

public sealed class ApiHost : IAsyncDisposable
{
	private WebApplication? _app;

	public async Task StartAsync(IDbConnection connection,string[]? urls = null)
	{
		if (_app != null) return;

		var builder = WebApplication.CreateBuilder(new WebApplicationOptions
		{
			ApplicationName = typeof(ApiHost).Assembly.FullName
		});

		if (urls is { Length: > 0 })
			builder.WebHost.UseUrls(urls);
		else
			builder.WebHost.UseUrls("http://localhost:5055"); // escolhe a porta

		// Controllers + NewtonsoftJson
		builder.Services.AddControllers()
			.AddNewtonsoftJson(o =>
			{
				o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
				o.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
				o.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
				o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			});

		// CORS AllowAll
		builder.Services.AddCors(opt =>
			opt.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

		// Swagger
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen(c =>
		{
			c.SwaggerDoc("v1", new() { Title = "Life Log API", Version = "v1" });
			c.ResolveConflictingActions(api => api.First());
		});

		builder.Services.ConfigureServices(connection);

		_app = builder.Build();

		_app.UseCors("AllowAll");

		_app.UseSwagger();
		_app.UseSwaggerUI(c =>
		{
			c.SwaggerEndpoint("/swagger/v1/swagger.json", "Life Log API v1");
		});

		_app.MapControllers();
		_app.MapControllerRoute(
			name: "DefaultApi",
			pattern: "api/{controller}/{action}/{id?}"
		);

		await _app.StartAsync();
	}

	public async Task StopAsync()
	{
		if (_app == null) return;
		await _app.StopAsync();
		await _app.DisposeAsync();
		_app = null;
	}

	public async ValueTask DisposeAsync() => await StopAsync();
}
