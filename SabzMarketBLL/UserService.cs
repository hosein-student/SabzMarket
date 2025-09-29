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

                        if (!(await repository.CheckUserAsync(user)).Success)
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
                    return OperationResult.Failed(MessageDTO.lastNameInvalid);
                }
            }
            else
            {
                return OperationResult.Failed(MessageDTO.firstNameInvalid);
            }
        }
        public async Task<OperationResult> CheckUserToSellerAsync(UserDTO user)
        {
                var result2=await repository
                .CheckUserToSellerAsync(user);
                if (result2.Success)
                {
                    return OperationResult.Successed();
                }
                else
                {
                    return OperationResult.Failed();
                }
        }

        public async Task<OperationResult> FoundUserAsync(UserDTO user)
        {
            var result =await repository.CheckUserAsync(user);
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
           var result=await repository.CheckPassword(user);
            if (result.Success)
            {
                return OperationResult.Successed();
            }
            else
            {
                return OperationResult.Failed(MessageDTO.PasswordInvalid);
            }
        }
    }
}
