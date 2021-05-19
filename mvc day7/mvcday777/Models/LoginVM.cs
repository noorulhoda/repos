using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcday777.Models
{
    public class LoginVM
    {
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}