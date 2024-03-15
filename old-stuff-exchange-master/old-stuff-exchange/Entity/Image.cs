using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
