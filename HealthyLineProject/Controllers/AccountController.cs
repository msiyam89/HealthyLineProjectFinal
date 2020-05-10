using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;
using HealthyLineProject.Models;

namespace HealthyLineProject.Controllers
{
    public class AccountController : BaseController
    {


        //
        // GET: /Account/
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(Models.SigninModel model)
        {

            if (ModelState.IsValid)
            {
                var result = BusinessLayer.UserProfileBE.Instance.SignIn(model.UserName, model.Password);
                if (result != null)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, true);

                    return RedirectToAction("IdealWeight");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Models.UserProfileModel model)
        {

            if (ModelState.IsValid)
            {
               
                var result = BusinessLayer.UserProfileBE.Instance.Signup(model.BirthDate,model.Confirm,model.Email,model.FullNameArabic,model.FullNameEnglish,model.Gender,model.MobileNumber,model.Password,model.UserName);
                if (result != null)
                {
                   return Redirect("~/");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }

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
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~");

        }

        //private ActionResult View(Func<ActionResult> idealWeight, Func<string, ContentResult> content)
        //{
        //    throw new NotImplementedException();
        //}
        [Authorize]
        public ActionResult IdealWeight()
        {
            ViewBag.Title = "IdealWeight";

            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult IdealWeight(IdealWeightModel model)
        {

            float BMI =( model.weight / (model.Height * model.Height))*10000;
            ViewBag.Title = "BMI";
            model.BMI = BMI;
            //float IdealWeight;
            if (model.Gender == true)
            {
                float IdealWeight = model.Height - 100;
                ViewBag.Title = "IdealWeight";
                model.IdealWeight = IdealWeight;

            }
            else
            {
                float IdealWeight = model.Height - 110;
                ViewBag.Title = "IdealWeight";
                model.IdealWeight = IdealWeight;

            }






            DataAccessLayer.UserProfile userProfile = new DataAccessLayer.UserProfile
            {
                UserName = User.Identity.Name,
                
                Height = model.Height,
                IdealWeight = model.IdealWeight,
                Gender =model.Gender

            };

            return View(model);
        }




    }

}
