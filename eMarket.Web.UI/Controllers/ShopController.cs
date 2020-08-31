using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Business.Abstract;
using eMarket.Entity;
using eMarket.Web.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace eMarket.Web.UI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Products()
        {
            if (HttpContext.Session.GetString("Name") != null && HttpContext.Session.GetString("ID") != null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                ViewBag.ID = HttpContext.Session.GetString("ID");
            }
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(productViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = _productService.GetById((int)id);
            if (product == null)
            {
                return NotFound();
            }


            return View(new ProductDetailModel
            {
                Product = product,
            });
        }
    }
}
