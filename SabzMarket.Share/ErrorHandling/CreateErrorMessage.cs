using System;
using System.Collections.Generic;
using System.Text;

namespace SabzMarket.Share.ErrorHandling
{
    public static class CreateErrorMessage
    {
        public static string ErrorMessage(this string message)
        {
            return string.Format($"{Messages.error}{Environment.NewLine}{Messages.codeError}{message}");

        }
    }
}
