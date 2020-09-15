using System;
using System.Collections.Generic;
using System.Text;
using eMarket.Core.Business.Abstract;
using eMarket.Core.Data.Abstract;
using eMarket.Core.Entity;

namespace eMarket.Core.Business.Concrete
{
   public class MemberManager : IMemberService
    {
        private IMemberRepository _memberRepository;
        public MemberManager(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public bool Create(Member entity)
        {
            if (entity != null)
            {
                _memberRepository.Create(entity);
                return true;
            }

            return false;
        }

        public List<Member> GetAllMembers()
        {
            return _memberRepository.GetAll();
        }

        public Member GetByAdmin()
        {
            return _memberRepository.GetByAdmin();
        }

        public Member GetById(int id)
        {
            return _memberRepository.GetById(id);
        }

        public Member GetByMailAndPasswordWithUser(string admin_email, string admin_password)
        {
            return _memberRepository.GetByMailAndPasswordWithUser(admin_email, admin_password);
        }

        public bool Update(Member entity)
        {
            return _memberRepository.Update(entity);
        }
    }
}
