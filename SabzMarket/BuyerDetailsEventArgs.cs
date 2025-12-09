using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket
{
    public class BuyerDetailsEventArgs:EventArgs
    {
        public FarmerDTOForSeller? FarmerViewModel { get; set; }
    }
}
