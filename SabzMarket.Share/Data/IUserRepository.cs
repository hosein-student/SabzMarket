using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface IUserRepository
    {
        Task< OperationResult >Insert(UserDTO userDTO);
        Task< OperationResult >Update(UserDTO userDTO);
        Task< OperationResult<UserDTO> >Select(string username);
        Task<OperationResult> CheckUser(string username);
        Task<OperationResult> ChangePassword(UserDTO userDTO);
        
    }
}
