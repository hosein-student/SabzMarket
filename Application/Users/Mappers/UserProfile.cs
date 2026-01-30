using AutoMapper;
using SabzMarket.Application.Users.DTOs;
using SabzMarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Users.Mappers
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserDTO>();
            CreateMap<UserDTO,User>();
        }
    }
}
