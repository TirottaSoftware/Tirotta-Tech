using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;
using TirottaTech.Models;

namespace TirottaTech.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext db;
        private List<Category> categories;

        public CategoriesService(ApplicationDbContext db)
        {
            this.db = db;
            this.categories = this.db.Categories.ToList();
        }
        public IEnumerable<KeyValuePair<string, string>> GetAllCategories()
        {
            return this.categories.Select(x => new
            {
                x.Id,
                x.Name,
            })
            .ToList()
            .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}