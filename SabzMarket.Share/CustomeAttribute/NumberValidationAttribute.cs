using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.CustomeAttribute
{
    public class NumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult(Messages.Mandatory);
            if (value.ToString().Length < 11)
                return new ValidationResult(Messages.numberInvalid1);
            if (value.ToString().Length > 11)
                return new ValidationResult(Messages.numberInvalid2);
            if (!value.ToString().StartsWith("09"))
                return new ValidationResult(Messages.numberInvalid2);
            return ValidationResult.Success;


        }
    }
}
