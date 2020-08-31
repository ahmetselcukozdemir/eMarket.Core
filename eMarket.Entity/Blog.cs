using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Entity
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl{ get; set; }
        public string Content{ get; set; }
        public DateTime CreatedDate{ get; set; }
    }
}
