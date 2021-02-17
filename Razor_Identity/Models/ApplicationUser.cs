using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("RepairOrder")]
        public int RepairOrderId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAdress")]
        public string Emailadress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]

        public ICollection<RepairOrder> RepairOrders { get; set; }

    }
}
