using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class UserProfileModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Required]
        [Display(Name = "FullNameArabic", ResourceType = typeof(Resource))]
        public string FullNameArabic { get; set; }

        [Display(Name = "FullNameEnglish", ResourceType = typeof(Resource))]
        [Required]
        public string FullNameEnglish { get; set; }

        [Display(Name = "UserName", ResourceType = typeof(Resource))]
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Gender", ResourceType = typeof(Resource))]
        public bool Gender { get; set; }
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        public string Email { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm", ResourceType = typeof(Resource))]
        public string Confirm { get; set; }

        [Display(Name = "MobileNumber", ResourceType = typeof(Resource))]
        [Required]
        public string MobileNumber { get; set; }

        //[Display(Name = "TargetWeight", ResourceType = typeof(Resource))]
        //[Required]
        //public float TargetWeight { get; set; }
      [DataType (DataType.Date)]
        [Display(Name = "BirthDate", ResourceType = typeof(Resource))]
        [Required]
        public DateTime BirthDate { get; set; }

        //[Display(Name = "Height", ResourceType = typeof(Resource))]
        //[Required]
        //public float Height { get; set; }

        //[Display(Name = "CurrentWeight", ResourceType = typeof(Resource))]
        //[Required]
        //public float CurrentWeight { get; set; }

        //[Display(Name = "IdealWeight", ResourceType = typeof(Resource))]
        // [Required]
        // public float IdealWeight { get; set; }

        [Display(Name = "IsActive", ResourceType = typeof(Resource))]
        public byte IsActive { get; set; }

        [Display(Name = "CreatedDate", ResourceType = typeof(Resource))]
        public string CreatedDate { get; set; }

        [Display(Name = "CreatedBy", ResourceType = typeof(Resource))]
        public string CreatedBy { get; set; }


    }
}