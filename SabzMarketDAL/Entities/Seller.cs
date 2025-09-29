﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL.Entities
{
    public class Seller
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
        [Column(TypeName ="nvarchar")]
        [StringLength(500)]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar")]
        public string ProfileImage { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(3)]
        [Required]
        public string WorkHistory { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        
    }
}
