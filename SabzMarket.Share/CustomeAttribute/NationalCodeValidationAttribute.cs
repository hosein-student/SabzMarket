using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.CustomeAttribute
{
    public class NationalCodeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var nationalCode = value as string;

            if (string.IsNullOrWhiteSpace(nationalCode))
                return ValidationResult.Success; 

            if (nationalCode.Length != 10 || !nationalCode.All(char.IsDigit))
                return new ValidationResult(Messages.NotValidNationalCode);

            var invalidCodes = new[]
            {
            "0000000000","1111111111","2222222222","3333333333","4444444444",
            "5555555555","6666666666","7777777777","8888888888","9999999999"
        };

            if (invalidCodes.Contains(nationalCode))
                return new ValidationResult(Messages.NotValidNationalCode);

            var check = Convert.ToInt32(nationalCode.Substring(9, 1));
            var sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += Convert.ToInt32(nationalCode.Substring(i, 1)) * (10 - i);
            }

            var remainder = sum % 11;

            var isValid = (remainder < 2 && check == remainder) ||
                          (remainder >= 2 && check == (11 - remainder));

            return isValid ? ValidationResult.Success : new ValidationResult(Messages.NotValidNationalCode);

        }
    }
}
