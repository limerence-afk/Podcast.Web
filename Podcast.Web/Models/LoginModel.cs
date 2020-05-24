using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Podcast.Web.Models
{
     public class LoginModel
     {
          [Required]
          public string Email { get; set; }
          [DataType(DataType.Password)]
          [Required]
          public string Password { get; set; }
          
          public bool Remember { get; set; }
          
     }
}