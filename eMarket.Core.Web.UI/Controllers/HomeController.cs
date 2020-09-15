using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Core.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eMarket.Core.Web.UI.Models;
using eMarket.Core.Web.UI.Models.Category;
using eMarket.Core.Web.UI.Models.Home;
using eMarket.Web.UI.Models;
using Microsoft.AspNetCore.Http;

namespace eMarket.Core.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _productService;
        private IAdminService _adminService;
        public HomeController(ILogger<HomeController> logger, IProductService productService, IAdminService adminService)
        {
            _logger = logger;
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

            var lastAddProducts = _productService.GetLastAddProducts();
            var randomProducts = _productService.RandomOfDayProducts();
            var getMostViewCategoryOne = _productService.MostViewedProducts(1);
            var getMostViewCategoryTwo = _productService.MostViewedProducts(2);
            var getMostViewCategoryThree = _productService.MostViewedProducts(3);
            var getMostViewCategoryFour = _productService.MostViewedProducts(4);
            var blogPost = _adminService.GetAllBlogPost();
            var entity = new HomeProductModel()
            {
                Categories = categories,
                SubCategories = subcategories,
                HotProducts = lastAddProducts,
                RandomOfDayProducts = randomProducts,
                MostViewedProductsCategoryOne = getMostViewCategoryOne,
                MostViewedProductsCategoryTwo = getMostViewCategoryTwo,
                MostViewedProductsCategoryThree = getMostViewCategoryThree,
                MostViewedProductsCategoryFour = getMostViewCategoryFour,
                BlogPost = blogPost
            };
            if (HttpContext.Session.GetString("Name") != null && HttpContext.Session.GetString("ID") != null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                ViewBag.ID = HttpContext.Session.GetString("ID");
            }
            //var productViewModel = new ProductViewModel()
            //{
            //    Products = _productService.GetAll()
            //};
            return View(entity);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
