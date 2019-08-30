using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Videly
{
    public class RouteConfig
    {
        /// <summary>
        /// This Default route({controller}/{action}/{id}) in the application works for the most of the scenarios
        /// But there is situation we need a route with multiple parameters for eg movies/release/2015/20 -Custom route
        /// Cleaner way of creating custom routes - Attribute routing
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "MoviewByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" }, 
            //    new { year =@"\d{4}", month =@"\d{2}"}); //custom route in asp.net mvc

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
