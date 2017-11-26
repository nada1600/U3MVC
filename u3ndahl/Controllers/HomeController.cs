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
            //return View();
            var model = po.GetPrograms();
            return View(model);

        }

        public ActionResult ShowProgram()
        {
            var model = po.GetPrograms();
            return PartialView(model);
        }
        public ActionResult ShowInfo(int id)
        {
            var p = po.GetProgramById(id);
            return View(p);
        }
        public string Chann()
        {
            return "Kanal 1";
        }
        public ActionResult _Channel1(int id = 1)
        {
            var model = po.GetChannel(id);

            return View(model);
            //return PartialView();      
        }
        public ActionResult _Channel2(int id = 2)
        {
            var model = po.GetChannel(id);
            return PartialView(model);      
        }
        public ActionResult _Channel3(int id = 3)
        {
            var p = po.GetChannel(id);
            return PartialView(p);    
        }

        public ActionResult Channel(int id = 1)
        {
            var p = po.GetChannel(id);
            return PartialView(p);
        }
        public ActionResult Channel4(int channel = 0)
        {
            //var p = po.GetChannel(id);
            //return PartialView(p);
            var o = po.GetC(1);
            return PartialView(o);
        }

        public ActionResult ShowCategory(string category = "Nyheter")
        {
            var c = po.GetCategory(category);
            return View(c);
        }

        
    }
}