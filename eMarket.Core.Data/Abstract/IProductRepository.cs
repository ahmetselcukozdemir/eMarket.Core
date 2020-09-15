using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;

namespace eMarket.Core.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByIdProduct(int productID);
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
        List<Product> GetLastAddProducts();
        List<Product> MostViewedProducts(int categoryId);
        List<Product> RandomOfDayProducts();
        List<Product> RelatedProducts(int categoryID);

    }
}
