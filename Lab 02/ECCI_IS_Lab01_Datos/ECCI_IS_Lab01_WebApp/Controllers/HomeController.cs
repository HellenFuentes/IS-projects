using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ECCI_IS_Lab01_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message2 = "Your application description page 2.";
            return View("About");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View("Contact");
        }
    }
}