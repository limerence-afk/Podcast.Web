using Podcast.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Podcast.Web.Controllers
{
    public class MusicController : BaseController
    {
       
        public ActionResult Index()
        {
               var model = new MusicPageModel { User = UserService.GetUser(User.Identity.Name), Songs = SongService.GetAll() };
                    return View(model);
        }
    }
}