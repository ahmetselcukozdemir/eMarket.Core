using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Web.UI.Models.Blog
{
    public class BlogModel
    {
        public int BlogId{ get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Content{ get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
