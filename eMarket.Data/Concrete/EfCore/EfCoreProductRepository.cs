using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMarket.Data.Abstract;
using eMarket.Entity;

namespace eMarket.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, eMarketContext>, IProductRepository
    {
        public List<Product> GetLastAddProducts()
        {
            using (var context = new eMarketContext())
            {
                return context.Products.OrderByDescending(x=>x.CreatedDate).Take(5).ToList();
            }
        }

        public List<Product> GetPopularProducts()
        {
            using (var context = new eMarketContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new NotImplementedException();
        }
    }
}
