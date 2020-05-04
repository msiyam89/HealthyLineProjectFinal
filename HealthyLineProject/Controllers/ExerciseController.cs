using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLineProject.Controllers
{
    public class ExerciseController : BaseController
    {
        //
        // GET: /Exercise/
        public ActionResult Exercise()
        {
            ViewBag.Title = "Exercise";

            return View();
        }


    }
}
