using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Identity.Models
{
    public class PartList
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RepairOrder")]
        public int RepairOrderId { get; set; }

        [Display(Name = "Parts")]
        public ICollection<Part> Parts { get; set; }

        public RepairOrder RepairOrders { get; set; }
    }
}
