using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public long SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public long FarmerId { get; set; }
        public virtual Farmer Farmer { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        [Required]
        public string Status { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }   
    }
}
