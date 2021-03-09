using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TirottaTech.Data;

namespace TirottaTech.Services
{
    public class BrandsService : IBrandsService
    {
        private readonly ApplicationDbContext db;
        public BrandsService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<SelectListItem> GetAllBrands()
        {
            var brands = this.db.Products.Select(x => x.Brand).ToList().Distinct();
            var kvp = new List<SelectListItem>();
            foreach (var brand in brands)
            {
                SelectListItem sli = new SelectListItem(brand, brand);
                kvp.Add(sli);
            }
            return kvp;
        }
    }
}
