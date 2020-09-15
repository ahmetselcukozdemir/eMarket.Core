using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Account
{
    public class LoginModel
    {
        [Required]
        [DisplayName("E-mail Adresi")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
    }
}
