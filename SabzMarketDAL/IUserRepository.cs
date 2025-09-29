using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL
{
    public interface IUserRepository
    {
        Task<OperationResult> InsertUserAsync(UserDTO user);
        Task<OperationResult> CheckUserAsync(UserDTO user);
        Task<OperationResult> CheckUserToSellerAsync(UserDTO user);
        Task<OperationResult> CheckPassword(UserDTO user);

    }
}
