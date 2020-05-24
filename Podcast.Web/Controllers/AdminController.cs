using Podcast.Web.Attributes;
using System.Web;
using System.Web.Mvc;

namespace Podcast.Web.Controllers
{
     public class AdminController : BaseController
    {    

        [HttpPost]
        [Admin]
        public ActionResult UploadSong(HttpPostedFileBase file)
        {


               var directory = Server.MapPath("~/podcasts");
                    AdminService.AddSong(file, directory);
               
            return RedirectToAction("Index","Music");
        }
          [Admin]
          public ActionResult DeleteSong(int songId)
          {
               var directory = Server.MapPath("~/podcasts");
               AdminService.DeleteSong(songId, directory);
               return RedirectToAction("Index", "Music");
          }
    }
}