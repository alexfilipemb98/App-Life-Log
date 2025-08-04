using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Swashbuckle.Application;
using System.Net.Http.Headers;
using Microsoft.Owin.Cors;
using Newtonsoft.Json;
using LifeLog.Services.Api.Helpers;

[assembly: OwinStartup(typeof(LifeLog.Services.Api.Startup))]

namespace LifeLog.Services.Api
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Ativa CORS
			app.UseCors(CorsOptions.AllowAll);

			// Configuração Web API
			HttpConfiguration config = new HttpConfiguration();

			// Swagger
			config.EnableSwagger(c =>
			{
				c.SingleApiVersion("v1", "LifeLog API");
			})
			.EnableSwaggerUi();

			// Rotas
			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			// JSON + Ignorar ciclos + Ignorar propriedades técnicas de XPO
			System.Net.Http.Formatting.JsonMediaTypeFormatter json = config.Formatters.JsonFormatter;
			json.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
			json.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			json.SerializerSettings.ContractResolver = new XpoSafeContractResolver();

			// Remove XML
			config.Formatters.Remove(config.Formatters.XmlFormatter);

			// Liga Web API ao pipeline OWIN
			app.UseWebApi(config);
		}
	}


}
