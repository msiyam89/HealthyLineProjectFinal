using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;


namespace HealthyLineProject.Controllers
{
    public class AccountController : BaseController
    {
       

        //
        // GET: /Account/
        public ActionResult Signin()
        {
            return View();
        }

        //[HttpPost]
             //public ActionResult Signin(Models.SigninModel model)
             //{

             //    //if (ModelState.IsValid)
             //    //{
                  

             //    //    User user = null;
             //    //    using (DAContext ctx = new DAContext())
             //    //    {
             //    //        user = ctx.Users.SingleOrDefault(x => x.Email == model.Username && x.Password == model.Password);
             //    //    }

             //    //    if (user != null)
             //    //    {
             //    //         FormsAuthentication.SetAuthCookie(user.Email, true);
                         
             //    //        return Redirect("~");
             //    //   }
             //    //    else
             //    //    {
             //    //        return View();
             //    //    }
             //    //}
             //    //else
             //    //{
             //    //    return View();
             //    //}

             //}

        public ActionResult Signup()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Signup(Models.SignupModel model)
        //{
        //    ViewBag.Error = "";
        //    if (ModelState.IsValid)
        //    {
        //            User user = new User
        //            {
        //                Fullname = model.Fullname,
        //                Gender = (DataAccess.Gender)model.Gender,
        //                Email = model.Email,
        //                Password = model.Password
        //            };

        //            try
        //            {
        //                using (DAContext ctx = new DAContext())
        //                {
        //                    if (ctx.Users.Where(x => x.Email == model.Email).Count() > 0)
        //                    {
        //                        ViewBag.Erroe = "User already exists.";
        //                    }
        //                    else
        //                    {
        //                        user = ctx.Users.Add(user);
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                ViewBag.Error = ex.Message;
        //            }

        //    }




        //    return View();
        //}
        public ActionResult Signout() {
            FormsAuthentication.SignOut();
            return Redirect("~");
         
        }
        
            
       


    }

}
