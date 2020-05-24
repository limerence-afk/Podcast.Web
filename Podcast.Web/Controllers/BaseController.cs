using Podcast.BL;
using Podcast.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Podcast.Web.Controllers
{
    public abstract class BaseController : Controller
    {
          BusinessLogic businessLogic;
          protected IUserService UserService => businessLogic.UserService; 
          protected ISongService SongService => businessLogic.SongService;
          protected IAdminService AdminService => businessLogic.AdminService;
          public BaseController()
          {
               businessLogic = new BusinessLogic();
               
          }
     }
}