using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IProductService
    {
        public Task<OperationResult> CreateProductAsync(ProductViewModel product);
        public Task<OperationResult<List<ProductDTO>>> GetProductsBySellerAsync(long sellerId);
        public Task<OperationResult> DeleteAsync(long id);
        public Task<OperationResult> UpdateAsync(ProductViewModel product);
        public Task<OperationResult<List<ProductDTO>>> GetByNameAsync(string search);

    }
}
