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
     public class UserRepository : IRepository<User>
     {
          DataContext Database;

          public UserRepository(DataContext database)
          {
               Database = database;
          }

          public void Create(User item)
          {
               Database.Users.Add(item);
          }

          public void Delete(int id)
          {
               User user = Get(id);
               Database.Users.Remove(user);
          }

       
          public IEnumerable<User> Find(Func<User, bool> predicate)
          {

               return Database.Users.Where(predicate);
               
          }

          public User FindFirst(Func<User, bool> predicate)
          {
               return Find(predicate).FirstOrDefault();
          }

          public User Get(int id)
          {
               User user = Database.Users.Find(id);
               return user;


          }

          public IEnumerable<User> GetAll()
          {
              return Database.Users.ToList();
          }
            
          public void Update(User item)
          {
               Database.Entry(item).State = EntityState.Modified;
              
          }
     }
}
