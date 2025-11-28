using System;
using System.Collections.Generic;
using System.Text;

namespace SabzMarket.Share
{
    public class ErrorLogDTO
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Layer { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Curl { get; set; }
        public string Route { get; set; }
    }
}
