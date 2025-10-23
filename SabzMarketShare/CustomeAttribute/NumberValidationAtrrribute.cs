using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketShare.CustomeAttribute
{
    public class NumberValidationAtrrribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().StartsWith("09"))
                return new ValidationResult("");
            else
                return new ValidationResult(MessageDTO.numberInvalid2);
        }
    }
}
