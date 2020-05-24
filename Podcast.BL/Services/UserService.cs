using Podcast.BL.DataTransfer;
using Podcast.BL.Infrastructure;
using Podcast.BL.Interfaces;
using Podcast.DAL.Entities;
using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Services
{
     public class UserService : Service, IUserService
     {
          public UserService(IUnitOfWork database) : base(database)
          {
          }

          public Result Authenticate(UserDTO userDTO)
          {
               var user = Database.Users.FindFirst(u => u.Email == userDTO.Email && u.Password == userDTO.Password);
               if (user == null)
                    return new Result(false, "False password or email", "");
               return new Result(true, "", "");

          }

          public Result Register(UserDTO userDTO)
          {
               var result = new Result(false, "", "");
               var userEmail = Database.Users.FindFirst(u => u.Email == userDTO.Email);
               var userName = Database.Users.FindFirst(u => u.Name == userDTO.Name);
               if (userEmail == null && userName == null)
               {
                    User user = new User { Email = userDTO.Email, Name = userDTO.Name, Password = userDTO.Password };
                    Database.Users.Create(user);
                    Database.Save();
                    result = new Result(true, "", "");
               }
               else if (userEmail != null)
                    result = new Result(false, "Email is occuped", "Email");
               else if (userName != null)
                    result = new Result(false, "Name is occuped", "Name");
               return result;


          }
          public UserDTO GetUser(string Email)
          {
               var user = Database.Users.FindFirst(u => u.Email == Email);
               if (user == null)
                    return null;
               var userDTO = new UserDTO { Email = user.Email, Name = user.Name, Role = user.Role, Id = user.Id };
               userDTO.Songs = user.Songs.ToList().ConvertAll(s => new SongDTO { Id = s.Id, Name = s.Name });
               return userDTO;
          }
          public void AddSong(int id,string Email)
          {
               var song = Database.Songs.Get(id);
               if (song == null)
                    return;
               var user = Database.Users.FindFirst(u => u.Email == Email);
               if (user == null)
                    return;
               user.Songs.Add(song);
               Database.Save();
          }
          public void RemoveSong(int id, string Email)
          {
               var song = Database.Songs.Get(id);
               if (song == null)
                    return;
               var user = Database.Users.FindFirst(u => u.Email == Email);
               if (user == null)
                    return;
               user.Songs.Remove(song);
               Database.Save();
          }
     }

}
