using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Entity;

namespace eMarket.Web.UI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Product> RelatedProducts { get; set; }
    }
}
