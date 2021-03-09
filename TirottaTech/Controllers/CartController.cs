using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;
using TirottaTech.Models;

namespace TirottaTech.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;

        private ApplicationUser currentUser;

        public CartController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            this.currentUser = await this.userManager.GetUserAsync(this.User);
            var cart = this.db.CartItems.Include(x => x.Product).Where(c => c.UserId == currentUser.Id).ToList();
            return View(cart);
        }
        public async Task<IActionResult> Add(int id)
        {
            this.currentUser = await this.userManager.GetUserAsync(this.User);
            //find product by id
            var product = this.db.Products.Find(id);
            //check if product already exists in the cart
            //var cartItem = this.db.CartItems.FirstOrDefault(c => c.ProductId == id);
            var cartItem = this.db.CartItems.FirstOrDefault(c => c.ProductId == id && c.UserId == currentUser.Id);
            //this.appUser.CartItems.FirstOrDefault()
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                var item = new CartItem { ProductId = id, Product = product, Quantity = 1, UserId = currentUser.Id, User = currentUser };
                //add cartitem to db
                this.db.CartItems.Add(item);
            }
            await this.db.SaveChangesAsync();

            var cart = this.db.CartItems.Include(x => x.Product).Where(c => c.UserId == currentUser.Id).ToList();
            return View("Index", cart);
        }
        public async Task<IActionResult> Remove(int id)
        {
            this.currentUser = await this.userManager.GetUserAsync(this.User);
            //get product by id
            var product = this.db.CartItems.Include(x=>x.Product).FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                product.Quantity--;
                if (product.Quantity == 0)
                {
                    this.db.CartItems.Remove(product);
                }
                await this.db.SaveChangesAsync();
                var cart = this.db.CartItems.Include(x => x.Product).Where(c => c.UserId == currentUser.Id).ToList();
                return View("Index", cart);
            }
            else
            {
                return Content("Remove Action Failed. Product not found");
            }
            //remove from cart
            //save
        
        }
    }
}
