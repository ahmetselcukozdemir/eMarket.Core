using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMarket.Entity;
using eMarket.Web.UI.Models.Account;
using Microsoft.AspNetCore.Mvc;
using eMarket.Business.Abstract;
using eMarket.Data.Abstract;
using Microsoft.AspNetCore.Http;

namespace eMarket.Web.UI.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var entity = new User()
            {
                FirstName = model.FirstName,
                Surname = model.LastName,
                Mail = model.Email,
                Password = model.Password,
                IsActive = true,
                LastActivityDate = DateTime.Now,
                Birthday = model.Birthday
            };
            if (_accountService.Create(entity))
            {
                ViewBag.SuccessMessage =
                    "Üyeliğiniz başarılı bir şekilde oluşturulmuştur.Sisteme giriş yapabilirsiniz. :)";
                return RedirectToAction("Register", "Account");
            }
            else
            {
                ViewBag.ErrorMessage = "Lütfen bilgileriniz kontrol edin.";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (!string.IsNullOrEmpty(Request.Cookies["LastLoggedInTime"]))
            {
                ViewBag.LTLD = Request.Cookies["LastLoggedInTime"].ToString();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var entity = _accountService.GetByMailAndPasswordWithUser(model.Email, model.Password);
            if (entity == null)
            {
                ViewBag.ErrorMessageLogin = "Böyle bir kullanıcı bulunamadı.Email veya şifrenizi lütfen kontrol edin. :(";
                return View(model);
            }
            else
            {
                CookieOptions option = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1)
                };
                //save user info session 
                HttpContext.Session.SetString("Name", entity.FirstName);
                HttpContext.Session.SetString("ID", entity.UserId.ToString());

                Response.Cookies.Append("LastLoggedInTime", DateTime.Now.ToString(), option);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult MyFavoriteProducts()
        {
            if (HttpContext.Session.GetString("ID") == null)
            {
                RedirectToAction("Login", "Account");
            }
            else
            {
                var users_id = Convert.ToInt32(HttpContext.Session.GetString("ID"));
                var data = _accountService.GetAllFavoriteProducts(users_id);
                return View(data);
            }

            return View("Login");
        }

        public IActionResult AddFavoriteProducts(int id, string returnUrl)
        {
            if (HttpContext.Session.GetString("ID") != null)
            {
                if (id != null)
                {
                    var entity = new ProductFavorite()
                    {
                        userId = Convert.ToInt32(HttpContext.Session.GetString("ID")),
                        productId = id
                    };
                    var users_id = Convert.ToInt32(HttpContext.Session.GetString("ID"));
                    var data = _accountService.GetAllFavoriteProducts(users_id);
                    foreach (var itemFavorite in data)
                    {
                        if (itemFavorite.productId == entity.productId)
                        {
                            ViewBag.DuplicateDataMessage = "Bu ürünü daha önce sepetinize eklemişsiniz. :( ";
                        }
                    }

                    return Redirect(returnUrl);
                    if (_accountService.AddMyFavoriteProducts(entity))
                    {
                        ViewBag.AddFavoriteProductsMessage =
                            "Ürün favorilerinize eklenmiştir. :)";
                        return Redirect(returnUrl);
                    }
                }
            }
            else
            {
                RedirectToAction("Login", "Account");
            }

            return Redirect(returnUrl);
        }

        public IActionResult PersonalInformation()
        {
            return View();
        }
    }
}
