using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomingoADG.Models
{
    public class EmployeeModel
    {
        [Display(Name = "JobCardNo")]
        public int job_card_no { get; set; }

        [Required(ErrorMessage = "Please include the employee number.")]
        public int employee_no { get; set; }

        [Required(ErrorMessage = "Employee name required.")]  //produces error message
        public string employee_name { get; set; }


    }
}