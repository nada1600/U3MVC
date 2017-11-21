using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u3ndahl.Models;
using u3ndahl.Data;

namespace u3ndahl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Program p = new Program();
            p.title = "Program1";

            return View(p);
        }

        public string Chann()
        {
            return "Kanal 1";
        }
        public ActionResult _Channel1()
        {
            
            return PartialView();      

        }
        

        public ActionResult Channel()
        {
            return PartialView();
        }

        public ActionResult Category()
        {
            return View();
        }
    }
}