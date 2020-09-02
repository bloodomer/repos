using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIRoutingExample.Models
{
    public class User
    {
        [Required]
        [StringLength(50,ErrorMessage ="Hatalı Giriş",MinimumLength =3)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}