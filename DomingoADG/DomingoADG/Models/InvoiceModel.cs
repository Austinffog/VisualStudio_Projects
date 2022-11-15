using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomingoADG.Models
{
    public class InvoiceModel
    {

        [Display(Name = "JobCardNo")]
        public int job_card_no { get; set; }

        [Required(ErrorMessage = "Include customer name.")]
        public string customer_name { get; set; }

        [Required(ErrorMessage = "Include address.")]
        public string address { get; set; }

        [Required(ErrorMessage = "Type of job required.")]  //produces error message
        public string job_type { get; set; }

        [Required(ErrorMessage = "The employee number is missing.")]
        public int employee_no { get; set; }

        [Required(ErrorMessage = "Employee name must be included.")]
        public string employee_name { get; set; }

        [Required(ErrorMessage = "List of materials used is required.")]
        public string material_used { get; set; }

        [Required(ErrorMessage = "Please include the customer number.")]
        public int customer_no { get; set; }

        [Required(ErrorMessage = "The sub total amount is not present.")]
        public int sub_total { get; set; }

        [Required(ErrorMessage = "VAT is required.")]
        public int vat { get; set; }

        [Required(ErrorMessage = "The total is required.")]
        public int total { get; set; }
    }
}