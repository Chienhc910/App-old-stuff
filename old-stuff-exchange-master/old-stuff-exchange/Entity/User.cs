using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(10)]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        // relationship
        /*public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public User()
        {
            Posts = new List<Post>();
            Comments = new List<Comment>();
        }*/
    }
}
