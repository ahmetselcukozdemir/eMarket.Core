using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace eMarket.Core.Data.Concrete.EfCore
{
   public class EfCoreAdminRepository : IAdminRepository
    {
        #region Blog
        public bool CreateBlog(Blog entity)
        {
            using (var context = new eMarketContext())
            {
                context.Set<Blog>().Add(entity);
                context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool DeleteBlog(Blog entity)
        {
            using (var context = new eMarketContext())
            {
                context.Set<Blog>().Remove(entity);
                context.SaveChanges();
                return true;
            }

            return false;
        }
        public List<Blog> GetAllBlogPost()
        {
            using (var context = new eMarketContext())
            {
                var blogs = context.Blogs.ToList();
                return blogs;
            }
        }

        public Blog GetByIdBlog(int id)
        {
            using (var context = new eMarketContext())
            {
                return context.Set<Blog>().Find(id);
            }
        }

        public bool UpdateBlog(Blog entity)
        {
            using (var context = new eMarketContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }

            return false;
        }
        #endregion

        #region Product
        public bool CreateProduct(Product entity)
        {
            using (var context = new eMarketContext())
            {
                context.Set<Product>().Add(entity);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool CreateProductImage(ProductImage entity)
        {
            using (var context = new eMarketContext())
            {
                context.Set<ProductImage>().Add(entity);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Product> GetUnapprovedMyProducts(int memberID)
        {
            using (var context = new eMarketContext())
            {
                var products = context.Products.Where(x => x.MemberID == memberID && x.IsApproved == false).ToList();
                return products;
            }
        }
        public List<Product> GetApprovedMyProducts(int memberID)
        {
            using (var context = new eMarketContext())
            {
                var products = context.Products.Where(x => x.MemberID == memberID && x.IsApproved == true).ToList();
                return products;
            }
        }
        public List<Product> GetAllUnapprovedProducts()
        {
            using (var context = new eMarketContext())
            {
                var products = context.Products.Include("Member").Where(x => x.IsApproved == false && x.Member.IsActive == true).ToList();
                return products;
            }
        }

        public Product GetByIdProduct(string id)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Include("ProductImages")
                    .Include("Categories")
                    .Include("Member")
                    .Where(x => x.ProductNumber == id).FirstOrDefault();
            }
        }

        public bool UpdateProductCategories(int CategoryId, int SubCategoryId, int product_id)
        {
            using (var context = new eMarketContext())
            {
                var product = context.Products.Where(x => x.ProductId == product_id).FirstOrDefault();
                if (product != null)
                {
                    product.CategoryId = CategoryId;
                    product.SubCategoryId = SubCategoryId;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public bool UpdateProductInfo(string name, string description, double price, int Stock, int product_id)
        {
            using (var context = new eMarketContext())
            {
                var product = context.Products.Where(x => x.ProductId == product_id).FirstOrDefault();
                if (product != null)
                {
                    product.Name = name;
                    product.Description = description;
                    product.Price = price;
                    product.Stock = Stock;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public bool UpdateProductImage(int productImageID, string imageUrl)
        {
            using (var context = new eMarketContext())
            {
                var product_image = context.ProductImages.Where(x => x.ProductImageId == productImageID).FirstOrDefault();
                if (product_image != null)
                {
                    product_image.Url = imageUrl;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public bool DeleteProductImage(string imageUrl)
        {
            using (var context = new eMarketContext())
            {
                var product_images = context.ProductImages.Where(x => x.Url == imageUrl).FirstOrDefault();
                if (product_images != null)
                {
                    context.Set<ProductImage>().Remove(product_images);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
        public bool UpdateProductApproval(bool check, int productID)
        {
            using (var context = new eMarketContext())
            {
                var products = context.Products.Where(x => x.ProductId == productID && x.IsApproved == false).FirstOrDefault();
                if (products != null)
                {
                    products.IsApproved = check;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
        #endregion

        #region Category
        public List<Category> GetAllCategory()
        {
            using (var context = new eMarketContext())
            {
                var categories = context.Categories.ToList();
                return categories;
            }
        }
        public List<SubCategory> GetAllSubCategoryById(int categoryID)
        {
            using (var context = new eMarketContext())
            {
                var subCategories = context.SubCategories.Where(x => x.CategoryID == categoryID).ToList();
                return subCategories;
            }
        }
        public List<SubCategory> GetAllSubCategories()
        {
            using (var context = new eMarketContext())
            {
                return context.SubCategories.ToList();
            }
        }
        #endregion

        #region Message

        public List<Message> GetAllMessages(int memberID)
        {
            using (var context = new eMarketContext())
            {
                return context.Messages.Include("Member").Where(x => x.MessageToID == memberID).ToList();
            }
        }
        public List<Message> GetAllMessages()
        {
            using (var context = new eMarketContext())
            {
                return context.Messages.ToList();
            }
        }

        public bool CreateMessage(Message entity)
        {
            using (var context = new eMarketContext())
            {
                context.Set<Message>().Add(entity);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public Message GetByIdMessage(string id)
        {
            using (var context = new eMarketContext())
            {
                return context.Messages.Where(x => x.GuidNumber == id).FirstOrDefault();
            }
        }

        public bool UpdateMessageChecked(bool check, string guidNumber)
        {
            using (var context = new eMarketContext())
            {
                var message = context.Messages.Where(x => x.GuidNumber == guidNumber).FirstOrDefault();
                if (message != null)
                {
                    message.IsChecked = check;
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public List<Message> GetAllUnreadMessages(int memberID)
        {
            using (var context = new eMarketContext())
            {
                return context.Messages.Where(x => x.MessageToID == memberID && x.IsChecked == false).ToList();
            }
        }

        public List<Message> GetAllReadMessages(int memberID)
        {
            using (var context = new eMarketContext())
            {
                return context.Messages.Where(x => x.MessageToID == memberID && x.IsChecked == true).ToList();
            }
        }

        public List<Product> GetAllApprovedProductsById(int memberID)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Where(x => x.MemberID == memberID && x.IsApproved == true).ToList();
            }
        }

        public List<Product> GetAllUnapprovedProductsById(int memberID)
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Where(x => x.MemberID == memberID && x.IsApproved == false).ToList();
            }
        }

        public List<Product> GetAllApprovedProducts()
        {
            using (var context = new eMarketContext())
            {
                return context.Products.Where(x => x.IsApproved == true).ToList();
            }
        }

        public bool GetProductHomeImageCheck(int productID)
        {
            using (var context = new eMarketContext())
            {
                var data =context.ProductImages.Where(x => x.ProductId==productID && x.IsHome == true).FirstOrDefault();
                if (data !=null)
                {
                    return true;
                }

                return false;
            }
        }


        #endregion

    }
}
