using SabzMarketDAL;
using SabzMarketDAL.Entities;
using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBLL
{
    public class SellerService : ISellerRepositoty
    {
        UserRepository userRepository;
        SellerRepository sellerRepository;
        public SellerService()
        {
            userRepository=new UserRepository();
            sellerRepository = new SellerRepository();
        }
        public async Task<OperationResult> InsertSelllerAsync(SellerDTO seller)
        {
            if (!string.IsNullOrWhiteSpace(seller.Address))
            {
                if (!string.IsNullOrWhiteSpace(seller.WorkHistory))
                {
                    if (!string.IsNullOrWhiteSpace(seller.ProfileImage))
                    {
                        SavePhoto savePhoto = new SavePhoto();
                        var result1 = await savePhoto.Save(seller.ProfileImage);
                        if (result1.Success)
                        {
                            SellerDTO sellerDTO = new SellerDTO
                            {
                                Address = seller.Address,
                                ProfileImage = result1.Message,
                                WorkHistory = seller.WorkHistory
                            };
                            var result2 = await sellerRepository.InsertSelllerAsync(sellerDTO);
                            if (result2.Success)
                            {
                                return OperationResult.Successed(MessageDTO.successSignUp2);
                            }
                            else
                            {
                                return OperationResult.Failed(MessageDTO.failedSignUp2);
                            }
                        }
                        else
                        {
                            return OperationResult.Failed(MessageDTO.notSavePhoto);
                        }
                    }
                    else
                    {
                        return OperationResult.Failed(MessageDTO.photoNotSelected);
                    }
                }
                else
                {
                    return OperationResult.Failed(MessageDTO.enterTheWorkHistory);
                }
            }
            else
            {
                return OperationResult.Failed(MessageDTO.enterTheAddress);
            }





        }

        public async Task<OperationResult<SellerDTO>> SelectSellerAsync(string userName)
        {
            var seller = await sellerRepository.SelectSellerAsync(userName);
            if (seller.Success)
            {
                return OperationResult<SellerDTO>.Successed(seller.Data);
            }
            else
            {
                return OperationResult<SellerDTO>.Failedd(MessageDTO.error);
            }
        }

        public async Task<OperationResult> UpdateSellerAsync(SellerDTO sellerDTO)
        {
            if(sellerDTO.FirstName.Length >= 3)
            {
                if (!string.IsNullOrEmpty(sellerDTO.LastName))
                {
                    if (PhoneNumberValidator.IsValidPhoneNumber(sellerDTO.Phone))
                    {
                        var result =await userRepository.CheckUserAsync(sellerDTO.Username);
                        if (result.Success)
                        {
                            if (!string.IsNullOrEmpty(sellerDTO.Password))
                            {
                                if (!string.IsNullOrEmpty(sellerDTO.Address))
                                {
                                    if (!string.IsNullOrEmpty(sellerDTO.WorkHistory))
                                    {
                                        if (!sellerDTO.ProfileImage.Contains("https://"))
                                        {
                                            SavePhoto savePhoto = new SavePhoto();
                                            var result1 = await savePhoto.Save(sellerDTO.ProfileImage);
                                            if (result1.Success)
                                            {
                                                SellerDTO seller = new SellerDTO
                                                {
                                                    Address = sellerDTO.Address,
                                                    ProfileImage = result1.Message,
                                                    WorkHistory = sellerDTO.WorkHistory
                                                    ,
                                                    Email = sellerDTO.Email,
                                                    FirstName = sellerDTO.FirstName,
                                                    LastName = sellerDTO.LastName,
                                                    Password = sellerDTO.Password,
                                                    Phone = sellerDTO.Phone,
                                                    Username = sellerDTO.Username
                                                };
                                                var result2 = await sellerRepository.UpdateSellerAsync(seller);
                                                if (result2.Success)
                                                {
                                                    return OperationResult.Successed(MessageDTO.update);
                                                }
                                                else
                                                {
                                                    return OperationResult.Failed(MessageDTO.error);
                                                }
                                            }
                                            else
                                            {
                                                return OperationResult.Failed(MessageDTO.notSavePhoto);
                                            }
                                        }
                                        else
                                        {
                                            SellerDTO seller = new SellerDTO
                                            {
                                                Address = sellerDTO.Address,
                                                ProfileImage = sellerDTO.ProfileImage,
                                                WorkHistory = sellerDTO.WorkHistory
                                                    ,
                                                Email = sellerDTO.Email,
                                                FirstName = sellerDTO.FirstName,
                                                LastName = sellerDTO.LastName,
                                                Password = sellerDTO.Password,
                                                Phone = sellerDTO.Phone,
                                                Username = sellerDTO.Username
                                            };
                                            var result = await sellerRepository.UpdateSellerAsync(sellerDTO);
                                            if (result.Success)
                                            {
                                                return OperationResult.Successed(MessageDTO.update);
                                            }
                                            else
                                            {
                                                return OperationResult.Failed(MessageDTO.error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        return OperationResult.Failed(MessageDTO.enterTheWorkHistory);
                                    }
                                }
                                else
                                {
                                    return OperationResult.Failed(MessageDTO.enterTheAddress);
                                }
                            }
                            else
                            {
                                return OperationResult.Failed("رمز عبور را وارد کنید");
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
    }
}

