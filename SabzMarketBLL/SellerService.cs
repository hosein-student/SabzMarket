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
    public class SellerService : ISellerService
    {
        SellerRepository sellerRepository;
        public SellerService()
        {
            sellerRepository = new SellerRepository();
        }
        public async Task<OperationResult> InsertSelllerAsync(string userName, SellerDTO seller)
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
                var result2 = await sellerRepository.InsertSelllerAsync(userName, sellerDTO);
                if (result2.Success)
                {
                    return OperationResult.Successed(MessageDTO.successSignUp2);
                }
                else
                {
                    return OperationResult.Failed(result2.Message);
                }
            }
            else
            {
                return OperationResult.Failed(MessageDTO.notSavePhoto);
            }



        }

        public async Task<OperationResult<SellerDTO>> SelectSellerAsync(string userName)
        {
          var seller=await sellerRepository.SelectSellerAsync(userName);
            if (seller.Success)
            {
                return OperationResult<SellerDTO>.Successed(seller.Data);
            }
            else
            {
                return OperationResult<SellerDTO>.Failedd(MessageDTO.error);
            }    
        }

        public async Task<OperationResult> UpdateSellerAsync(string userName, SellerDTO sellerDTO)
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
                    var result = await sellerRepository.UpdateSellerAsync(userName, seller);
                    if (result.Success)
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
                var result = await sellerRepository.UpdateSellerAsync(userName, seller);
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
    }
}

