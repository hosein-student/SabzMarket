using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Services
{
    public interface IOrderDetailService
    {
        public Task<OperationResult> MarkOrderDetailAsSentAsync(long orderDetaileId);
        public Task<OperationResult> MarkOrderDetailAsRejectedAsync(long orderDetaileId);
    }
}
