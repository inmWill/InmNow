using InmNow.Logic.Collectives;
using InmNow.Logic.Interfaces;
using InmNow.Repository.Interfaces;
using InmNow.Repository.Repositories;
using InmNow.WebAPI.Resolver;
using InmNow.Domain;
using InmNow.Logic;
using InmNow.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;


namespace InmNow.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services 
            var container = new UnityContainer();
         
            // Business layer collectives 
            container.RegisterType<IInmAbstractsCollective, InmAbstractsCollective>(new HierarchicalLifetimeManager());
            
            config.DependencyResolver = new UnityResolver(container);

            
            config.MapHttpAttributeRoutes();
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
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