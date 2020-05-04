using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class FoodMainCategoriesModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Required]
        [Display(Name = "CategoryNameArabic", ResourceType = typeof(Resource))]
        public string CategoryNameArabic { get; set; }
        [Required]
        [Display(Name = "CategoryNameEnglish", ResourceType = typeof(Resource))]
        public string CategoryNameEnglish { get; set; }
    }
}