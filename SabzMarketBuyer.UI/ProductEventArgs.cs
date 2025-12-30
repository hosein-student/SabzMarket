using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBuyer.UI
{
    public class ProductEventArgs<t>:EventArgs
    {
        public CartItemDTO CartItemDTO {  get; set; }
        public FullCartItemDTO fullCartItemDTO { get; set; }
        public t uCProduct { get; set; }   
    }
}
