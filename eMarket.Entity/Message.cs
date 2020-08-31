using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eMarket.Entity
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID{ get; set; }
        public string GuidNumber { get; set; }
        public string Subject{ get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate{ get; set; }
        public int MemberID{ get; set; }
        public virtual Member Member { get; set; }
        public int MessageToID{ get; set; }
        public bool IsChecked { get; set; }
    }
}
