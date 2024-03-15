using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public enum PostStatus { 
        New = 0, Complete = 1, Cancel = -1
    }
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public PostStatus Status { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        // Relationship
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Product> Products { get; set; }

        public Post() {
            Comments = new List<Comment>();
            Images = new List<Image>();
            Products = new List<Product>();
        }
    }
}
