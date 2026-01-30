using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task< OperationResult >InsertAsync(UserDTO userDTO);
        Task< OperationResult >UpdateAsync(UserDTO userDTO);
        Task< OperationResult<UserDTO> >SelectAsync(string username);
        Task<OperationResult> CheckUserAsync(string username);
        Task<OperationResult> ChangePasswordAsync(UserDTO userDTO);
        
    }
}
