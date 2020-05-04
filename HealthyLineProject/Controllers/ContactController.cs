using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLineProject.Controllers
{
    public class ContactController : BaseController
    {
        //
        // GET: /Contact/

        public ActionResult Page4()
        {
            ViewBag.Title = "Contact";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Models.ContactUsModel model)
        {
            if (ModelState.IsValid)
            {
                //Message message = new Message
                //   {
                //       Name = model.Name,

                //       Number = model.Number,
                //       Emaill = model.Emaill,
                //       Subject = model.Subject,
                //       MessageText = model.Message

                //   };

            }
            return View();
        }

    }
}
