using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface IOrderDetailRepository
    {
        public Task<OperationResult> SetOrderDetailStatusToSentAsync(long orderDetile);
        public Task<OperationResult> SetOrderDetailStatusToRejectedAsync(long orderDetile);
    }
}
