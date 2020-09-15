using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;

namespace eMarket.Core.Data.Abstract
{
    public interface IAdminRepository
    {
        #region MyClass Blog 
        Blog GetByIdBlog(int id);
        bool CreateBlog(Blog entity);
        bool UpdateBlog(Blog entity);
        bool DeleteBlog(Blog entity);
        List<Blog> GetAllBlogPost();
        #endregion

        #region MyClass Category 
        List<Category> GetAllCategory();
        List<SubCategory> GetAllSubCategories();
        List<SubCategory> GetAllSubCategoryById(int categoryID);
        #endregion

        #region MyClass Products 
        List<Product> GetUnapprovedMyProducts(int memberID);
        List<Product> GetApprovedMyProducts(int memberID);
        List<Product> GetAllUnapprovedProducts();
        List<Product> GetAllApprovedProducts();
        Product GetByIdProduct(string id);
        bool CreateProduct(Product entity);
        bool CreateProductImage(ProductImage entity);
        bool UpdateProductCategories(int CategoryId, int SubCategoryId, int product_id);
        bool UpdateProductInfo(string name, string description, double price, int Stock, int product_id);
        bool UpdateProductImage(int productImageID, string imageUrl);
        bool DeleteProductImage(string imageUrl);
        bool UpdateProductApproval(bool check, int productID);
        List<Product> GetAllApprovedProductsById(int memberID);
        List<Product> GetAllUnapprovedProductsById(int memberID);
        bool GetProductHomeImageCheck(int productID);
        #endregion

        #region MyClass Message 
        public List<Message> GetAllMessages(int memberID);
        public List<Message> GetAllUnreadMessages(int memberID);
        public List<Message> GetAllReadMessages(int memberID);
        public List<Message> GetAllMessages();
        public Message GetByIdMessage(string id);
        bool CreateMessage(Message entity);
        bool UpdateMessageChecked(bool check, string guidNumber);

        #endregion
    }
}
