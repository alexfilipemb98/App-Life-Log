using Autofac;
using Autofac.Integration.WebApi;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.Data.Database.Queries;
using LifeLog.Data.Models;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using Swashbuckle.Application;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(LifeLog.Services.Api.Startup))]

namespace LifeLog.Services.Api
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			HttpConfiguration config = new HttpConfiguration();

			// --- Only JSON + experiência amigável no browser ---
			config.Formatters.Remove(config.Formatters.XmlFormatter);
			// Responder JSON mesmo quando o browser envia Accept: text/html
			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
			// (Opcional) Ajustes de serialização
			Newtonsoft.Json.JsonSerializerSettings json = config.Formatters.JsonFormatter.SerializerSettings;
			json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
			json.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
			json.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
			json.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

			// --- Rotas ---
			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{action}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			// --- Swagger ---
			config.EnableSwagger(c =>
			{
				c.SingleApiVersion("v1", "Life Log API");
				c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
				// c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\LifeLog.Services.Api.xml");
			})
			.EnableSwaggerUi();

			// --- Dependencies ---
			ContainerBuilder builder = new ContainerBuilder();

			// regista o NotesQuery
			builder.RegisterType<NotesQuery>()
				   .As<INotesQuery<NotesModel, Guid>>()
				   .InstancePerRequest();

			// regista todos os controllers do assembly
			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			IContainer container = builder.Build();
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

			// integra o Autofac no OWIN
			app.UseAutofacMiddleware(container);
			app.UseAutofacWebApi(config);

			// --- OWIN pipeline: CORS antes do WebApi ---
			app.UseCors(CorsOptions.AllowAll);
			app.UseWebApi(config);
		}
	}
}