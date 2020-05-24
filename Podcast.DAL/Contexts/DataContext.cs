using Podcast.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Contexts
{
    public class DataContext: DbContext
     {
          static DataContext()
          {
               Database.SetInitializer(new Initializer());
          }
          public DataContext(string nameOrConnectionString) : base(nameOrConnectionString)
          {
          }

          public DbSet<User> Users { get; set; }
          public DbSet<Song> Songs { get; set; }
     }
     class Initializer : CreateDatabaseIfNotExists<DataContext>
     {
          protected override void Seed(DataContext context)
          {
               base.Seed(context);
               context.Users.Add(new User { Email = "admin@gmail.com", Name = "Admin", Password = "admin", Role = "admin" });
               context.SaveChanges();
          }

     }
}
