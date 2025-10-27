using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class OperationResult
    {
        public bool Success { get; protected set; }
        public string? Message { get; protected set; }
        public Exception? Exception { get; protected set; }

        public static OperationResult Successed(bool success= true,
            string message = "")
        {
            return new OperationResult
            {
                Success = success,
                Message = message
            };

        }
        public static OperationResult Failed(
            string message = "", Exception? ex=null)
        {
            return new OperationResult
            {
                Success = false,
                Message = message,
                Exception=ex
            };
        }
        
    }
}
