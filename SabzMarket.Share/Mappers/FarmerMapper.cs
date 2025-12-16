using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Mappers
{
    public static class FarmerMapper
    {
        public static Models.FarmerDTO ToFarmerDTO(this FarmerPartiaViewModel farmerViewModel)
        {
            return new Models.FarmerDTO()
            {
                Address = farmerViewModel.Address,
                CodePosti = farmerViewModel.CodePosti,
                CodParvaneBHB = farmerViewModel.CodParvaneBHB,
                DataBuilt = farmerViewModel.DataBuilt,
                Id = farmerViewModel.Id,
                LandArea = farmerViewModel.LandArea,
                NationalCode = farmerViewModel.NationalCode,
                ProfileImage = farmerViewModel.ProfileImage,
                UserId = farmerViewModel.UserId
            };
        }
        public static FarmerPartiaViewModel ToFarmerPartiaViweModel(this Models.FarmerDTO farmerDTO)
        {
            return new FarmerPartiaViewModel()
            {
                Address = farmerDTO.Address,
                CodePosti = farmerDTO.CodePosti,
                CodParvaneBHB = farmerDTO.CodParvaneBHB,
                DataBuilt = farmerDTO.DataBuilt,
                Id = farmerDTO.Id,
                LandArea = farmerDTO.LandArea,
                NationalCode = farmerDTO.NationalCode,
                ProfileImage = farmerDTO.ProfileImage,
                UserId = farmerDTO.UserId
            };
        }
        public static FarmerDTO ToFarmerDTO(this FarmerFullViweModel farmerFullViewModel)
        {
            return new Models.FarmerDTO()
            {
                Address = farmerFullViewModel.Address,
                CodePosti = farmerFullViewModel.CodePosti,
                CodParvaneBHB = farmerFullViewModel.CodParvaneBHB,
                DataBuilt = farmerFullViewModel.DataBuilt,
                Email = farmerFullViewModel.Email,
                FirstName = farmerFullViewModel.FirstName,
                Id = farmerFullViewModel.Id,
                LandArea = farmerFullViewModel.LandArea,
                LastName = farmerFullViewModel.LastName,
                NationalCode = farmerFullViewModel.NationalCode,
                Password = farmerFullViewModel.Password,
                Phone = farmerFullViewModel.Phone
                ,
                ProfileImage = farmerFullViewModel.ProfileImage,
                UserId = farmerFullViewModel.UserId
                ,
                UserName = farmerFullViewModel.UserName
            };
        }
        public static FarmerFullViweModel ToFarmerFullViweModel(this FarmerDTO farmerDTO)
        {
            return new FarmerFullViweModel()
            {
                Address = farmerDTO.Address!,
                CodePosti = farmerDTO.CodePosti,
                CodParvaneBHB = farmerDTO.CodParvaneBHB,
                DataBuilt = farmerDTO.DataBuilt!,
                Id = farmerDTO.Id,
                LandArea = farmerDTO.LandArea,
                NationalCode = farmerDTO.NationalCode,
                ProfileImage = farmerDTO.ProfileImage,
                UserId = farmerDTO.UserId,
                Email= farmerDTO.Email,
                UserName = farmerDTO.UserName,
                Phone = farmerDTO.Phone,
                FirstName = farmerDTO.FirstName,
                LastName = farmerDTO.LastName,
            };
        }

    }
}
