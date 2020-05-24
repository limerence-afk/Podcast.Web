using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.BL.Infrastructure
{
    public class Result
     {
          public Result(bool succedeed, string msg, string cause)
          {
               Succedeed = succedeed;
               Msg = msg;
               Cause = cause;
          }

       public bool Succedeed { get; set; }
       public string Msg { get; set; }
       public string Cause { get; set; }

       }
}
