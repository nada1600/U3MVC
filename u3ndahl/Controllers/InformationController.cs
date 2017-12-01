using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u3ndahl.Models;

namespace u3ndahl.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult Contact(Message model)
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}