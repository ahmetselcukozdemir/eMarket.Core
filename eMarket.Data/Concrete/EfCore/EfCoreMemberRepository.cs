using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMarket.Data.Abstract;
using eMarket.Entity;
using Microsoft.EntityFrameworkCore;

namespace eMarket.Data.Concrete.EfCore
{
    public class EfCoreMemberRepository : EfCoreGenericRepository<Member, eMarketContext>, IMemberRepository
    {
        public List<Member> GetAllMembers()
        {
            using (var context = new eMarketContext())
            {
                var members = context.Members.ToList();
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
                var member = context.Members.Where(x => x.Email == admin_email && x.Password == admin_password).FirstOrDefault();
                return member;
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
