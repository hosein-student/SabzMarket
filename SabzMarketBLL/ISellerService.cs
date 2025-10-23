using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBLL
{
    public interface ISellerService
    {
        Task<OperationResult> InsertSellerAsync(SellerDTO seller);
        Task<OperationResult<SellerDTO>> SelectSellerAsync(string userName);
        Task<OperationResult> UpdateSellerAsync(SellerDTO sellerDTO);
    }
}
