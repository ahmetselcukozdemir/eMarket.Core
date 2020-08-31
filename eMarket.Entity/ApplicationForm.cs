using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eMarket.Entity
{
  public  class ApplicationForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationFormId { get; set; }

        public int Age { get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Subject{ get; set; }
        public int Phone { get; set; }
        public string Message{ get; set; }
        public string InstagramAddress{ get; set; }
        public string FacebookAddress { get; set; }
    }
}
