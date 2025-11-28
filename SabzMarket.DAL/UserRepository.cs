using Microsoft.EntityFrameworkCore;
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
        public async Task<OperationResult> ChangePasswordAsync(UserDTO userDTO)
        {
            try
            {
                var result = await _context
                    .Users
                    .AsNoTracking()
                    .AnyAsync(u => u.UserName == userDTO.UserName && u.Password == userDTO.Password);
                return OperationResult
                    .Successed(result);
            }
            catch (Exception ex)
            {
                return OperationResult
                    .Failed(GetType().Name, ex);
            }

        }

        public async Task<OperationResult> CheckUserAsync(string username)
        {
            try
            {
                    var result = await _context
                        .Users
                        .AsNoTracking()
                        .AnyAsync(u => u.UserName == username);
                    return OperationResult
                        .Successed(result);
            }
            catch (Exception ex)
            {
                return OperationResult
                    .Failed(GetType().Name, ex);
            }
        }


        public async Task<OperationResult> InsertAsync(UserDTO userDTO)
        {
            User user = new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Phone = userDTO.Phone,
                Email = userDTO.Email,
                UserName = userDTO.UserName,
                Password = userDTO.Password
            };
            try
            {
                _context.Users
                    .Add(user);
                await _context
                    .SaveChangesAsync();
                return OperationResult
                    .Successed();
            }
            catch (Exception ex)
            {
                return OperationResult
                    .Failed(GetType().Name, ex);
            }
        }

        public async Task<OperationResult<UserDTO>> SelectAsync(string username)
        {
            try
            {
              var result=await  _context.Users
               .AsNoTracking()
               .Where(u => u.UserName == username)
               .Select(u => new UserDTO
               {
                   UserName = u.UserName,
                   Email = u.Email,
                   FirstName = u.FirstName,
                   LastName = u.LastName,
                   Phone = u.Phone,
                   Id = u.Id,
                   Password = u.Password

               })
               .SingleOrDefaultAsync();
                return OperationResult<UserDTO>.Successed(result);
            }
            catch(Exception ex) 
            {
                return OperationResult<UserDTO>.Failed(GetType().Name, ex);
            }
           
        }

        public Task<OperationResult> UpdateAsync(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
