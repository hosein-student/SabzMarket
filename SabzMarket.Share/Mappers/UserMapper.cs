using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToUserDTO(this UserViewModel userViewModel)
        {
            return new UserDTO
            {
                Id=userViewModel.Id,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Phone = userViewModel.Phone,
                Email = userViewModel.Email,
                UserName = userViewModel.UserName,
                Password = userViewModel.Password1
            };
        }
        public static UserViewModel ToUserViewModel(this UserDTO userDTO)
        {
            return new UserViewModel
            {
                Id=userDTO.Id,
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Phone = userDTO.Phone,
                Email = userDTO.Email,
                UserName = userDTO.UserName,
                Password1 = userDTO.Password,
                Password2 = userDTO.Password
            };
        }
    }
}
