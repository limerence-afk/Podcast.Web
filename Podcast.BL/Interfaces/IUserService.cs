using Podcast.BL.DataTransfer;
using Podcast.BL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Interfaces
{
     public interface IUserService
     {
          Result Authenticate(UserDTO userDTO);
          Result Register(UserDTO userDTO);
          UserDTO GetUser(string Email);
          void AddSong(int id, string Email);
          void RemoveSong(int id, string Email);
     }
}
