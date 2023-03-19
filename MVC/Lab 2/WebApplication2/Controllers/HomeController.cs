using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
       
      

       
        public ActionResult viewDetails(int id, string name, string source)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.source = source;
            return View();
        }

    }
}