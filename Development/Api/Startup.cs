using Owin;
using Swashbuckle.Application;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            // Configura para retornar apenas JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Configuração de rota padrão
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Configuração do Swagger
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Life Log API");
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            })
            .EnableSwaggerUi();

            config.MapHttpAttributeRoutes();

            // Usa o Web API com OWIN
            appBuilder.Use(config);
        }
    }
}
