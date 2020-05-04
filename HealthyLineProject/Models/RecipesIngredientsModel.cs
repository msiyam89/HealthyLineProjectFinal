using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class RecipesIngredientsModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Display(Name = "RecipeId", ResourceType = typeof(Resource))]
        [Required]
        public int RecipeId { get; set; }
        [Display(Name = "Ingredient", ResourceType = typeof(Resource))]
        [Required]
        public string Ingredient { get; set; }
    }
}