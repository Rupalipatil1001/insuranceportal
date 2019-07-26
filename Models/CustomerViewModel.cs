using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClientPortal.Models
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
       

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime AppDate { get; set; }
        public string InsuranceType { get; set; } //Partition Key

        [DataType(DataType.Currency)]
        public double Amount { get; set; }

        [DataType(DataType.Currency)]
        public double Premium { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public IFormFile Image { get; set; }
    }
}
