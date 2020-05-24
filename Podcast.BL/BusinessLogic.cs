using Podcast.BL.Interfaces;
using Podcast.BL.Services;
using Podcast.DAL.Interfaces;
using Podcast.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL
{
     public class BusinessLogic
     {
          IUnitOfWork Database;
          IUserService userService;
          ISongService songService;
          IAdminService adminService;

          public BusinessLogic()
          {
               Database = new UnitOfWork("DefaultConnection");

          }

          public IUserService UserService
          {
               get
               {
                    if (userService == null)
                         userService = new UserService(Database);
                    return userService;
               }
          }
          public ISongService SongService
          {
               get
               {
                    if (songService == null)
                         songService = new SongService(Database);
                    return songService;
               }
          }
          public IAdminService AdminService
          {
               get
               {
                    if (adminService == null)
                         adminService = new AdminService(Database);
                    return adminService;
               }
          }
     }
}
