using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace MQMS
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute(
                "uom_route",
                "Uom/{id}",
                "~/Views/Maintenance/Uom.aspx",
                false,
                new RouteValueDictionary { { "id", string.Empty } }); //allow for no values




        }
    }
}
