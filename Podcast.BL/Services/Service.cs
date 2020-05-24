using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Services
{
     public abstract class Service : IDisposable
     {
          protected IUnitOfWork Database;

          public Service(IUnitOfWork database)
          {
               Database = database;
          }

          public void Dispose()
          {
               Database.Dispose();
          }
     }
}
