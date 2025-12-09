using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface ISellerRepository
    {
        Task<OperationResult> InsertAsync(SellerDTO sellerDto);
        Task<OperationResult> UserExistsInSellerAsync(string username);
        Task<OperationResult<SellerDTO>> SelectByUsernameAsync(string username);
        Task<OperationResult>UpdateAsync(string username,UserDTO userDto,SellerDTO sellerDto);
    }
}
