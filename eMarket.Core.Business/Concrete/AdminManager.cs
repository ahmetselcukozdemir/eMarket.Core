using eMarket.Core.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Concrete
{
    public class AdminManager  : IAdminService
    {
        private IAdminRepository _adminRepository;

        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public bool CreateBlog(Blog entity)
        {
            if (entity != null)
            {
                _adminRepository.CreateBlog(entity);
                return true;
            }
            return false;
        }

        public bool CreateProduct(Product entity)
        {
            if (entity != null)
            {
                _adminRepository.CreateProduct(entity);
                return true;
            }

            return false;
        }

        public bool CreateProductImage(ProductImage entity)
        {
            if (entity != null)
            {
                _adminRepository.CreateProductImage(entity);
                return true;
            }

            return false;
        }

        public bool DeleteBlog(Blog entity)
        {
            if (entity != null)
            {
                _adminRepository.DeleteBlog(entity);
                return true;
            }

            return false;
        }

        public List<Blog> GetAllBlogPost()
        {
            return _adminRepository.GetAllBlogPost();
        }

        public List<Category> GetAllCategory()
        {
            return _adminRepository.GetAllCategory();
        }

        public List<Product> GetUnapprovedMyProducts(int memberID)
        {
            return _adminRepository.GetUnapprovedMyProducts(memberID);
        }

        public List<SubCategory> GetAllSubCategoryById(int categoryID)
        {
            return _adminRepository.GetAllSubCategoryById(categoryID);
        }
        public List<Product> GetAllUnapprovedProducts()
        {
            return _adminRepository.GetAllUnapprovedProducts();
        }

        public Blog GetByIdBlog(int id)
        {
            return _adminRepository.GetByIdBlog(id);
        }

        public bool UpdateBlog(Blog entity)
        {
            return _adminRepository.UpdateBlog(entity);
        }

        public List<Product> GetApprovedMyProducts(int memberID)
        {
            return _adminRepository.GetApprovedMyProducts(memberID);
        }

        public Product GetByIdProduct(string id)
        {
            return _adminRepository.GetByIdProduct(id);
        }

        public List<SubCategory> GetAllSubCategories()
        {
            return _adminRepository.GetAllSubCategories();
        }

        public List<Message> GetAllMessages(int memberID)
        {
            return _adminRepository.GetAllMessages(memberID);
        }

        public bool CreateMessage(Message entity)
        {
            if (entity != null)
            {
                _adminRepository.CreateMessage(entity);
                return true;
            }

            return false;
        }

        public bool UpdateProductCategories(int CategoryId, int SubCategoryId, int product_id)
        {
            if (CategoryId != null && SubCategoryId != null && product_id != null)
            {
                _adminRepository.UpdateProductCategories(CategoryId, SubCategoryId, product_id);
                return true;
            }

            return false;
        }

        public bool UpdateProductInfo(string name, string description, double price, int Stock, int product_id)
        {
            if (name != null && description != null && price != null && Stock != null && product_id != null)
            {
                _adminRepository.UpdateProductInfo(name, description, price, Stock, product_id);
                return true;
            }

            return false;
        }
        public bool UpdateProductImage(int productImageID, string imageUrl)
        {
            if (productImageID != null && imageUrl != null)
            {
                _adminRepository.UpdateProductImage(productImageID, imageUrl);
                return true;
            }

            return false;
        }

        public bool DeleteProductImage(string imageUrl)
        {
            if (imageUrl != null)
            {
                _adminRepository.DeleteProductImage(imageUrl);
                return true;
            }

            return false;
        }

        public bool UpdateProductApproval(bool check, int productID)
        {
            if (check != null && productID != null)
            {
                _adminRepository.UpdateProductApproval(check, productID);
                return true;
            }

            return false;
        }

        public Message GetByIdMessage(string id)
        {
            return _adminRepository.GetByIdMessage(id);
        }

        public bool UpdateMessageChecked(bool check, string guidNumber)
        {
            if (check != null && guidNumber != null)
            {
                return _adminRepository.UpdateMessageChecked(check, guidNumber);
                return true;
            }

            return false;
        }

        public List<Message> GetAllUnreadMessages(int memberID)
        {
            return _adminRepository.GetAllUnreadMessages(memberID);
        }

        public List<Message> GetAllReadMessages(int memberID)
        {
            return _adminRepository.GetAllReadMessages(memberID);
        }

        public List<Product> GetAllUnapprovedProductsById(int memberID)
        {
            return _adminRepository.GetAllUnapprovedProductsById(memberID);
        }

        public List<Product> GetAllApprovedProducts()
        {
            return _adminRepository.GetAllApprovedProducts();
        }

        public List<Product> GetAllApprovedProductsById(int memberID)
        {
            return _adminRepository.GetAllApprovedProductsById(memberID);
        }

        public bool GetProductHomeImageCheck(int productID)
        {
            return _adminRepository.GetProductHomeImageCheck(productID);
        }
    }
}
