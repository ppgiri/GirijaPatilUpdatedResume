using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortfolioMVCproject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Education",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Education", action = "Education", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Experience",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Experience", action = "Experience", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Skills",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Skills", action = "Skills", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Hobbies",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Hobbies", action = "Hobbies", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Register",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Register", action = "Register", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "BasicDetail",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "BasicDetail", action = "BasicDetail", id = UrlParameter.Optional }
          );
        }
    }
}
