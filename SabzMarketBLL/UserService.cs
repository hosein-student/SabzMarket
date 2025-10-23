using SabzMarketShare;
using SabzMarketDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBLL
{
    public class UserService : IUserService
    {
        UserRepository repository;
        public UserService()
        {
            repository = new UserRepository();
        }

        public async Task<OperationResult> InsertUserAsync(UserDTO user)
        {
            if (user.FirstName.Length >= 3)
            {
                if (!string.IsNullOrEmpty(user.LastName))
                {
                    if (PhoneNumberValidator.IsValidPhoneNumber(user.Phone))
                    {

                        if (!(await repository.CheckUserAsync(user.UserName)).Success)
                        {
                            bool passwordsMatch = user.Password1 == user.Password2;
                            bool passwordNotEmpty = !string.IsNullOrEmpty(user.Password1);
                            if (passwordsMatch && passwordNotEmpty)
                            {
                                if ((await repository.InsertUserAsync(user)).Success)
                                {
                                    return OperationResult.Successed(MessageDTO.successSignUp1);
                                }
                                else
                                {
                                    return OperationResult.Failed(MessageDTO.failedSignUp1);
                                }

                            }
                            else
                            {
                                return OperationResult.Failed(MessageDTO.passwordMatch);
                            }
                        }
                        else
                        {
                            return OperationResult.Failed(MessageDTO.existingUser);
                        }
                    }
                    else
                    {
                        return OperationResult.Failed(MessageDTO.numberInvalid);
                    }
                }
                else
                {
                    return OperationResult.Failed(MessageDTO.lastNameInvalid1);
                }
            }
            else
            {
                return OperationResult.Failed(MessageDTO.firstNameInvalid2);
            }
        }
        public async Task<OperationResult> CheckUserToSellerAsync(string username)
        {
                var result2=await repository
                .CheckUserToSellerAsync(username);
                if (result2.Success)
                {
                    return OperationResult.Successed();
                }
                else
                {
                    return OperationResult.Failed();
                }
        }

        public async Task<OperationResult> CheckUserAsync(string username)
        {
            var result =await repository.CheckUserAsync(username);
            if (result.Success)
            {
                return OperationResult.Successed();
            }
            else
            {
                return OperationResult.Failed(MessageDTO.userNotFound);
            }
        }

        public async Task<OperationResult> CheckPasswordAsync(UserDTO user)
        {
           var result=await repository.CheckPasswordAsync(user.UserName, user.Password1);
            if (result.Success)
            {
                return OperationResult.Successed();
            }
            else
            {
                return OperationResult.Failed(MessageDTO.PasswordInvalid);
            }
        }

        public async Task<OperationResult> Login(UserDTO user)
        {
             var resilt = await CheckUserAsync(user.UserName);
            if (resilt.Success)
            {
                var result1 = await CheckUserToSellerAsync(user.UserName);
                if (result1.Success)
                {
                    var result2 = await CheckPasswordAsync(user);
                    if (result2.Success)
                    {
                        return OperationResult.Successed("Home");
                    }
                    else
                    {
                        return OperationResult.Failed(result2.Message);
                    }
                }
                else
                {
                    var result2 = await CheckPasswordAsync(user);
                    if (result2.Success)
                    {
                        return OperationResult.Successed("Seller");
                    }
                    else
                    {
                        return OperationResult.Failed(result2.Message);
                    }
                }
            }
            else
            {
                return OperationResult.Failed(resilt.Message);
            }
        }
    }
}
