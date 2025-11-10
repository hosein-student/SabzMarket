using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SabzMarket.Share.CustomeAttribute
{
    public class ComparePasswordAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherProperty = validationContext.ObjectType.GetProperty("Password2");
            var otherValue = otherProperty.GetValue(validationContext.ObjectInstance);
            if(string.IsNullOrEmpty(value.ToString()))
                 return new ValidationResult(Messages.EnterPassword);

            if (!value.Equals(otherValue))
                return new ValidationResult(Messages.passwordNotMatch);
            return ValidationResult.Success;

        }
    }
}
