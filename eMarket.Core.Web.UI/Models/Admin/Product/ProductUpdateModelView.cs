﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Entity;

namespace eMarket.Core.Web.UI.Models.Admin.Product
{
    public class ProductUpdateModelView
    {
        public List<Entity.Product> Products{ get; set; }
        public List<Entity.Category> Categories { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
