using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Models;

namespace TirottaTech.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser():base()
        {
            this.CartItems = new List<CartItem>();
        }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
