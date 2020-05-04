using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace HealthyLineProject.Models
{
    public class DiseasesModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Display(Name = "NameArabic", ResourceType = typeof(Resource))]
        [Required]
        public string NameArabic { get; set; }
        [Display(Name = "NameEnglish", ResourceType = typeof(Resource))]
        [Required]
        public string NameEnglish { get; set; }
    }
}