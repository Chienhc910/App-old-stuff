using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Old_stuff_exchange.Entity
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        // Relationship
        public ICollection<User> Users { get; set; }
        public Role() {
            Users = new List<User>();
        }
    }
}
