using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTHeadBrewingCo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Beers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Your where to buy page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}