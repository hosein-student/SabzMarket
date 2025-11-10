using Microsoft.AspNetCore.Mvc;
using SabzMarket.Share;
using SabzMarket.Share.Services;

namespace SabzMarket.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<OperationResult> SignUpAsync([FromBody]UserViewModel userViewModel)
        {
            var result=await _userService
                .SignUpAsync(userViewModel);
            return result;
        }
        [HttpPost]
        public async Task<OperationResult> LoginAsync([FromBody]UserViewModel userViewModel)
        {
           var result=await _userService
                .LoginAsync(userViewModel);
            return result;
        }
    }
}
