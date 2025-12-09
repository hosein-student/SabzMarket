using SabzMarket.Share.Models;
using SabzMarket.Share.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ISellerService
    {
        Task<OperationResult> FillProfileAsync(SellerPartialViewModel sellerViewModel2);
        Task<OperationResult> CheckUserExistsInSellerAsync(string username);
        Task<OperationResult<SellerFullViewModel>> GetSellerByUsernameAsync(string username);
        Task<OperationResult> UpdateAsync(string username, UserViewModel userViewModel, SellerPartialViewModel sellerPartialViewModel);
    }
}
