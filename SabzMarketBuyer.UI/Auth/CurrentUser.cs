using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBuyer.UI.Auth
{
    public static class CurrentUser
    {
        public static long UserId { get; set; }
        public static long FarmerId { get; set; }
        public static string? UserName { get; set; }
    }
}
