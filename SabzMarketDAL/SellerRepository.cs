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
    public class SellerRepository : ISellerRepositoty
    {
        SabzMarketDbContext SabzMarketDbContext;
        public SellerRepository()
        {
            SabzMarketDbContext = new SabzMarketDbContext();
        }


        public async Task<OperationResult> InsertSelllerAsync(string userName, SellerDTO sellerDTO)
        {
            try
            {
                var user = await SabzMarketDbContext.Users
                    .FirstAsync(us => us.UserName == userName);
                Seller seller = new Seller
                {
                    UserId = user.Id,
                    User = user,
                    Address = sellerDTO.Address,
                    ProfileImage = sellerDTO.ProfileImage,
                    WorkHistory = sellerDTO.WorkHistory
                };
                SabzMarketDbContext.Sellers.Add(seller);
                await SabzMarketDbContext.SaveChangesAsync();
                return OperationResult.Successed();
            }
            catch (Exception ex)
            {
                //ex
                return OperationResult.Failed();
            }
        }

        public async Task<OperationResult<SellerDTO>> SelectSellerAsync(string userName)
        {
            try
            {
                var seller = await SabzMarketDbContext
                    .Sellers.Include("User")
                    .AsNoTracking()
                    .Where(s => s.User.UserName == userName)
                    .Select(se => new SellerDTO
                    {
                        FirstName = se.User.FirstName,
                        LastName = se.User.LastName,
                        Email = se.User.Email,
                        Phone = se.User.Phone,
                        Username = se.User.UserName,
                        Password = se.User.Password,
                        ProfileImage = se.ProfileImage,
                        Address = se.Address,
                        WorkHistory = se.WorkHistory
                    }).SingleAsync();
                return OperationResult<SellerDTO>.Successed(seller);
            }
            catch (Exception ex)
            {
                //ex
                return OperationResult<SellerDTO>.Failedd();
            }
        }

        public async Task<OperationResult> UpdateSellerAsync(string userName, SellerDTO sellerDTO)
        {
            try
            {
                var result = await SabzMarketDbContext.Sellers.Where(s => s.User.UserName == userName).SingleAsync();
                result.Address = sellerDTO.Address;
                result.WorkHistory = sellerDTO.WorkHistory;
                result.User.UserName = sellerDTO.Username;
                result.User.FirstName = sellerDTO.FirstName;
                result.User.LastName = sellerDTO.LastName;
                result.User.Email = sellerDTO.Email;
                result.User.Password = sellerDTO.Password;
                result.User.Phone = sellerDTO.Phone;
                result.ProfileImage = sellerDTO.ProfileImage;
                await SabzMarketDbContext.SaveChangesAsync();
                return OperationResult.Successed(userName);
            }
            catch (Exception ex)
            {
                {
                    //ex
                    return OperationResult.Failed();
                }
            }
        }
    }
}




