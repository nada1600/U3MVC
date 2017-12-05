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
            var model = po.GetPrograms();
            return View(model);
        }

        //Program
        public ActionResult ShowProgram()
        {
            //Sortera programlistan (A-Ö)
            var model = po.GetPrograms();
         
            return PartialView(model);
        }

        //Visar detaljer för angivet program
        public ActionResult ShowInfo(int? id)
        {
            var p = po.GetProgramById(id);
            return View(p);
        }

        //Kanalernas programlistor presenteras via "partialViews" på Index-vyn.
        public ActionResult _Channel(int channel)
        {
            var p = po.GetChannel(channel);
            return PartialView(p);
        }

        //Vald kategori presenteras i nuläget i en separat vy.
        public ActionResult ShowCategory(string category)
        {
            var c = po.GetCategory(category);
            return View(c);
        }

        //Visar program beroende av kanal och kategori. (Användes ej i nuläget.)
        public ActionResult ShowCategoryByChannel(int channel, string category)
        {
            var cc = po.GetChannelAndCategory(channel, category);
            return PartialView(cc);
        }



    }
}