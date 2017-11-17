using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace u3ndahl
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "Home",
                url: "Hem",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "Kategori",
                defaults: new { controller = "Index", action = "Category", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "None",
                url: "",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );



            /*---------------------------*/
            //DO NOT TOUCH THIS CODE BELOW!
            //This code will always be the last in line.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
