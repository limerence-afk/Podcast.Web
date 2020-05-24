using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.DataTransfer
{
    public class UserDTO
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public string Password { get; set; }
          public string Email { get; set; }
          public IEnumerable<SongDTO> Songs { get; set; }
          public string Role { get; set; }
     }
}
