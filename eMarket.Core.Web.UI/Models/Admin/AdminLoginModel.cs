using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Admin
{
    public class AdminLoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail Adresi")]
        public string admin_email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string admin_password { get; set; }
    }
}
