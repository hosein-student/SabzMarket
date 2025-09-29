using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketShare
{
    public class OperationResult
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public static OperationResult Successed(
            string message="")
        { 
            return new OperationResult
            { Success = true,
              Message = message
            };
          
        }
        public static OperationResult Failed(
            string message="")
        {
            return new OperationResult
            {
                Success = false,
                Message = message
            };
        }


    }
}
