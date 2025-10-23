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
        Task<OperationResult> CheckUserToSellerAsync(string username);
        Task<OperationResult> CheckUserAsync(string username);
        Task<OperationResult> CheckPasswordAsync(UserDTO user);
        Task<OperationResult> Login(UserDTO user);
    }
}
