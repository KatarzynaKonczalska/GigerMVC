using GigerEx.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GigerEx.Controllers
{
    public class BandsInfoController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        //private RegisterViewModel db = new RegisterViewModel();
        private GigDBContext db = new GigDBContext();

        public ActionResult Index()
        {
            var gigs = from m in db.Gigs
                       select m;

                gigs = gigs.Where(s => s.Band.Contains("Koniki Polne"));
           

            return View(gigs);
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        
    }
}