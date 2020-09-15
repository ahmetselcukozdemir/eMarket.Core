using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetByIdProduct(int productID);
        List<Product> GetLastAddProducts();
        List<Product> MostViewedProducts(int categoryId);
        List<Product> RandomOfDayProducts();
        List<Product> GetAll();
        List<Product> RelatedProducts(int categoryID);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
