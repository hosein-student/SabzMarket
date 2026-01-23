using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repository
{
    public interface IErrorRepository
    {
        Task<OperationResult> LogErrorAsync(ErrorLogDTO error);
    }
}
