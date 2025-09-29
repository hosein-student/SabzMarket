using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL
{
    public interface ISellerRepositoty
    {
        Task<OperationResult> InsertSelllerAsync(string userName,SellerDTO user);
        Task<OperationResult<SellerDTO>> SelectSellerAsync(string userName);
        Task<OperationResult> UpdateSellerAsync(string userName,SellerDTO sellerDTO);
    }
}
    