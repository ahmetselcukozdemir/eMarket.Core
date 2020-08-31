using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Entity
{
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductImageId{ get; set; }
        public string Url{ get; set; }
        public int Size{ get; set; }
        public DateTime CreatedDate{ get; set; }
        public string Type{ get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
