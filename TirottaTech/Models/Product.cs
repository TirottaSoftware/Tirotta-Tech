using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TirottaTech.Models
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime CreatedOn => DateTime.UtcNow;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Brand { get; set; }
        public string ImageUrl { get; set; }
    }
}
