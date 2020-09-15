using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Admin.Product
{
    public class ProductModel
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public double Price{ get; set; }
        public int Stock{ get; set; }
        public string GuidNumber{ get; set; }
        public string ProductNumber{ get; set; }
        public int CategoryId{ get; set; }
        public int SubCategoryId { get; set; }
        public int MemberID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
