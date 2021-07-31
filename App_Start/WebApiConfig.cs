using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Areas.HelpPage;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Uncomment the following to use the documentation from XML documentation file.
            config.SetDocumentationProvider(
                     new XmlDocumentationProvider(
                         HttpContext.Current.Server.MapPath("~/bin/WebApi.xml")));
        }
    }
}
