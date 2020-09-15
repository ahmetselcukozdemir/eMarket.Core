using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Business.Abstract;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Concrete
{
   public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            //iş kuralları
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            //iş kuralları
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            //iş kuralları
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetByIdProduct(int productID)
        {
            return _productRepository.GetByIdProduct(productID);
        }

        public List<Product> GetLastAddProducts()
        {
            return _productRepository.GetLastAddProducts();
        }

        public List<Product> MostViewedProducts(int categoryId)
        {
            return _productRepository.MostViewedProducts(categoryId);
        }

        public List<Product> RandomOfDayProducts()
        {
            return _productRepository.RandomOfDayProducts();
        }

        public List<Product> RelatedProducts(int categoryID)
        {
            return _productRepository.RelatedProducts(categoryID);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
        
}
