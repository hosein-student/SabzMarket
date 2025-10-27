using SabzMarket.Share;
using SabzMarket.Share.Data;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class UserService : IUserService
    {
        private readonly IErrorRepository _errorRepository;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository,IErrorRepository errorRepository) 
        {
            _userRepository = userRepository;
            _errorRepository = errorRepository;
        }
        public async Task<OperationResult> SignUp(UserDTO userDTO)
        {
            var result= await _userRepository.CheckUser(userDTO.UserName);
            if (result.Success == false)
            {
                if(result.Exception != null)
                {
                    var result1= await _errorRepository.LogErrorAsync(result.Exception, result.Message);
                    string error = $"{Messages.error}  کد ارور:  {result1.Message}";
                    return OperationResult.Failed(error);
                }
                else
                {
                  var result2= await _userRepository.Insert(userDTO);
                    if (result2.Success == false)
                    {
                        var result1 = await _errorRepository.LogErrorAsync(result2.Exception, result2.Message);
                        string error = $"{Messages.error}  کد ارور:  {result1.Message}";
                        return OperationResult.Failed(error);
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
    }
}
