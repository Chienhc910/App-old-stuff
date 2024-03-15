using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }
        [Required]
        [MaxLength(50)]
        public string BuildingName { get; set; }

        public string BuildingDescription { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }  
    }
}
