using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL.Entities
{
    public class Categorie
    {
        public long Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
