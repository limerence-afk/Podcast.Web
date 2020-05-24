using Podcast.BL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Interfaces
{
    public interface ISongService 
     {
          IEnumerable<SongDTO> GetAll();
     }
}
