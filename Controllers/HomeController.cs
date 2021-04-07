using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();

        }
        public string msg(string name)
        {
            return "welcome " + name;
        }

        public ContentResult message(string name)
        {
            return Content("Welcome " + name);
        }

        public void dummy()
        {
            int i = 10;
        }

        public EmptyResult dum()
        {
            ViewBag.i = 10;
            ViewBag.j = 20;
            return new EmptyResult();
        }

        public ViewResult Sample()
        {
            dum();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}