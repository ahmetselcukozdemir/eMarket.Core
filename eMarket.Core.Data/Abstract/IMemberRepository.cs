using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;

namespace eMarket.Core.Data.Abstract
{
    public interface IMemberRepository : IRepository<Member>
    {
        Member GetById(int id);
        Member GetByAdmin();
        Member GetByMailAndPasswordWithUser(string admin_email, string admin_password);
        List<Member> GetAllMembers();
        bool Update(Member entity);
    }
}
