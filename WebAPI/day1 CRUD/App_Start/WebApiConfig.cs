using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace day1_CRUD
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ///to serialize objects in it
            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            //config.Formatters.Remove(config.Formatters.XmlFormatter);


            // Web API routes
            config.MapHttpAttributeRoutes();//[]
            //{controller}/{action}/{id}
            config.Routes.MapHttpRoute(
                name: "DefaultRPC",
                routeTemplate: "RPC/{controller}/{action}/{id}",//action map http Verb "Get GetAll Post Put Delete
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",//action map http Verb "Get GetAll Post Put Delete
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
