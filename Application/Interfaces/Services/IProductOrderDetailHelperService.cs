using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IProductOrderDetailHelperService
    {
        public Task<OperationResult> IncreaseNumberAsync(long id, int number);
        public Task<OperationResult> HasPendingOrdersForProductAsync(long productId);
    }
}
