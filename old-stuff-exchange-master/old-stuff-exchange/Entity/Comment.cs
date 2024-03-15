using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class Comment
    {
        [Key]
        public Guid CommentId { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Comment() { }
    }
}
