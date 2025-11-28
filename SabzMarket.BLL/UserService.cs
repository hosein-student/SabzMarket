using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SabzMarket.BLL
{
    public class UserService : IUserService
    {
        private readonly IErrorService _errorService;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, IErrorService errorService) 
        {
            _userRepository = userRepository;
            _errorService = errorService;
        }

        public async Task<OperationResult<UserViewModel>> GetUserAsync(string username)
        {
            var result=await _userRepository.SelectAsync(username);
            if(!result.Success)
            {
                var error = result.Exception!.ExceptionToErrorDTO(result.Message!);
                var result1 = await _errorService.LogErrorAsync(error);
                    return OperationResult<UserViewModel>.Failed(result1.Message!.ErrorMessage());
            }
            var data = result.Data.ToUserViewModel();
            return OperationResult<UserViewModel>.Successed(data);
        }

        public async Task<OperationResult> IsUsernameAvailableAsync(string username)
        {
            var result = await _userRepository.CheckUserAsync(username);
            if (result.Success)
            {
                return OperationResult.Successed(true, Messages.existingUser);
            }
            else
            {
                if (result.Exception != null)
                {
                    var error = result.Exception.ExceptionToErrorDTO(result.Message!);
                    var result1 = await _errorService.LogErrorAsync(error);
                    return OperationResult.Failed(result1.Message!.ErrorMessage());
                }
                return OperationResult.Failed(result.Message!);
            }
        }

        public async Task<OperationResult> LoginAsync(UserViewModel userViewModel)
        {
            var result=await _userRepository.ChangePasswordAsync(userViewModel.ToUserDTO());
            if (!result.Success)
            {
                if(result.Exception != null)
                {
                    var error = result.Exception.ExceptionToErrorDTO(result.Message!);
                    var result1=await _errorService.LogErrorAsync(error);
                    return OperationResult.Failed(result1.Message!.ErrorMessage());
                }
                return OperationResult.Failed(Messages.userNotLogin);
            }
            return OperationResult.Successed();
            
        }

        public async Task<OperationResult> SignUpAsync(UserViewModel userViewModel)
        {
            if(userViewModel.IsValid)
            {
                var result = await _userRepository.CheckUserAsync(userViewModel.UserName);
                if (result.Success == false)
                {
                    if (result.Exception != null)
                    {
                        var error = result.Exception.ExceptionToErrorDTO(result.Message!);
                        var result1 = await _errorService.LogErrorAsync(error);
                        return OperationResult.Failed(result1.Message!.ErrorMessage());
                    }
                    else
                    {
                        var result2 = await _userRepository.InsertAsync(userViewModel.ToUserDTO());
                        if (result2.Success == false)
                        {
                            var error = result2.Exception!.ExceptionToErrorDTO(result2.Message!);
                            var result1 = await _errorService.LogErrorAsync(error);
                            return OperationResult.Failed(result1.Message!.ErrorMessage());
                        }
                        else
                        {
                            return OperationResult.Successed(true, Messages.successSignUp1);
                        }
                    }
                }
                else
                {
                    return OperationResult.Failed(Messages.existingUser);
                }
            }
            else
            {
                return OperationResult.Failed(userViewModel.ErrorMessage);
            }
            


        }
    }
}
