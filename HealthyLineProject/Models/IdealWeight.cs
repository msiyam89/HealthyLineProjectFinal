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
        [Required]
        public int weight { get; set; }
        
        [Required]
        public int height{ get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public byte Gender { get; set; }
        public byte Dailyeffort { get; set; }

    }
    
}
