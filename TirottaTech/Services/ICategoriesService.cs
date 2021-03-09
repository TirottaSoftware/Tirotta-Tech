using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TirottaTech.Services
{
    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllCategories();
    }
}
