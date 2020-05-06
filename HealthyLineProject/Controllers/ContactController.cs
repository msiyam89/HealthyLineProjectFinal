using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();

                message.From = new MailAddress(model.UserEmail, model.UserName);
                message.To.Add(new MailAddress("manaralkurdi98@gmail.com","HealthyLine"));
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FullNameArabic, model.UserEmail, model.Messaage);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "manaralkurdi98@gmail.com",  // replace with valid value
                        Password = "MANAR31601002008"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    smtp.Send(message);

                    return Redirect("~/");
                }

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
