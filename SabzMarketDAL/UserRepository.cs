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

        public async Task<OperationResult> CheckUserToSellerAsync(string username)
        {
            var result = await context.Sellers
                .Where(s => s.User.UserName == username)
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

        public async Task<OperationResult> CheckUserAsync(string username)
        {
            var result = await context.Users
                .Where(us => us.UserName == username)
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

        public async Task<OperationResult> CheckPasswordAsync(string username,string password)
        {
           var result= await context.Users
                .Where(u => u.UserName== username & u.Password == password)
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
