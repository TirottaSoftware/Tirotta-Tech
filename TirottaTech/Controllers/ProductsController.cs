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
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ICategoriesService categoriesService;

        public ProductsController(ApplicationDbContext _db, ICategoriesService categoriesService)
        {
            db = _db;
            this.categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            var products = this.db.Products.ToList();
            return View(products);
        }
        public IActionResult Get(int id)
        {
            var p = this.db.Products.Find(id);
            return View(p);
        }
        public IActionResult Filter(Dictionary<string, string> filters)
        {
            var products = this.db.Products.ToList();
            //var products = new List<Product>();
            string brandFilter = filters["brand"];
            
            //Base case
            if (brandFilter != "none")
            {
                products = this.db.Products.Where(x => x.Brand == brandFilter).ToList();
            }
            string sortFilter = filters["sort"];
            if (sortFilter == "lowtohigh")
            {
                products = products.OrderBy(x => x.Price).ToList();
            }
            else if (sortFilter == "hightolow")
            {
                products = products.OrderByDescending(x => x.Price).ToList();
            }
            else if (sortFilter == "az")
            {
                products = products.OrderBy(x => x.Name).ToList();
            }
            else if (sortFilter == "za")
            {
                products = products.OrderByDescending(x => x.Name).ToList();
            }
            return PartialView("_ProductsPartial", products);
        }
        //[HttpGet]
        //public IActionResult Add()
        //{
        //    var categoryProduct = new ProductInputModel();
        //    categoryProduct.CategoryItems = categoriesService.GetAllCategories();
        //    return View(categoryProduct);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Add(ProductInputModel product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    var p = new Product
        //    {
        //        Name = product.Name,
        //        Description = product.Description,
        //        Price = product.Price,
        //        ImageUrl = product.ImageUrl
        //    };

        //    this.db.Products.Add(p);
        //    await this.db.SaveChangesAsync();

        //    var products = this.db.Products.ToList();
        //    return View(products);
        //}
    }
}
