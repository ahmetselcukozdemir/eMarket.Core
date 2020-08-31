using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Web.UI.Models.Admin
{
    public class CreateMessage
    {
        public Guid GuidNumber { get; set; }
        public string Subject{ get; set; }
        public string Content { get; set; }
        public int MemberID{ get; set; }
        public int MessageToID { get; set; }
    }
}
