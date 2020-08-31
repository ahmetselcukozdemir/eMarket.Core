using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Entity
{
   public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId{ get; set; }
        public string GuidNumber{ get; set; }
        public string ProductNumber{ get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock{ get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public DateTime CreatedDate{ get; set; }
        public int CategoryId{ get; set; }
        public int SubCategoryId{ get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public int MemberID{ get; set; }
        public virtual Member Member { get; set; }
        public List<Category> Categories { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
