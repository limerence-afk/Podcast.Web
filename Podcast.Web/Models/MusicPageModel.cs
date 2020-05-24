using Podcast.BL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Podcast.Web.Models
{
     public class MusicPageModel
     {
          public UserDTO User { get; set; }
          public IEnumerable<SongDTO> Songs {get;set;}
     }
}