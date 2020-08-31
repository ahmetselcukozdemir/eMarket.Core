using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Business.Abstract;
using eMarket.Data.Abstract;
using eMarket.Data.Concrete.EfCore;
using eMarket.Entity;

namespace eMarket.Business.Concrete
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

        public List<Product> GetLastAddProducts()
        {
           return _productRepository.GetLastAddProducts();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
