using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface IProductRepository
    {
        public Task<OperationResult> InsertAsync(ProductDTO product);
    }
}
