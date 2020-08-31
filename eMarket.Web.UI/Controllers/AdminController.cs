using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eMarket.Business.Abstract;
using eMarket.Business.Concrete;
using eMarket.Data.Concrete.EfCore;
using eMarket.Entity;
using eMarket.Web.UI.Models;
using eMarket.Web.UI.Models.Admin;
using eMarket.Web.UI.Models.Admin.Product;
using eMarket.Web.UI.Models.Blog;
using eMarket.Web.UI.Models.Category;
using eMarket.Web.UI.Models.Member;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eMarket.Web.UI.Controllers
{
    public class AdminController : Controller
    {
        private IMemberService _memberService;
        private IAccountService _accountService;
        private IAdminService _adminService;

        public AdminController(IMemberService memberService, IAccountService accountService, IAdminService adminService)
        {
            _memberService = memberService;
            _accountService = accountService;
            _adminService = adminService;
        }

        public IActionResult Default()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);

                ViewBag.UnapprovedProductNumber = _adminService.GetAllUnapprovedProductsById(Convert.ToInt16(memberID)).Count;
                ViewBag.ApprovedProductNumber = _adminService.GetAllApprovedProductsById(Convert.ToInt16(memberID)).Count;

                ViewBag.readMessageNumber = _adminService.GetAllReadMessages(Convert.ToInt16(memberID)).Count;
                ViewBag.unReadMessageNumber = _adminService.GetAllUnreadMessages(Convert.ToInt16(memberID)).Count;

                ViewBag.MemberCount = _memberService.GetAllMembers().Count -1 ;
                ViewBag.UserCount = _accountService.GetAllUsers().Count;

                ViewBag.BlogNumber = _adminService.GetAllBlogPost().Count;
                ViewBag.CategoryCount = _adminService.GetAllCategory().Count;
                ViewBag.SubCategoryCount = _adminService.GetAllSubCategories().Count;

                ViewBag.ApprovedProductAdmin = _adminService.GetAllApprovedProducts().Count;
                ViewBag.UnApprovedProductAdmin = _adminService.GetAllUnapprovedProducts().Count;

                return View();
            }

            return View("Login");
        }

        [HttpGet]
        public IActionResult MyInfoEdit()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var memberInfo = _memberService.GetById(Convert.ToInt16(memberID));
                if (memberInfo != null)
                {
                    return View(memberInfo);
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult MyInfoEdit(Member model, string url)
        {
            HttpContext.Session.Remove("SuccessUpdateMessage");
            HttpContext.Session.Remove("ErrorUpdateMessage");
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                var member = _memberService.GetById(Convert.ToInt16(memberID));
                if (member != null)
                {
                    var entity = new Member()
                    {
                        Name = model.Name,
                        Surname = model.Surname,
                        Email = model.Email,
                        Password = model.Password,
                        Address = model.Address,
                        Slogan = model.Slogan,
                        StoreName = model.StoreName,
                        Phone = model.Phone,
                        LastActivityDate = DateTime.Now,
                        IsActive = true,
                        IsAdmin = false,
                        MemberId = Convert.ToInt16(memberID)
                    };

                    if (_memberService.Update(entity))
                    {
                        HttpContext.Session.SetString("SuccessUpdateMessage",
                            "Bilgileriniz başarılı bir şekilde güncellenmiştir.");
                        return Redirect(url);
                    }
                }
                else
                {
                    HttpContext.Session.SetString("ErrorUpdateMessage",
                        "Bilgileriniz güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyin.");
                    return Redirect(url);
                }
            }
            HttpContext.Session.SetString("ErrorUpdateMessage",
                "Bilgileriniz güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyin.");
            return RedirectToAction("MyInfoEdit", "Admin");
        }

        #region Giriş/Çıkış 
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminLoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = _memberService.GetByMailAndPasswordWithUser(model.admin_email, model.admin_password);
            if (entity == null)
            {
                ViewBag.ErrorMessageLogin =
                    "Böyle bir kullanıcı bulunamadı.Email veya şifrenizi lütfen kontrol edin. :(";
                return View(model);
            }
            else
            {
                CookieOptions option = new CookieOptions
                {
                    Expires = DateTime.Now.AddHours(1)
                };
                Response.Cookies.Append("member_id", entity.MemberId.ToString(), option);
                Response.Cookies.Append("member_name", entity.Name, option);
                Response.Cookies.Append("member_IsAdmin", entity.IsAdmin.ToString(), option);
                return RedirectToAction("Default", "Admin");
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete("member_id");
            Response.Cookies.Delete("member_name");
            Response.Cookies.Delete("member_IsAdmin");
            return RedirectToAction("Login", "Admin");
        }
        #endregion  

        #region ÜyelerAdmin
        [HttpGet]
        public IActionResult MemberList()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var data = _memberService.GetAllMembers().ToList();
                if (data != null)
                {
                    return View(data);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult MemberEdit(int id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var entity = _memberService.GetById(id);
                if (entity == null)
                {
                    return NotFound();
                }

                return View(entity);
            }

            return View();
        }

        [HttpPost]
        public IActionResult MemberUpdate(MemberModel model)
        {
            var entity = _memberService.GetById(model.MemberId);
            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.FirstName;
            entity.Surname = model.Surname;
            entity.Email = model.Email;
            entity.Password = model.Password;
            entity.Phone = model.Phone;
            entity.IsActive = model.IsActive;
            if (_memberService.Update(entity))
            {
                return RedirectToAction("MemberList", "Admin");
            }

            return View();
        }

        [HttpGet]
        public IActionResult MemberAdd()
        {

            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                return View();
            }

            return View();
        }

        [HttpPost]
        public IActionResult MemberAdd(MemberModel model)
        {
            var entity = new Member()
            {
                Name = model.FirstName,
                Surname = model.Surname,
                Email = model.Email,
                Password = model.Password,
                IsAdmin = false,
                IsActive = true,
                LastActivityDate = DateTime.Now
            };
            _memberService.Create(entity);
            return RedirectToAction("MemberList");
        }
        #endregion

        #region KullanıcıAdmin
        [HttpGet]
        public IActionResult UsersList()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var users = _accountService.GetAllUsers().ToList();
                if (users == null)
                {
                    ViewBag.ErrorMessage = "Sistemde kullanıcı bulunamadı. :(";
                }

                return View(users);
            }

            return View();
        }

        [HttpGet]
        public IActionResult UsersEdit(int id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var entity = _accountService.GetById(id);
                if (entity == null)
                {
                    return NotFound();
                }

                return View(entity);
            }

            return View();
        }

        [HttpPost]
        public IActionResult UsersUpdate(UserModel model)
        {
            var entity = _accountService.GetById(model.UserId);
            if (entity == null)
            {
                return NotFound();
            }

            entity.FirstName = model.FirstName;
            entity.Surname = model.Surname;
            entity.Mail = model.Mail;
            entity.Password = model.Password;
            entity.Phone = model.Phone;
            entity.IsActive = model.IsActive;

            if (_accountService.Update(entity))
            {
                return RedirectToAction("UsersList", "Admin");
            }

            return View();
        }
        #endregion 

        #region Blog
        [HttpGet]
        public IActionResult BlogPost()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var data = _adminService.GetAllBlogPost();
                if (data == null)
                {
                    ViewBag.ErrorMessage = "Veritabanından veri getirirken bir hata oluştu.";
                }

                return View(data);
            }

            return View();
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                return View();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BlogAdd(BlogModel model, IFormFile file)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                if (ModelState.IsValid && file != null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\blogs", randomName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var entity = new Blog()
                    {
                        Title = model.Title,
                        Description = model.Description,
                        Content = model.Content,
                        ImageUrl = randomName,
                        CreatedDate = DateTime.Now
                    };
                    if (_adminService.CreateBlog(entity))
                    {
                        return RedirectToAction("BlogPost");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Lütfen tüm alanları doldurun.";

                }

                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var entity = _adminService.GetByIdBlog(id);
                if (entity == null)
                {
                    return NotFound();
                }

                var model = new BlogModel()
                {
                    BlogId = entity.BlogId,
                    Title = entity.Title,
                    Description = entity.Description,
                    ImageUrl = entity.ImageUrl,
                    Content = entity.Content
                };
                return View(model);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BlogUpdate(BlogModel model, IFormFile? file)
        {
            if (file != null && ModelState.IsValid)
            {
                var extention = Path.GetExtension(file.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\blogs", randomName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //delete blog photo
                var _path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\blogs");
                var imageurl = _adminService.GetByIdBlog(model.BlogId).ImageUrl;
                System.IO.File.Delete(System.IO.Path.Combine(_path, imageurl));

                var entity = _adminService.GetByIdBlog(model.BlogId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.ImageUrl = randomName;
                entity.Content = model.Content;
                entity.Title = model.Title;
                entity.Description = model.Description;

                if (_adminService.UpdateBlog(entity))
                {
                    return RedirectToAction("BlogPost", "Admin");
                }
            }

            if (file == null && ModelState.IsValid)
            {
                var entity = _adminService.GetByIdBlog(model.BlogId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.Content = model.Content;
                entity.Title = model.Title;
                entity.Description = model.Description;
                entity.ImageUrl = entity.ImageUrl;

                if (_adminService.UpdateBlog(entity))
                {
                    return RedirectToAction("BlogPost", "Admin");
                }
            }

            return View();
        }

        public void BlogDelete(int id)
        {
            var data = _adminService.GetByIdBlog(id);

            if (_adminService.DeleteBlog(data))
            {
                var _path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\blogs");
                System.IO.File.Delete(System.IO.Path.Combine(_path, data.ImageUrl));
            }

            Response.Redirect(Url.Action("BlogPost", "Admin"));
        }
        #endregion

        #region Ürünler 
        [HttpGet]
        public IActionResult AddProduct()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);

                var categories = _adminService.GetAllCategory();
                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var item in categories)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.categoryID.ToString() });
                }

                list.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz..."
                });
                ViewBag.categoryList = list;
                return View();
            }

            return View("Login");
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel model, IEnumerable<IFormFile> files)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                model.GuidNumber = Guid.NewGuid().ToString();
                model.ProductNumber = "Urun" + (new Random()).Next(111111, 999999).ToString();
                if (ModelState.IsValid)
                {
                    var entity = new Product()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price,
                        Stock = model.Stock,
                        IsApproved = false,
                        IsHome = false,
                        SubCategoryId = model.SubCategoryId,
                        CategoryId = model.CategoryId,
                        CreatedDate = DateTime.Now,
                        MemberID = model.MemberID,
                        GuidNumber = model.GuidNumber,
                        ProductNumber = model.ProductNumber

                    };

                    if (_adminService.CreateProduct(entity))
                    {
                        ProductImage(model.ProductNumber, files);
                    }

                    return View("Default");
                }
                else
                {
                    ViewBag.ErrorMessage = "Tüm bilgilerin eksiksiz olduğundan emin olun .";
                    return View(model);
                }
            }
            return View();
        }

        public void ProductImage(string productNumber, IEnumerable<IFormFile> files)
        {
            if (files.Count() > 0)
            {
                foreach (var formFile in files)
                {
                    var extention = Path.GetExtension(formFile.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", randomName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        formFile.CopyToAsync(stream);
                    }

                    var data_id = _adminService.GetByIdProduct(productNumber).ProductId;

                    var entity_image = new ProductImage()
                    {
                        Url = randomName,
                        Size = (int)formFile.Length,
                        Type = formFile.ContentType,
                        ProductId = data_id

                    };
                    if (_adminService.CreateProductImage(entity_image))
                    {
                        //mesaj
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult UnapprovedMyProducts()
        {
            HttpContext.Session.Remove("SuccessUpdateMessage");
            HttpContext.Session.Remove("ErrorUpdateMessage");
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var products = _adminService.GetUnapprovedMyProducts(Convert.ToInt32(memberID));
                if (products != null)
                {
                    return View(products);
                }
                else
                {
                    ViewBag.ErrorMessage = "Henüz ürününüz bulunmamaktadır.";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult ApprovedMyProducts()
        {
            HttpContext.Session.Remove("SuccessUpdateMessage");
            HttpContext.Session.Remove("ErrorUpdateMessage");
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var products = _adminService.GetApprovedMyProducts(Convert.ToInt32(memberID));
                if (products != null)
                {
                    return View(products);
                }
                else
                {
                    ViewBag.ErrorMessage = "Henüz ürününüz bulunmamaktadır.";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditMyProduct(string productID)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var categories = _adminService.GetAllCategory();
                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var item in categories)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.categoryID.ToString() });
                }

                list.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.categoryList = list;

                var sub_categories = _adminService.GetAllSubCategories();
                List<SelectListItem> list_subcategory = new List<SelectListItem>();
                foreach (var item in sub_categories)
                {
                    list_subcategory.Add(new SelectListItem { Text = item.Name, Value = item.subCategoryID.ToString() });
                }

                list_subcategory.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.sub_categories = list_subcategory;

                var products = _adminService.GetByIdProduct(productID.ToString());
                if (products != null)
                {
                    return View(products);
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult UpdateProductCategories(int CategoryId, int SubCategoryId, int product_id, string url)
        {
            if (url != null)
            {
                if (_adminService.UpdateProductCategories(CategoryId, SubCategoryId, product_id))
                {
                    HttpContext.Session.SetString("SuccessUpdateMessage", "Ürününüzün kategorisi başarıyla güncellendi.");
                    return Redirect(url);
                }
                else
                {
                    HttpContext.Session.SetString("ErrorUpdateMessage", "Ürününüzün kategorisi güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                    return Redirect(url);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProductInfo(string name, string description, double price, int Stock, string url, int product_id)
        {
            if (url != null)
            {
                if (_adminService.UpdateProductInfo(name, description, price, Stock, product_id))
                {
                    HttpContext.Session.SetString("SuccessUpdateMessage", "Ürün bilgileriniz başarılı bir şekilde güncellendi.");
                    return Redirect(url);
                }
                else
                {
                    HttpContext.Session.SetString("ErrorUpdateMessage", "Ürün bilgileriniz güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                    return Redirect(url);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProductImages(IFormFile file, int images_id, string imageUrl, string url)
        {
            if (url != null && file != null && imageUrl != null && url != null)
            {
                var extention = Path.GetExtension(file.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", randomName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }

                if (_adminService.UpdateProductImage(images_id, randomName))
                {
                    //delete product image 
                    var _path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products");
                    var imageurl = imageUrl;
                    System.IO.File.Delete(System.IO.Path.Combine(_path, imageurl));

                    HttpContext.Session.SetString("SuccessUpdateMessage", "Ürün fotoğrafınız başarılı bir şekilde güncellendi.");
                    return Redirect(url);
                }
                else
                {
                    HttpContext.Session.SetString("ErrorUpdateMessage", "Ürün fotoğrafınız güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                    return Redirect(url);
                }
            }
            HttpContext.Session.SetString("ErrorUpdateMessage", "Ürün fotoğrafınız güncellenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
            return Redirect(url);
        }

        [HttpPost]
        public IActionResult DeleteProductImage(string imageUrl, string url)
        {
            if (imageUrl != null && url != null)
            {
                if (_adminService.DeleteProductImage(imageUrl))
                {
                    var _path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products");
                    var imageurl = imageUrl;
                    System.IO.File.Delete(System.IO.Path.Combine(_path, imageurl));
                    HttpContext.Session.SetString("SuccessUpdateMessage", "Ürün fotoğrafınız başarılı bir şekilde silinmiştir.");
                    return Redirect(url);
                }
                else
                {
                    HttpContext.Session.SetString("ErrorUpdateMessage", "Ürün fotoğrafınız silinirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                    return Redirect(url);
                }
            }
            else
            {
                HttpContext.Session.SetString("ErrorUpdateMessage", "Ürün fotoğrafınız silinirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                return Redirect(url);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProductImage(IEnumerable<IFormFile> files, string url, string productNumber)
        {
            if (files.Count() > 0 && url != null && productNumber != null)
            {
                ProductImage(productNumber, files);
                HttpContext.Session.SetString("SuccessUpdateMessage", "Ürün fotoğraflarınız başarılı bir şekilde eklenmiştir.");
                return Redirect(url);
            }
            else
            {
                HttpContext.Session.SetString("ErrorUpdateMessage",
                    "Ürün fotoğraflarınız yüklenirken bir hata ile karşılaşıldı.Lütfen daha sonra tekrar deneyiniz.");
                return Redirect(url);
            }
        }

        [HttpGet]
        public IActionResult ProductApproval()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var data = _adminService.GetAllUnapprovedProducts();
                if (data != null)
                {
                    return View(data);
                }
                else
                {
                    ViewBag.ErrorMessage = "Onaylanacak ürün bulunamadı.";
                    return View();
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult ProductApprovalEdit(string id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var categories = _adminService.GetAllCategory();
                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var item in categories)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.categoryID.ToString() });
                }

                list.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.categoryList = list;

                var sub_categories = _adminService.GetAllSubCategories();
                List<SelectListItem> list_subcategory = new List<SelectListItem>();
                foreach (var item in sub_categories)
                {
                    list_subcategory.Add(new SelectListItem { Text = item.Name, Value = item.subCategoryID.ToString() });
                }

                list_subcategory.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.sub_categories = list_subcategory;

                var product = _adminService.GetByIdProduct(id.ToString());
                if (product != null)
                {
                    return View(product);
                }
                else
                {
                    ViewBag.ErrorMessage = "Hata !";
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult ProductApprovalUpdate(Product model)
        {
            if (model.ProductId != null)
            {
                if (_adminService.UpdateProductApproval(true, model.ProductId))
                {
                    return RedirectToAction("ProductApproval");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult MyApprovalProducts()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var member_id = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var my_products = _adminService.GetApprovedMyProducts(Convert.ToInt16(member_id));
                if (my_products != null)
                {
                    return View(my_products);
                }
                else
                {
                    ViewBag.ErrorMessage = "Onaylı ürününüz bulunamadı.";
                    return View();
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditMyApprovalProduct(string productID)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var categories = _adminService.GetAllCategory();
                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var item in categories)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.categoryID.ToString() });
                }

                list.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.categoryList = list;

                var sub_categories = _adminService.GetAllSubCategories();
                List<SelectListItem> list_subcategory = new List<SelectListItem>();
                foreach (var item in sub_categories)
                {
                    list_subcategory.Add(new SelectListItem { Text = item.Name, Value = item.subCategoryID.ToString() });
                }

                list_subcategory.Insert(0, new SelectListItem()
                {
                    Value = "0",
                    Text = "Seçiniz...",
                    Disabled = true
                });
                ViewBag.sub_categories = list_subcategory;

                var products = _adminService.GetByIdProduct(productID.ToString());
                if (products != null)
                {
                    return View(products);
                }
            }
            return View();
        }

        #endregion

        #region Mesajlaşma 
        [HttpGet]
        public IActionResult CreateMessage()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
              
                return View();

            }

            return View();
        }

        [HttpGet]
        public IActionResult AdminCreateMessage(int id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.memberID = id;
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var member = _memberService.GetById(id);
                if (member != null)
                {
                    ViewBag.memberName = member.Name + member.Surname;
                    return View();
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult AdminCreateMessage(CreateMessage model)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                var id = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                    string GuidKey = Guid.NewGuid().ToString();
                    var entity = new Message()
                    {
                        Content = model.Content,
                        MemberID = Convert.ToInt32(id),
                        Subject = model.Subject,
                        MessageToID = model.MemberID,
                        CreatedDate = DateTime.Now,
                        GuidNumber = GuidKey
                    };
                    if (_adminService.CreateMessage(entity))
                    {
                        return RedirectToAction("Default", "Admin");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Mesaj gönderirken hata oluştu.Daha sonra tekrar deneyin.";
                        return View(entity);
                    }
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessageMembers(CreateMessage model)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var admin = _memberService.GetByAdmin();
                string GuidKey = Guid.NewGuid().ToString();
                var entity = new Message()
                {
                    MemberID = Convert.ToInt32(memberID),
                    Content = model.Content,
                    CreatedDate = DateTime.Now,
                    Subject = model.Subject,
                    MessageToID = admin.MemberId,
                    GuidNumber = GuidKey
                };
                if (_adminService.CreateMessage(entity))
                {
                    return RedirectToAction("Default", "Admin");
                }
                else
                {
                    ViewBag.ErrorMessage = "Mesaj gönderirken hata oluştu.Daha sonra tekrar deneyin.";
                    return View(model);
                }
                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult MyMessages()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var messages = _adminService.GetAllMessages(Convert.ToInt16(memberID));
                if (messages != null)
                {
                    return View(messages);
                }
                else
                {
                    ViewBag.ErrorMessage = "Mesajınız bulunmamaktadır.";
                    return View();
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult MyMessagesAdmin()
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var messages = _adminService.GetAllMessages(Convert.ToInt16(memberID));
                if (messages != null)
                {
                    return View(messages);
                }
                else
                {
                    ViewBag.ErrorMessage = "Mesajınız bulunmamaktadır.";
                    return View();
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult MessagesDetail(string id)
        {
            if (string.IsNullOrEmpty(Request.Cookies["member_id"]))
            {
                RedirectToAction("Login", "Admin");
            }
            else
            {
                _adminService.UpdateMessageChecked(true, id);
                ViewBag.memberID = Request.Cookies["member_id"].ToString();
                var memberID = Request.Cookies["member_id"].ToString();
                ViewBag.member_name = Request.Cookies["member_name"].ToString();
                ViewBag.member_IsAdmin = Convert.ToBoolean(Request.Cookies["member_IsAdmin"]);
                var message = _adminService.GetByIdMessage(id);
                if (message != null)
                {
                    return View(message);
                }
            }

            return View();
        }
        #endregion

        public JsonResult GetSubCategory(int CategoryID)
        {
            var sub_category = _adminService.GetAllSubCategoryById(CategoryID);
            List<SelectListItem> list = new List<SelectListItem>();
            if (sub_category != null)
            {
                foreach (var item in sub_category)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.subCategoryID.ToString() });
                }
            }

            return Json(list);
        }

    }
}
