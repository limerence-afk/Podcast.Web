using Podcast.BL.DataTransfer;
using Podcast.Web.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace Podcast.Web.Controllers
{
     public class AccountController : BaseController
     {

          public ActionResult Login()
          {

               return View();

          }
          public ActionResult Register()
          {
               return View();
          }
          [HttpPost]
          public ActionResult Register(RegisterModel model)

          {
               if (ModelState.IsValid)
               {
                    UserDTO userDTO = new UserDTO { Email = model.Email, Password = model.Password, Name = model.Name, Role = "user" };
                    var result = UserService.Register(userDTO);
                    if (result.Succedeed)
                    {
                         return RedirectToAction("Login");
                    }
                    ModelState.AddModelError(result.Cause, result.Msg);

               }
               return View(model);
          }
          [HttpPost]
          public ActionResult Login(LoginModel model)
          {
               if (ModelState.IsValid)
               {


                    UserDTO userDTO = new UserDTO { Email = model.Email, Password = model.Password };
                    var result = UserService.Authenticate(userDTO);
                    if (result.Succedeed)
                    {
                         FormsAuthentication.SetAuthCookie(model.Email, model.Remember);
                         return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", result.Msg);
               }
               return View(model);


          }
          [Authorize]
          public ActionResult Saved()
          {
               var user = UserService.GetUser(User.Identity.Name);
               return View(user);
          }
          [Authorize]
          public ActionResult RemoveSong(int songId)
          {
               UserService.RemoveSong(songId, User.Identity.Name);
               return RedirectToAction("Saved","Account");
          }
          [Authorize]
          public ActionResult AddSong(int songId)
          {
               UserService.AddSong(songId, User.Identity.Name);
               
               return RedirectToAction("Index", "Music");

          }
          [Authorize]
          public ActionResult LogOut()
          {
               FormsAuthentication.SignOut();
               return RedirectToAction("Index", "Home");
          }

     }

}