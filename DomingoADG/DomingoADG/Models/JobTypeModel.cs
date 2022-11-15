using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomingoADG.Models
{
    public class JobTypeModel
    {
        [Required(ErrorMessage = "Type of job required.")]  //produces error message
        public string job_type { get; set; }
        [Display(Name = "Daily Rate")]
        public int daily_rate { get; set; }

    }
}