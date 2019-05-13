using FacebookClone.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FacebookClone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           
            routes.MapRoute("Home","", new { controller = "Home", action = "Index" });
            routes.MapRoute("Reg", "reg", new { controller = "Register", action = "Reg" });
            routes.MapRoute("olusturuldu", "olusturuldu", new { controller = "Register", action = "Reg" });
            routes.MapRoute("akis", "akis", new { controller = "Post", action = "Akis" });
            routes.MapRoute("newpost", "newpost", new { controller = "Post", action = "NewPost" });



        }
    }
}
