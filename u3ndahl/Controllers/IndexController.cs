using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u3ndahl.Models;

namespace u3ndahl.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            Program p = new Program();
            p.title = "Program1";

            return View();
        }

        public string Chann()
        {
            return "Kanal 1";
        }

        public ActionResult Channel()
        {
            return PartialView();
        }
    }
}