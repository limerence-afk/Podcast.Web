using Podcast.DAL.Contexts;
using Podcast.DAL.Entities;
using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Repositories
{
    public class SongRepository : IRepository<Song>
     {
          DataContext Database;

          public SongRepository(DataContext database)
          {
               Database = database;
          }

          public void Create(Song item)
          {
               Database.Songs.Add(item);
          }

          public void Delete(int id)
          {
               Song Song = Get(id);
               Database.Songs.Remove(Song);
          }


          public IEnumerable<Song> Find(Func<Song, bool> predicate)
          {

               return Database.Songs.Where(predicate);

          }

          public Song FindFirst(Func<Song, bool> predicate)
          {
               return Find(predicate).FirstOrDefault();
          }

          public Song Get(int id)
          {
               Song Song = Database.Songs.Find(id);
               return Song;


          }

          public IEnumerable<Song> GetAll()
          {
               return Database.Songs.ToList();
          }

          public void Update(Song item)
          {
               Database.Entry(item).State = EntityState.Modified;

          }
     }
}
