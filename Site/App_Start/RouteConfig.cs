using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Editor", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DeleteReport",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Editor", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CreatePdf",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pdf", action = "MakePdf", id = UrlParameter.Optional }
            );
        }
    }
}