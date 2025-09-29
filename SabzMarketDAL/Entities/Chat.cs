using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL.Entities
{
    public class Chat
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public User FormId { get; set; }
        public User ToID { get; set; }
    }

}
