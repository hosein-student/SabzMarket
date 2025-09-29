using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketShare
{
    public static class PhoneNumberValidator
    {
        public static bool IsValidPhoneNumber(this string input)
        {
            if (input.Length == 11)
            {
                if (input.StartsWith("09"))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
