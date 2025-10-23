using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public long SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public long CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Number { get; set; }
        [Column(TypeName = "nvarchar")]
        [Required]
        public string ImageProduct { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
