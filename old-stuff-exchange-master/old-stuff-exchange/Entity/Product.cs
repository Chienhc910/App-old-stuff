using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Info { get; set; }
        
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }

    }
}
