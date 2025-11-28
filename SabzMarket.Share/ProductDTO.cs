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
        public int Number { get; set; }
        public int Price { get; set; }
        public string ImageProduct { get; set; }
        public long CategoryId { get; set; }
        public long SellerId { get; set; }
    }
}
