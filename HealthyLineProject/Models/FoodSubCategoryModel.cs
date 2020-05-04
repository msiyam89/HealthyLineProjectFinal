using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class FoodSubCategoryModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }

        [Display(Name = "MainCategoryId", ResourceType = typeof(Resource))]
        public int MainCategoryId { get; set; }

        [Display(Name = "SubCategoryNameArabic", ResourceType = typeof(Resource))]
        public string SubCategoryNameArabic { get; set; }
        [Required]
        [Display(Name = "SubCategoryNameEnglish", ResourceType = typeof(Resource))]
        public string SubCategoryNameEnglish { get; set; }
        [Required]
        [Display(Name = "Calorie", ResourceType = typeof(Resource))]
        public int Calorie { get; set; }

    }
}