using System.ComponentModel.DataAnnotations;

namespace Old_stuff_exchange.Entity
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }
        
        public string DepartmentDescription { get; set; }

        public string Address { get; set; }

    }
}
