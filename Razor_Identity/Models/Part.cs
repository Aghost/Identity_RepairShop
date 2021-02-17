using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Identity.Models
{
    public enum PartType
    {
        Cpu,
        Motherboard,
        Memory,
        Graphic_Card,
        Storage,
        Power_Supply,
        Software,
        Misc
    }
    public class Part
    {
        [Key]
        public int Id { get; set; }
        public int PartListId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Part Type")]
        public PartType PartType { get; set; }

        [Required]
        [Display(Name = "Part Price")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        public ICollection<PartList> PartLists { get; set; }
    }
}
