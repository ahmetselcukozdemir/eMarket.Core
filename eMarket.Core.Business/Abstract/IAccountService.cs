using eMarket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMarket.Core.Business.Abstract
{
    public interface IAccountService
    {
        User GetById(int id);
        User GetByMailAndPasswordWithUser(string mail, string password);
        bool Create(User entity);
        bool Update(User entity);
        bool AddMyFavoriteProducts(ProductFavorite entity);
        List<ProductFavorite> GetAllFavoriteProducts(int id);
        List<User> GetAllUsers();
    }
}
