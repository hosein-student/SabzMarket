using System;
using System.Collections.Generic;
using System.Text;

namespace SabzMarket.Share
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProducPthoto { get; set; }
        public long CategoryId { get; set; }
    }
}
