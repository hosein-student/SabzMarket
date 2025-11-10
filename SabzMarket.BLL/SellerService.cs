using SabzMarket.Share;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Data;
using SabzMarket.Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class SellerService : ISellerService
    {
        private readonly IErrorRepository _errorRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IUserService _userService;
        public SellerService(ISellerRepository sellerRepository, IErrorRepository errorRepository, IUserService userService)
        {
            _sellerRepository = sellerRepository;
            _errorRepository = errorRepository;
            _userService = userService;
        }

        public async Task<OperationResult> CheckUserExistsInSellerAsync(string username)
        {
            var result = await _sellerRepository.UserExistsInSellerAsync(username);
            if (result.Success)
            {
                return OperationResult.Successed();
            }
            else
            {
                if (result.Exception != null)
                {
                    var result1 = await _errorRepository.LogErrorAsync(result.Exception, result.Message);
                    return OperationResult.Failed(result1.Message.ErrorMessage());
                }
                else
                {
                    return OperationResult.Failed();
                }
            }
        }

        public async Task<OperationResult> FillProfileAsync(SellerPartialViewModel sellerViewMode2)
        {

            if (sellerViewMode2.IsValid)
            {

                using var savePhoto = new SavePhoto();
                var result2 = await savePhoto.SaveAsync(sellerViewMode2.ProfileImage);
                if (result2.Success)
                {
                    sellerViewMode2.ProfileImage = result2.Message;
                    var sellerViewModel1 = sellerViewMode2.SellerPartialViewModelToSellerFullViewModel();
                    var result = await _sellerRepository.InsertAsync(sellerViewModel1.ToSellerDTO());
                    if (result.Success == false)
                    {
                        if (result.Exception != null)
                        {
                            var result1 = await _errorRepository.LogErrorAsync(result.Exception, result.Message);
                            return OperationResult.Failed(result1.Message.ErrorMessage());
                        }
                        else
                        {
                            return OperationResult.Failed();
                        }
                    }
                    else
                    {
                        return OperationResult.Successed(true, Messages.successSignUp2);
                    }
                }
                else
                {
                    var result1 = await _errorRepository.LogErrorAsync(result2.Exception, result2.Message);
                    return OperationResult.Failed(result1.Message.ErrorMessage());
                }
            }
            else
            {
                return OperationResult.Failed(sellerViewMode2.ErrorMessage);
            }

        }

        public async Task<OperationResult<SellerFullViewModel>> GetSellerByUsernameAsync(string username)
        {
            var result = await _sellerRepository.GetByUsernameAsync(username);
            if (result.Success)
            {
                return OperationResult<SellerFullViewModel>.Successed(result.Data.ToSellerFullViewModel());
            }
            else
            {
               var result1=await _errorRepository.LogErrorAsync(result.Exception,result.Message);
               return OperationResult<SellerFullViewModel>.Failed(result1.Message.ErrorMessage());
            }
            
        }

        

        public async Task<OperationResult> UpdateAsync(string username, UserViewModel userViewModel, SellerPartialViewModel sellerPartialViewModel)
        {
            if(userViewModel.IsValid)
            {
                if(sellerPartialViewModel.IsValid)
                {
                    if(!sellerPartialViewModel.ProfileImage.Contains("https://"))
                    {
                        using var savePhoto = new SavePhoto();
                        var result3=await savePhoto.SaveAsync(sellerPartialViewModel.ProfileImage);
                        if(result3.Success)
                        {
                            var result1 = await _userService
                           .IsUsernameAvailableAsync(userViewModel.UserName);
                            if (result1.Success)
                            {
                                return OperationResult.Failed(Messages.existingUser);
                            }
                            else
                            {
                                if (result1.Exception != null)
                                {
                                    var result = await _errorRepository.LogErrorAsync(result1.Exception, result1.Message);
                                    return OperationResult.Failed(result.Message.ErrorMessage());
                                }
                                else
                                {
                                    var result = await _sellerRepository
                                    .UpdateAsync(username, userViewModel.ToUserDTO(), sellerPartialViewModel.SellerPartialViewModelToSellerFullViewModel().ToSellerDTO());
                                    if (result.Success)
                                    {
                                        return OperationResult.Successed(true, Messages.update);
                                    }
                                    else
                                    {
                                        var result2 = await _errorRepository.LogErrorAsync(result.Exception, result1.Message);
                                        return OperationResult.Failed(result2.Message.ErrorMessage());
                                    }
                                }
                            }
                        }
                        else
                        {
                            var result4 = await _errorRepository.LogErrorAsync(result3.Exception, result3.Message);
                            return OperationResult.Failed(result4.Message.ErrorMessage());
                        }


                            
                    }
                    else
                    {
                        var result1 = await _userService
                      .IsUsernameAvailableAsync(userViewModel.UserName);
                        if (result1.Success)
                        {
                            return OperationResult.Failed(Messages.existingUser);
                        }
                        else
                        {
                            if (result1.Exception != null)
                            {
                                var result = await _errorRepository.LogErrorAsync(result1.Exception, result1.Message);
                                return OperationResult.Failed(result.Message.ErrorMessage());
                            }
                            else
                            {
                                var result = await _sellerRepository
                                .UpdateAsync(username, userViewModel.ToUserDTO(), sellerPartialViewModel.SellerPartialViewModelToSellerFullViewModel().ToSellerDTO());
                                if (result.Success)
                                {
                                    return OperationResult.Successed(true, Messages.update);
                                }
                                else
                                {
                                    var result2 = await _errorRepository.LogErrorAsync(result.Exception, result1.Message);
                                    return OperationResult.Failed(result2.Message.ErrorMessage());
                                }
                            }
                        }
                    }
                  
                }
                else
                {
                    return OperationResult.Failed(sellerPartialViewModel.ErrorMessage);
                }
            }
            else
            {
                return OperationResult.Failed(userViewModel.ErrorMessage);
            }
        }
    }
}
