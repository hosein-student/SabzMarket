using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.CustomeAttribute
{
    public class NumberValidationAtrrribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().StartsWith("09"))
                return new ValidationResult("");
            else
                return new ValidationResult(Messages.numberInvalid2);
        }
    }
}
