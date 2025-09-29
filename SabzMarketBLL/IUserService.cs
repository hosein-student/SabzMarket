using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBLL
{
    public interface IUserService
    {
        Task<OperationResult> InsertUserAsync(UserDTO user);
        Task<OperationResult> CheckUserToSellerAsync(UserDTO user);
        Task<OperationResult> FoundUserAsync(UserDTO user);
        Task<OperationResult> CheckPasswordAsync(UserDTO user);
    }
}
