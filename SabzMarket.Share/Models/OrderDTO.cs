using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Models
{
    public class OrderDTO
    {
        public long OrderId { get; set; }
        public long OrderDetailId { get; set; }
        public ProductViewModel? product { get; set; }
        public FarmerDTOForSeller? farmer { get; set; }
        public string? Status { get; set; }
    }
}
