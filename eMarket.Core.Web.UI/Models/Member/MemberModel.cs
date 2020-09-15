using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Member
{
    public class MemberModel
    {
        public int MemberId{ get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastActivityDate { get; set; }

    }
}
