using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SabzMarket.Share.CustomeAttribute
{
    public class PriceValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult(Messages.ProductPrice);
            int productPrice;
            if (!int.TryParse(value.ToString(), out productPrice))
                return new ValidationResult(Messages.ValidProductPrice);
            if (productPrice == 0)
                return new ValidationResult(Messages.ProductPrice);
            return ValidationResult.Success;
        }
    }
}
