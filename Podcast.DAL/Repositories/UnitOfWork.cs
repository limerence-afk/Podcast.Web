using Podcast.DAL.Contexts;
using Podcast.DAL.Entities;
using Podcast.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Repositories
{
     public class UnitOfWork : IUnitOfWork
     {

          DataContext Database;
          public UnitOfWork(string connection)
          {
               Database = new DataContext(connection);
               Users = new UserRepository(Database);
               Songs = new SongRepository(Database);
          }
          public IRepository<User> Users { get; }
          public IRepository<Song> Songs { get; }


          public void Save()
          {
               Database.SaveChanges();
          }

          #region IDisposable Support
          private bool disposedValue = false; // To detect redundant calls

          protected virtual void Dispose(bool disposing)
          {
               if (!disposedValue)
               {
                    if (disposing)
                    {
                         Database.Dispose();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
               }
          }

          // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
          // ~UnitOfWork()
          // {
          //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
          //   Dispose(false);
          // }

          // This code added to correctly implement the disposable pattern.
          public void Dispose()
          {
               // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
               Dispose(true);
               // TODO: uncomment the following line if the finalizer is overridden above.
               // GC.SuppressFinalize(this);
          }
          #endregion

     }
}
