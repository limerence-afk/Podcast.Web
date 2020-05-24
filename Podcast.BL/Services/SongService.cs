using Podcast.BL.DataTransfer;
using Podcast.BL.Interfaces;
using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Services
{
     public class SongService : Service, ISongService
     {
          public SongService(IUnitOfWork database) : base(database)
          {
          }

          public IEnumerable<SongDTO> GetAll()
          {
               return Database.Songs.GetAll().ToList().ConvertAll(
                    s => new SongDTO
                    {
                         Id = s.Id,
                         Name = s.Name
                    }
              );
          }
     }
}
