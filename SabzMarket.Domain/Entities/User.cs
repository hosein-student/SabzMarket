using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SabzMarket.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string? FirstName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string? LastName { get; set; }
        [Column(TypeName = "char")]
        [StringLength(11)]
        [Required]
        public string? Phone { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string? Email { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string? UserName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string? Password { get; set; }
        public virtual Seller? Seller { get; set; }
        public virtual Farmer? Farmer { get; set; }
    }
}
