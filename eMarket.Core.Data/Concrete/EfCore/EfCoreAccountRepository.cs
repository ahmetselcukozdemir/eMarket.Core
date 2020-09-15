using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;

namespace eMarket.Core.Data.Concrete.EfCore
{
    public class EfCoreAccountRepository : EfCoreGenericRepository<User, eMarketContext>, IAccountRepository
    {
        public bool AddMyFavoriteProducts(ProductFavorite entity)
        {
            using (var context = new eMarketContext())
            {
                context.Add(entity);
                context.SaveChanges();
                return true;
            }
        }

        public List<ProductFavorite> GetAllFavoriteProducts(int id)
        {
            using (var context = new eMarketContext())
            {
                var data = context.ProductFavorites.Where(x => x.userId == id).ToList();
                return data;
            }
        }

        public List<User> GetAllUsers()
        {
            using (var context = new eMarketContext())
            {
                var data = context.Users.ToList();
                return data;
            }
        }

        public User GetByMailAndPasswordWithUser(string mail, string password)
        {
            using (var context = new eMarketContext())
            {
                var user = context.Users.Where(x => x.Mail == mail && x.Password == password).FirstOrDefault();
                return user;
            }
        }

        public bool Update(User entity)
        {
            using (var context = new eMarketContext())
            {
                var user = context.Users.Where(x => x.UserId == entity.UserId).FirstOrDefault();
                if (user != null)
                {
                    user.FirstName = entity.FirstName;
                    user.Surname = entity.Surname;
                    user.Mail = entity.Mail;
                    user.Password = entity.Password;
                    user.Phone = entity.Phone;
                    user.IsActive = entity.IsActive;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

    }
}
