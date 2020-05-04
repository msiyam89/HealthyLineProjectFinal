using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using HealthyLineProject.Helper;
using R;

namespace HealthyLineProject.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult ChangeCurrentCulture(int id)
        {

            CultureHelper.CurrentCulture = id;

            Session["CurrentCulture"] = id;

            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home page";
            return View();

        }

        private ActionResult View(Func<ActionResult> idealWeight, Func<string, ContentResult> content)
        {
            throw new NotImplementedException();
        }   
        //public ActionResult IdealWeight()
        //{
        //    ViewBag.Title = "IdealWeight";

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult IdealWeight(IdealWeightModel model)
        //{
        //    decimal ideal = model.weight / (model.height * model.height);
        //    ViewBag.Title = "IdealWeight";

        //    return View();
        //}
      
    }


}