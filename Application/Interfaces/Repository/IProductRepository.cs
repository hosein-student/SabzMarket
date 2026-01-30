using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface IProductRepository
    {
        public Task<OperationResult> InsertAsync(ProductDTO product);
        public Task<OperationResult> IncreaseNumberAsync(long id,int number);
        public Task<OperationResult<List<ProductDTO>>> GetAllBySellerAsync(long sellerId);
        public Task<OperationResult> DeleteAsync(long id);
        public Task<OperationResult> UpdateAsync(ProductDTO product);
        public Task<OperationResult<List<ProductDTO>>> SelectByNameAsync(string search);
    }
}
