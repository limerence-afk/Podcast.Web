using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Entities
{
    public class User
     {
          public User()
          {
             Songs = new List<Song>();
          }

          public int Id { get; set; }
          public string Name { get; set; }
          public string Password { get; set; }
          public string Email { get; set; }
          public virtual ICollection<Song> Songs { get; set; }
          public string Role { get; set; }
     }
     
}
