using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Services
{
    public interface IProductService
    {
        public Task<OperationResult> CreateProductAsync(ProductViewModel product);

    }
}
