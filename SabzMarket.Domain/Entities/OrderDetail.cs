using SabzMarket.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Domain.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public virtual Order? Order { get; set; }
        public long ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Number { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string Status { get; set; }=OrderStatus.Pending.ToString();
    }
}
