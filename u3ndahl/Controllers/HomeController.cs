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

        public List<Program> UniqueCategory()
        {
            var u = po.GetUnique();
            return u;
        }
        public ActionResult Unique()
        {
            var u = po.GetUnique();
            return View(u);
        }
        public ActionResult ShowProgram()
        {
            var model = po.GetPrograms();
            return PartialView(model);
        }
        public ActionResult ShowInfo(int? id)
        {
            var p = po.GetProgramById(id);
            return View(p);
        }
        //public string Chann()
        //{
        //    return "Kanal 1";
        //}

        public ActionResult Channel(int channel)
        {
            var p = po.GetChannel(channel);
            return PartialView(p);
        }

        public ActionResult ShowCategory(string category)
        {
            var c = po.GetCategory(category);
            return View(c);
            //var c = po.GetNavCategory(category);
            //return PartialView(c);
        }
        //[HttpPost]
        //public ActionResult ShowCategory(Program model)
        //{
        //    return View();
        //}
        



}
}