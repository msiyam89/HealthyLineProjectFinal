using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLineProject.Models
{
    public class IdealWeightModel 
    {

        [Display(Name = "TargetWeight", ResourceType = typeof(Resource))]
        [Required]
        public float TargetWeight { get; set; }
        [Display(Name = "Height", ResourceType = typeof(Resource))]
        [Required]
        public float Height { get; set; }
        [Display(Name = "weight", ResourceType = typeof(Resource))]
        [Required]
        public float weight { get; set; }

        [Display(Name = "CurrentWeight", ResourceType = typeof(Resource))]
        [Required]
        public float CurrentWeight { get; set; }

        [Display(Name = "BMI", ResourceType = typeof(Resource))]
        [Required]
        public float BMI { get; set; }
        [Display(Name = "IdealWeight", ResourceType = typeof(Resource))]
        [Required]
        public float IdealWeight { get; set; }
        [Required]
        [Display(Name = "Gender", ResourceType = typeof(Resource))]
        public bool Gender { get; set; }
        //[Required]
        //public int weight { get; set; }

        //[Required]
        //public int height{ get; set; }
        //[Required]
        //public int age { get; set; }
        //[Required]
        //public byte Gender { get; set; }
        //public byte Dailyeffort { get; set; }

    }
    
}
