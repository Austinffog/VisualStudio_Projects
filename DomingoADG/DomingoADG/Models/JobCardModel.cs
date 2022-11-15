using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomingoADG.Models
{
    public class JobCardModel
    {

        [Display(Name = "JobCardNo")]
        public int job_card_no { get; set; }

        [Required(ErrorMessage = "Type of job required.")]
        public string job_type { get; set; }

        [Required(ErrorMessage = "The amount of days of work is needed.")]
        public int no_of_days { get; set; }

        [Required(ErrorMessage = "List of materials used is required.")]
        public string material_used { get; set; }

        [Required(ErrorMessage = "Please include the customer number.")]
        public int customer_no { get; set; }



    }
}