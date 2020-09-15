using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Business.Abstract;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Concrete
{
    public class AccountManager :  IAccountService
    {
        private IAccountRepository _accountRepository;
        public AccountManager(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public bool AddMyFavoriteProducts(ProductFavorite entity)
        {
            if (entity != null)
            {
                _accountRepository.AddMyFavoriteProducts(entity);
                return true;
            }

            return false;
        }

        public bool Create(User entity)
        {
            if (entity != null)
            {
                _accountRepository.Create(entity);
                return true;
            }
            return false;
        }

        public List<ProductFavorite> GetAllFavoriteProducts(int id)
        {
            return _accountRepository.GetAllFavoriteProducts(id);
        }

        public List<User> GetAllUsers()
        {
            return _accountRepository.GetAllUsers();
        }

        public User GetById(int id)
        {
            return _accountRepository.GetById(id);
        }

        public User GetByMailAndPasswordWithUser(string mail, string password)
        {
            return _accountRepository.GetByMailAndPasswordWithUser(mail, password);
        }

        public bool Update(User entity)
        {
            return _accountRepository.Update(entity);
        }
}
}
