using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dropdown2.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Display(Name = "Martial Status")]
        public bool Status { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }
    }
}