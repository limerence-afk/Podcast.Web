using Podcast.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Podcast.Web.Attributes
{
     public class AdminAttribute : AuthorizeAttribute
     {
          BusinessLogic bl;


          public AdminAttribute()
          {
               bl = new BusinessLogic();
          }

          protected override bool AuthorizeCore(HttpContextBase httpContext)
          {
               return httpContext.Request.IsAuthenticated && Role(httpContext);
          }

          private bool Role(HttpContextBase httpContext)
          {
               var user = bl.UserService.GetUser(httpContext.User.Identity.Name);
               return user.Role == "admin";



          }
     }
}