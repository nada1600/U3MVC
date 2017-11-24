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
        private ProgramOp po = new ProgramOp();

        // GET: Home
        public ActionResult Index()
        {

            //Program p = new Program();
            //p.title = "Program1";
            var model = po.GetP();

            return View(model);
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

        public ActionResult ShowProgram()
        {
            
            return View();
        }
    }
}