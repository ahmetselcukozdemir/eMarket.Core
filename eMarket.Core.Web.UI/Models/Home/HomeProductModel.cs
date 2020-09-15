using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Entity;

namespace eMarket.Core.Web.UI.Models.Home
{
    public class HomeProductModel
    {
        public List<Product> HotProducts { get; set; }
        public List<Product> MostViewedProductsCategoryOne { get; set; }
        public List<Product> MostViewedProductsCategoryTwo{ get; set; }
        public List<Product> MostViewedProductsCategoryThree { get; set; }
        public List<Product> MostViewedProductsCategoryFour { get; set; }
        public List<Product> RandomOfDayProducts { get; set; }
        public List<Entity.Category> Categories{ get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Entity.Blog> BlogPost { get; set; }
    }
}
