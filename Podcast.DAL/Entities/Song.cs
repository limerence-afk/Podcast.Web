using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Entities
{
     public class Song
     {
          public Song()
          {
               Users = new List<User>();
          }

          public int Id { get; set; }
          public string Name { get; set; }
     
          public virtual ICollection<User> Users { get; set; }
     }
}
