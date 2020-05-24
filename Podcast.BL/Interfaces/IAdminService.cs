using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Podcast.BL.Interfaces
{
    public interface IAdminService 
     {
          bool AddSong(HttpPostedFileBase file, string directory);
          void DeleteSong(int id, string directory);
     }
}
