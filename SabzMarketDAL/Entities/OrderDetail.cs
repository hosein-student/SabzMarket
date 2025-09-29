using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int Number { get; set; }
        
    }
}
