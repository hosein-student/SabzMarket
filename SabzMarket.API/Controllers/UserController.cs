using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

namespace SabzMarket.API.Controllers
{
    public class UserController : BaseController, IUserService
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<OperationResult> SignUp([FromBody]UserDTO userDTO)
        {
            var result=await _userService.SignUp(userDTO);
            return result;
        }
    }
}
