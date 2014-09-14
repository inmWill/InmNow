using System.Web.Http;
using System.Web.Http.Cors;
using InmNow.Service.Services;
using Microsoft.Practices.Unity;
using InmNow.API.Resolver;
using InmNow.Service.Interfaces;
using Newtonsoft.Json;

namespace InmNow.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services 
            var container = new UnityContainer();

            // Business layer collectives 
            container.RegisterType<IInmAbstractsService, InmAbstractsService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserNotificationService, UserNotificationServiceService>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);


            config.MapHttpAttributeRoutes();
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            json.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API routes
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
