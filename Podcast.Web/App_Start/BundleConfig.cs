using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Podcast.Web
{
     public class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               bundles.Add(new StyleBundle("~/bundles/css")
                   .Include("~/Content/bootstrap.min.css",
                   "~/Content/mdb.min.css", "~/Content/style.css"
                   ));
               bundles.Add(new ScriptBundle("~/bundles/script")
                    .Include("~/Scripts/jquery-3.4.1.min.js",
                   "~/Scripts/popper.min.js",
                   "~/Scripts/bootstrap.min.js",
                   "~/Scripts/mdb.min.js"
                 ));
               bundles.Add(new ScriptBundle("~/bundles/main")
                    .Include("~/Scripts/main.js"));
               bundles.Add(new StyleBundle("~/bundles/home")
                    .Include("~/Content/home.css"));
          }
     }
}