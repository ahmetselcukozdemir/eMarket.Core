﻿using eMarket.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMarket.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetLastAddProducts();
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
