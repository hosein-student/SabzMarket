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
        Task<OperationResult> CheckUserAsync(string username);
        Task<OperationResult> CheckUserToSellerAsync(string username);
        Task<OperationResult> CheckPasswordAsync(string username, string password);

    }
}
