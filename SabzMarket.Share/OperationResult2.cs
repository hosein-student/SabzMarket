using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SabzMarket.Share
{
    public class OperationResult<t>: OperationResult
    {
            public t? Data { get; set; }
            public static OperationResult<t> Successed(
                 t data, string message = "")
            {
                return new OperationResult<t>
                {
                    Success = true,
                    Message = message,
                    Data = data
                };
            }
            public static OperationResult<t> Failedd(
                string message = "", Exception? ex=null)
            {
                return new OperationResult<t>
                {
                    Success = false,
                    Message = message,
                    Exception=ex
                };
            }
    }
}
