using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;
using TirottaTech.Models;
using TirottaTech.Services;

namespace TirottaTech.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ICategoriesService categoriesService;

        public AdminController(ApplicationDbContext db, ICategoriesService categoriesService)
        {
            this.db = db;
            this.categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var categoryProduct = new ProductInputModel();
            categoryProduct.CategoryItems = categoriesService.GetAllCategories();
            return View(categoryProduct);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductInputModel product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var p = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                CategoryId = product.CategoryId,
                Brand = product.Brand,
            };

            this.db.Products.Add(p);
            await this.db.SaveChangesAsync();

            var products = this.db.Products.ToList();
            return View("Index", products);
        }
        public IActionResult Remove()
        {
            IEnumerable<Product> products = this.db.Products;
            return View(products);
        }
        [HttpPost]
        public IActionResult Remove(Product product)
        {
            this.db.Products.Remove(product);
            this.db.SaveChanges();
            return View(this.db.Products);
        }
    }
}
