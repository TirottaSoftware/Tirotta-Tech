using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TirottaTech.Models
{
    public class ProductInputModel
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(99, double.MaxValue)]
        public double Price { get; set; }
        [Required]
        [RegularExpression("[A-Z][a-z]+", ErrorMessage = "Brand name must contain letters only. Brand name must start with a capital letter")]
        public string Brand { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<KeyValuePair<string, string>> CategoryItems { get; set; }
    }
}
