using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Entity;

namespace eMarket.Business.Abstract
{
    public interface IAdminService
    {
        #region Blog 
        Blog GetByIdBlog(int id);
        bool CreateBlog(Blog entity);
        bool DeleteBlog(Blog entity);
        bool UpdateBlog(Blog entity);
        List<Blog> GetAllBlogPost();
        #endregion

        #region Category 
        List<Category> GetAllCategory();
        List<SubCategory> GetAllSubCategories();
        List<Product> GetUnapprovedMyProducts(int memberID);
        List<Product> GetApprovedMyProducts(int memberID);
        List<SubCategory> GetAllSubCategoryById(int categoryID);
        #endregion

        #region Product 
        bool CreateProduct(Product entity);
        bool CreateProductImage(ProductImage entity);
        Product GetByIdProduct(string id);
        bool UpdateProductCategories(int CategoryId, int SubCategoryId, int product_id);
        bool UpdateProductInfo(string name, string description, double price, int Stock, int product_id);
        bool UpdateProductImage(int productImageID, string imageUrl);
        bool DeleteProductImage(string imageUrl);
        List<Product> GetAllUnapprovedProducts();
        List<Product> GetAllUnapprovedProductsById(int memberID);
        List<Product> GetAllApprovedProducts();
        List<Product> GetAllApprovedProductsById(int memberID);
        bool UpdateProductApproval(bool check, int productID);

        #endregion

        #region Message 
        public List<Message> GetAllMessages(int memberID);
        bool CreateMessage(Message entity);
         Message GetByIdMessage(string id);
        bool UpdateMessageChecked(bool check, string guidNumber);
        public List<Message> GetAllUnreadMessages(int memberID);
        public List<Message> GetAllReadMessages(int memberID);
        #endregion
    }
}
