using eMarket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMarket.Core.Data.Abstract
{
    public interface IAccountRepository : IRepository<User>
    {
        User GetById(int id);
        User GetByMailAndPasswordWithUser(string mail, string password);
        bool AddMyFavoriteProducts(ProductFavorite entity);
        List<ProductFavorite> GetAllFavoriteProducts(int id);
        List<User> GetAllUsers();
        bool Update(User entity);
    }
}
