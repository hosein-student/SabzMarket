﻿using Microsoft.EntityFrameworkCore;
using SabzMarket.DAL.Entities;
using SabzMarket.Share;
using SabzMarket.Share.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly SabzMarketDbContext _context;
        public UserRepository(SabzMarketDbContext context) 
        {
             _context = context;
        }
        public Task<OperationResult> ChangePassword(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> CheckUser(string username)
        {
            try
            {
                var result = await _context.Users.AnyAsync(u => u.UserName == username);
                return OperationResult.Successed(result);
            }
            catch(Exception ex) 
            {
                return OperationResult.Failed(GetType().Name,ex);
            }
        }
         

        public async Task<OperationResult> Insert(UserDTO userDTO)
        {
            User user = new User
            {
                FirstName=userDTO.FirstName,
                LastName=userDTO.LastName,
                Phone=userDTO.Phone,
                Email=userDTO.Email,
                UserName=userDTO.UserName,
                Password=userDTO.Password
            };
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return OperationResult.Successed();
            }
            catch(Exception ex) 
            {
                return OperationResult.Failed(GetType().Name, ex);
            }
        }

        public Task<OperationResult<UserDTO>> Select(string username)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Update(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
