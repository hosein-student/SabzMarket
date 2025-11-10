using System;
using System.Collections.Generic;
using System.Text;

namespace SabzMarket.Share
{
    public class RequestPayload
    {
        public UserViewModel UserViewModel{get; set;}
        public SellerPartialViewModel SellerPartial { get; set; }

    }
}
