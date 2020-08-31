using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Entity;

namespace eMarket.Data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
        List<Product> GetLastAddProducts();

    }
}
