﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Account
{
    public class RegisterModel
    {
        [Required]
        public string FirstName{ get; set; }
        [Required]
        public string LastName{ get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword{ get; set; }

    }
}
