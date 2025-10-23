using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL.Entities
{
    public class Chat
    {
      
            public long Id { get; set; }
            public string Message { get; set; }

            public long FromUserId { get; set; }
            public User FromUser { get; set; }

            public long ToUserId { get; set; }
            public User ToUser { get; set; }
        

    }
}
