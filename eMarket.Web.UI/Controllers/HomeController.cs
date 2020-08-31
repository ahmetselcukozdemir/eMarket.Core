using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Business.Abstract;
using eMarket.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eMarket.Web.UI.Models;
using eMarket.Web.UI.Models.Category;
using Microsoft.AspNetCore.Http;

namespace eMarket.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private IAdminService _adminService;
        public HomeController(IProductService productService,IAdminService adminService)
        {
            this._productService = productService;
            this._adminService = adminService;
        }
        public IActionResult OnGetPartial() =>
            new PartialViewResult
            {
                ViewName = "_MenuOneLayout",
                ViewData = ViewData,
            };

        public IActionResult Index()
        {
            var categories = _adminService.GetAllCategory();
            if (categories != null)
            {
                ViewBag.categories = categories;
            }

            var subcategories = _adminService.GetAllSubCategories();
            if (subcategories != null)
            {
                ViewBag.subcategories = subcategories;
            }

            var entity = new CategoryModel()
            {
                Categories = categories,
                SubCategories = subcategories
            };
            if (HttpContext.Session.GetString("Name")  != null && HttpContext.Session.GetString("ID") !=null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                ViewBag.ID = HttpContext.Session.GetString("ID");
            }
            //var productViewModel = new ProductViewModel()
            //{
            //    Products = _productService.GetAll()
            //};
            return View();
        }

        public PartialViewResult _HotProducts()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetLastAddProducts()
            };
            return PartialView();
        }

        [HttpGet]
        public ActionResult _MenuOneLayout()
        {
           
            return PartialView();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
