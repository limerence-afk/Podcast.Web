using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Podcast.Web.Models
{
     public class FileModel
     {
          [DataType(DataType.Upload)]
          public HttpPostedFileBase File { get; set; }
     }
}