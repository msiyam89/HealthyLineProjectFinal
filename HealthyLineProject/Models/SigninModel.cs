using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLineProject.Models
{
    public class SigninModel 
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Resource))]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
       
    }
}
