using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Entity
{
    public class SubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int subCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID{ get; set; }
    }
}
