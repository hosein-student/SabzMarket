using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<OperationResult> SignUpAsync(UserViewModel userViewModel);
        Task<OperationResult> LoginAsync(UserViewModel userViewModel);
        Task<OperationResult> IsUsernameAvailableAsync(string username);
        Task<OperationResult<UserViewModel>> GetUserAsync(string username);


    }
}
