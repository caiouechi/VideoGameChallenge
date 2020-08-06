using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace VideoGameWebAPIS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
            name: "DefaultApiWithAction",
            routeTemplate: "api/{controller}/{action}/{name}",
            defaults: new { name = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
