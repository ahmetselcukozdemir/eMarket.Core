using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Entity;

namespace eMarket.Web.UI.Models.Category
{
    public class CategoryModel
    {
        public List<Entity.Category> Categories { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
