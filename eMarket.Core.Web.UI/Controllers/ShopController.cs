using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Business.Abstract;
using eMarket.Core.Entity;
using eMarket.Core.Web.UI.Models;
using eMarket.Core.Web.UI.Models.Home;
using eMarket.Web.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace eMarket.Web.UI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
        private IMemberService _memberService;

        public ShopController(IProductService productService, IMemberService memberService)
        {
            this._productService = productService;
            this._memberService = memberService;
        }
        public IActionResult Products()
        {
            ViewBag.Current = "Products";
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

            Product product = _productService.GetByIdProduct((int)id);
            if (product == null)
            {
                return NotFound();
            }

            var relatedProducts = _productService.RelatedProducts(product.CategoryId);


            return View(new ProductDetailModel
            {
                Product = product,
                RelatedProducts = relatedProducts
            });
        }

        public IActionResult Sellers()
        {
            ViewBag.Current = "Sellers";
            var lastSellers = _memberService.LastAddSellers();
            var getAllSellers = _memberService.AllMemberIsHome();
            var starSellers = _memberService.StarSellers();
            var entity = new SellersModel()
            {
                LastAddSellers = lastSellers,
                GetAllSellers = getAllSellers,
                StarSellers = starSellers
            };
            return View(entity);
        }

        public IActionResult SellerProfile(int? id)
        {
            ViewBag.Current = "SellerProfile";
            if (id != null)
            {
                var sellersProfile = "";
                return View(sellersProfile);
            }
            return View();
        }
    }
}
