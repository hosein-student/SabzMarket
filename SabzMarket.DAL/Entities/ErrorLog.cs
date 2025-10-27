using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL.Entities
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public string? StackTrace { get; set; }
        public string? Source { get; set; }
        public string? Layer { get; set; } // مثلا API, Service, Data
        public DateTime CreatedAt { get; set; }
    }
}
