using Podcast.BL.Interfaces;
using Podcast.DAL.Entities;
using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Podcast.BL.Services
{
     public class AdminService : Service, IAdminService
     {
          public AdminService(IUnitOfWork database) : base(database)
          {
          }

          public bool AddSong(HttpPostedFileBase file, string directory)
          {
               if (file != null)
               {
                    var extention = Path.GetExtension(file.FileName);
                    if (extention == ".mp3")
                    {
                         var songName = Path.GetFileNameWithoutExtension(file.FileName);
                         
                        
                         if (!Directory.Exists(directory))
                              Directory.CreateDirectory(directory);
                         var song = new Song { Name = songName };
                         Database.Songs.Create(song);
                         Database.Save();
                         var fileSavePath = directory + "/" +
                           song.Id + extention;
                         file.SaveAs(fileSavePath);

                        
                         return true;
                    }
                    return false;
               }
               return false;
          }

          public void DeleteSong(int id, string directory)
          {
               var song = Database.Songs.Get(id);
               if( song != null) { 
               var path = directory + "/" + song.Id + ".mp3";
               if (File.Exists(path))
               {
                    File.Delete(path);
               }
               Database.Songs.Delete(song.Id);
               Database.Save();
               }
          }
     }
}
