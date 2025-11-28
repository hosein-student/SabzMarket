using Microsoft.EntityFrameworkCore;
using SabzMarket.DAL.Entities;
using SabzMarket.Share;
using SabzMarket.Share.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.DAL
{
    public class SellerRepository : ISellerRepository
    {
        private readonly SabzMarketDbContext _context;
        public SellerRepository(SabzMarketDbContext context)
        {
            _context = context;
        }

        public async Task<OperationResult> UserExistsInSellerAsync(string username)
        {
            try
            {
                var result = await _context
                    .Sellers
                    .AsNoTracking()
                    .AnyAsync(s => s.User.UserName == username);
                return OperationResult.Successed(result);
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name, ex);
            }

        }

        public async Task<OperationResult> InsertAsync(SellerDTO sellerDto)
        {
            try
            {
                var user = await _context
                    .Users
                    .FirstAsync(us => us.UserName == sellerDto.Username);
                Seller seller = new Seller
                {
                    Address = sellerDto.Address,
                    ProfileImage = sellerDto.ProfileImage,
                    UserId = user.Id,
                    WorkHistory = sellerDto.WorkHistory,
                    User = user
                };
                _context.Sellers.Add(seller);
                await _context.SaveChangesAsync();
                return OperationResult.Successed(true);
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name, ex);
            }


        }

        public async Task<OperationResult<SellerDTO>> GetByUsernameAsync(string username)
        {
            try
            {
                var seller = await _context
                    .Sellers
                    .AsNoTracking()
                    .Include(us=>us.User)
                    .Where(s => s.User.UserName == username)
                    .Select(s => new SellerDTO
                {
                    FirstName = s.User.FirstName,
                    LastName = s.User.LastName,
                    Phone = s.User.Phone,
                    Address = s.Address,
                    ProfileImage = s.ProfileImage,
                    Email = s.User.Email,
                    Password = s.User.Password,
                    Username = s.User.UserName,
                    WorkHistory = s.WorkHistory,
                    Id=s.Id
                }).SingleOrDefaultAsync();
                return OperationResult<SellerDTO>.Successed(seller);
            }
            catch(Exception ex)
            {
                return OperationResult<SellerDTO>.Failed(GetType().Name, ex);
            }
            
           
        }

        public async Task<OperationResult> UpdateAsync(string username, UserDTO userDto, SellerDTO sellerDto)
        {
            try
            {
                var seller = await _context
                    .Sellers
                    .Include(us => us.User)
                    .Where(us => us.User.UserName == username)
                    .SingleOrDefaultAsync();
                seller.User.UserName = userDto.UserName;
                seller.User.Password = userDto.Password;
                seller.User.FirstName = userDto.FirstName;
                seller.User.LastName = userDto.LastName;
                seller.User.Email = userDto.Email;
                seller.User.Phone = userDto.Phone;
                seller.Address = sellerDto.Address;
                seller.ProfileImage = sellerDto.ProfileImage;
                seller.WorkHistory = sellerDto.WorkHistory;
                _context.SaveChanges();
                return OperationResult<SellerDTO>.Successed();
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name, ex);  
            }


           

        }
    }
}
