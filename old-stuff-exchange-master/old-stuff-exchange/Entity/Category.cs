using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Old_stuff_exchange.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        // Relationship
        public ICollection<Product> Products { get; set; }
        public Category() {
            Products = new List<Product>();
        }
    }
}
