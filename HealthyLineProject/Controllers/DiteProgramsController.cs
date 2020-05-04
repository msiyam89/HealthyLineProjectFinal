using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLineProject.Controllers
{
    public class DiteProgramsController : BaseController
    {
        public ActionResult Dietprogram()
        {
            ViewBag.Title = "Diet programs";
            return View();
        }
        public ActionResult Atkinsdiet()
        {
            return View();
        }
        public ActionResult Zonediet()
        {
            return View();
        }
        public ActionResult Ketogenicdiet()
        {
            return View();
        }
        public ActionResult Vegetariandiet()
        {
            return View();
        }

        public ActionResult Vegandiet()
        {
            return View();
        }
        public ActionResult WeightWatchersdiet()
        {
            return View();
        }
        public ActionResult SouthBeachdiet()
        {
            return View();
        }
        public ActionResult Rawfooddiet()
        {
            return View();
        }
        public ActionResult Mediterraneandiet()
        {
            return View();
        }


    }
}
