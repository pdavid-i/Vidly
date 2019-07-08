using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribed { get; set; }

        public Membership Membership { get; set; } 
        [Display(Name = "Membership Type")]
        public byte MembershipId { get; set; }

        [Display(Name = "Date of Birth ")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }


        public string getBirthdate()
        {
            string result = Birthday.HasValue ? Birthday.Value.ToString("dd-MM-yyyy "): "<not available>";
            return result;
        }
    }
}