using SabzMarket.Share.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SabzMarket.Share
{
    public class ProductViewModel:BaseValidatoin
    {
        public long Id { get; set; }
        [Required(ErrorMessage = Messages.ProductName)]
        public string Name { get; set; }
        [Required(ErrorMessage = Messages.ProductDescription)]
        [StringLength(500,ErrorMessage = Messages.ProductDescriptionLength)]
        public string Description { get; set; }
        [ProductNumberValidation]
        public int Number {  get; set; }
        [PriceValidation]
        public decimal Price { get; set; }
        [Required(ErrorMessage = Messages.ProductPhoto)]
        public string ProducPthoto { get; set; }
        [Required(ErrorMessage = Messages.ProductCategory)]
        public long CategoryId { get; set; }
    }
}
