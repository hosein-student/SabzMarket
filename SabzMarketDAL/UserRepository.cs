using SabzMarketDAL.Entities;
using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketDAL
{
    public class UserRepository : IUserRepository
    {
        SabzMarketDbContext context;
        public UserRepository()
        {
            context = new SabzMarketDbContext();
        }

        public async Task<OperationResult> CheckUserToSellerAsync(UserDTO user)
        {
            var result = await context.Sellers
                .Where(s => s.User.UserName == user.UserName)
                .AnyAsync();
            if (result)
            {
                return OperationResult.Successed();
            }
            else
            {
                return OperationResult.Failed();
            }

        }

        public async Task<OperationResult> CheckUserAsync(UserDTO user)
        {
            var result = await context.Users
                .Where(us => us.UserName == user.UserName)
                .AnyAsync();
            if (result)
                return OperationResult.Successed();
            else
                return OperationResult.Failed();
        }
        public async Task<OperationResult> InsertUserAsync(UserDTO user)
        {
            try
            {
                User usert = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone = user.Phone,
                    Email = user.Email,
                    UserName = user.UserName,
                    Password = user.Password1,
                };
                context.Users.Add(usert);
                await context.SaveChangesAsync();
                return OperationResult.Successed();
            }
            catch (Exception ex)
            {
                return OperationResult.Failed();
            }
        }

        public async Task<OperationResult> CheckPassword(UserDTO user)
        {
           var result= await context.Users
                .Where(u => u.Password == user.Password1)
                .AnyAsync();
            if (result)
            {
                return OperationResult.Successed();
            }
            else
            {
                return OperationResult.Failed();
            }
        }
    }
}
