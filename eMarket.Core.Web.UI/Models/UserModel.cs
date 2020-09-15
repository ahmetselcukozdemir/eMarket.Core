using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models
{
    public class UserModel
    {
        public int UserId{ get; set; }
        public string FirstName{ get; set; }
        public string Surname{ get; set; }
        public string Phone{ get; set; }
        public string Mail{ get; set; }
        public string Password{ get; set; }
        public bool IsActive{ get; set; }
       
    }
}
