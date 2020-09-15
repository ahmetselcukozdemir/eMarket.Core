using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Core.Entity
{
    public class ProductFavorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductFavoriteId { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
    }
}
