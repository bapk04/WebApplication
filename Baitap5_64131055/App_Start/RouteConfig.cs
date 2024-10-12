using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Baitap5_64131055
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //// Route cho Nhanvien_64131055
            //routes.MapRoute(
            //    name: "RegisterEmp",
            //    url: "Nhanvien_64131055/{action}/{id}",
            //    defaults: new { controller = "Nhanvien_64131055", action = "RegisterEmp", id = UrlParameter.Optional }
            //);

            //// Route cho MailInfor_64131055
            //routes.MapRoute(
            //    name: "SendMail",
            //    url: "MailInfor_64131055/{action}/{id}",
            //    defaults: new { controller = "MailInfor_64131055", action = "SendMail", id = UrlParameter.Optional }
            //);

            //// Route cho Changbanner_64131055
            //routes.MapRoute(
            //    name: "ChangeBanner",
            //    url: "Changbanner_64131055/{action}/{id}",
            //    defaults: new { controller = "Changbanner_64131055", action = "ChangeBanner", id = UrlParameter.Optional }
            //);

            // Route mặc định
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

}
