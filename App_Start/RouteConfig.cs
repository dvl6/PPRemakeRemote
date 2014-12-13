using System.Web.Mvc;
using System.Web.Routing;

namespace IdentitySample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               "{Username}",                                           // Route name
               "{Username}/{Action}/{Id}",                            // URL with parameters
               new { controller = "Account", action = "{action}", id=UrlParameter.Optional}  // Parameter defaults
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


           
        }
    }
}