using System;
using System.Collections.Generic;
using System.Text;

namespace SabzMarket.Share.Mappers
{
    public static class SellerMapper
    {
        public static SellerDTO ToSellerDTO(this SellerFullViewModel sellerViewModel)
        {
            return new SellerDTO
            {
                Id=sellerViewModel.Id,
                FirstName = sellerViewModel.FirstName,
                LastName = sellerViewModel.LastName,
                Email = sellerViewModel.Email,
                Phone = sellerViewModel.Phone,
                Username = sellerViewModel.Username,
                Password = sellerViewModel.Password,
                Address = sellerViewModel.Address,
                ProfileImage = sellerViewModel.ProfileImage,
                WorkHistory= sellerViewModel.WorkHistory,

            };
        }
        public static SellerFullViewModel ToSellerFullViewModel(this SellerDTO sellerDTO)
        {
            return new SellerFullViewModel
            {
                Id= sellerDTO.Id,
                FirstName = sellerDTO.FirstName,
                LastName = sellerDTO.LastName,
                Email = sellerDTO.Email,
                Phone = sellerDTO.Phone,
                Username = sellerDTO.Username,
                Password = sellerDTO.Password,
                Address = sellerDTO.Address,
                ProfileImage = sellerDTO.ProfileImage,
                WorkHistory=sellerDTO.WorkHistory
            };
        }
        public static SellerFullViewModel SellerPartialViewModelToSellerFullViewModel(this SellerPartialViewModel sellerViewModel2)
        {
            return new SellerFullViewModel
            {
                
               Address = sellerViewModel2.Address,
                ProfileImage = sellerViewModel2.ProfileImage,
                 WorkHistory = sellerViewModel2.WorkHistory,
                 Username=sellerViewModel2.Username
            };
        }
    }
}
