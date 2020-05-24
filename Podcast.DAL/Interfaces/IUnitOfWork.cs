﻿using Podcast.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.DAL.Interfaces
{
      public interface IUnitOfWork : IDisposable
     {
          
          IRepository<Song> Songs { get; }
          
          IRepository<User> Users { get; }

          void Save();
     }
}
