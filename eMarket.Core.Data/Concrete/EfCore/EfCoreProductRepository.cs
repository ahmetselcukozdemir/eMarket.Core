using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace eMarket.Core.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, eMarketContext>, IProductRepository
    {
        public Product GetByIdProduct(int productID)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Include("Categories").Include("Member").Include("ProductImages").Where(x => x.IsApproved == true && x.ProductId == productID)
                    .FirstOrDefault();
            }
        }

        public List<Product> GetLastAddProducts()
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Include("ProductImages").OrderByDescending(x => x.CreatedDate).Where(x=>x.IsApproved == true).Take(10).ToList();
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

        public List<Product> MostViewedProducts(int categoryId)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Include("ProductImages").Where(x => x.IsApproved == true && x.CategoryId == categoryId).OrderByDescending(x => x.Hit).Take(10).ToList();
            }
        }

        public List<Product> RandomOfDayProducts()
        {
            using (var context = new eMarketContext())
            {
                var rnd = new Random();
                return context.Products.Include("ProductImages").Where(x => x.IsApproved == true).Take(5).ToList();
            }
        }

        public List<Product> RelatedProducts(int categoryID)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Include("ProductImages").Where(x => x.IsApproved == true).Take(10).ToList();
            }
        }
    }
}
