using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class ContactUsModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }

        [Display(Name = "UserEmail", ResourceType = typeof(Resource))]
        [Required]
        public string UserEmail { get; set; }
        [Display(Name = "FullNameArabic", ResourceType = typeof(Resource))]
        [Required]
        public string FullNameArabic { get; set; }
        [Display(Name = "FullNameEnglish", ResourceType = typeof(Resource))]
        public string FullNameEnglish { get; set; }
        [Display(Name = "UserName", ResourceType = typeof(Resource))]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Messaage", ResourceType = typeof(Resource))]
        [Required]
        public string Messaage { get; set; }
    }
}