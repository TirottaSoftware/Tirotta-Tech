using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;

namespace TirottaTech.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public DateTime CreatedOn => DateTime.UtcNow;
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
