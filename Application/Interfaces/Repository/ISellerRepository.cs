using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface ISellerRepository
    {
        Task<OperationResult> InsertAsync(SellerDTO sellerDto);
        Task<OperationResult> UserExistsInSellerAsync(string username);
        Task<OperationResult<SellerDTO>> SelectByUsernameAsync(string username);
        Task<OperationResult>UpdateAsync(UserDTO userDto,SellerDTO sellerDto);
        Task<OperationResult<List<SellerDTO>>> SelectByPhoneNumberAsync(string phone);
        Task<OperationResult<SellerDTO>> SelectByIdAsync(long id);
    }
}
