using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Identity.Models
{
    public enum Status
    {
        On_hold,
        Under_repair,
        Waiting_for_parts,
        Done
    }

    public class RepairOrder
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PartList")]
        public int PartListId { get; set; }

        [Required]
        [Display(Name = "Repair Status")]
        public Status? Status { get; set; }

        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Begin date is required")]
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500)]

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "PartList")]
        public PartList PartList { get; set; }
    }
}
