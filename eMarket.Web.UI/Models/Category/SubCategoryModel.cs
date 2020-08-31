using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Web.UI.Models.Category
{
    public class SubCategoryModel
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public int categoryId { get; set; }
      
    }
}
