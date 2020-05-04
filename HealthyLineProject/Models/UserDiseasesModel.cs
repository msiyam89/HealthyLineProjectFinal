using R;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLineProject.Models
{
    public class UserDiseasesModel
    {
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Display(Name = "ProfileId", ResourceType = typeof(Resource))]
        [Required]
        public int ProfileId { get; set; }
        [Display(Name = "DiseasesId", ResourceType = typeof(Resource))]
        [Required]
        public int DiseasesId { get; set; }
    }
}