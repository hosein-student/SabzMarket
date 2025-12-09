using SabzMarket.Share;
using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket
{
    public class ProductEventArgs:EventArgs
    {
        public ProductEventArgs(ProductDTO product)
        {
            Product = product;
        }
       public ProductDTO Product { get; set; }
    }
}
