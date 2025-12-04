using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket
{
    public class OrderDetailEventArgs: EventArgs
    {
        public OrderDetailEventArgs(long id,UC_Orders uC_Orders) 
        {
            Id = id;
            C_Orders = uC_Orders;
        }
        public long Id { get; set; }
        public UC_Orders C_Orders;
    }
}
