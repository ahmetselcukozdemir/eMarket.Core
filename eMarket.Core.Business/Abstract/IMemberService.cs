using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Abstract
{
   public interface IMemberService
    {
        Member GetById(int id);
        Member GetByAdmin();
        bool Create(Member entity);
        bool Update(Member entity);
        List<Member> GetAllMembers();
        Member GetByMailAndPasswordWithUser(string admin_email, string admin_password);
    }
}
