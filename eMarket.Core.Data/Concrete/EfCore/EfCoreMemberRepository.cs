using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace eMarket.Core.Data.Concrete.EfCore
{
   public class EfCoreMemberRepository : EfCoreGenericRepository<Member, eMarketContext>, IMemberRepository
    {
        public List<Member> AllMemberIsHome()
        {
            using (var context = new eMarketContext())
            {
                var members = context.Members.Where(x => x.IsAdmin == false && x.IsActive==true && x.IsCheck==true).ToList();
                return members;
            }
        }

        public List<Member> GetAllMembers()
        {
            using (var context = new eMarketContext())
            {
                var members = context.Members.Where(x=>x.IsAdmin==false).ToList();
                return members;
            }
        }

        public Member GetByAdmin()
        {
            using (var context = new eMarketContext())
            {
                var admin = context.Members.Where(x => x.IsAdmin == true).FirstOrDefault();
                return admin;
            }
        }

        public Member GetByMailAndPasswordWithUser(string admin_email, string admin_password)
        {
            using (var context = new eMarketContext())
            {
                var member = context.Members.Include("Products").Where(x => x.Email == admin_email && x.Password == admin_password).FirstOrDefault();
                return member;
            }
        }

        public List<Member> LastAddSellers()
        {
            using (var context = new eMarketContext())
            {
                return context.Members.Where(x => x.IsActive == true && x.IsAdmin == false)
                    .OrderByDescending(x => x.CreatedDate).Take(10).ToList();
            }
        }

        public List<Member> StarSellers()
        {
            using (var context = new eMarketContext())
            {
                return context.Members.Where(x => x.IsAdmin == false && x.IsActive == true && x.IsCheck == true)
                    .ToList();
            }
        }

        public bool Update(Member entity)
        {
            using (var context = new eMarketContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
