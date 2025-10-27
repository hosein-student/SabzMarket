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
    public class ErrorRepository:IErrorRepository
    {
        private readonly SabzMarketDbContext _context;
        public ErrorRepository(SabzMarketDbContext context) 
        {
            _context = context;
        }

        public async Task<OperationResult> LogErrorAsync(Exception ex, string layer)
        {
            ErrorLog errorLog = new ErrorLog
            {
                CreatedAt = DateTime.Now,
                Message = ex.Message,
                Source = ex.Source,
                StackTrace = ex.StackTrace,
                Layer=layer
            };
            try
            {
                _context.ErrorLogs.Add(errorLog);
                await _context.SaveChangesAsync();
               
                return OperationResult.Successed(true, errorLog.Id.ToString());
            }
            catch (Exception ex2)
            {
                //file
                return OperationResult.Failed(errorLog.CreatedAt.ToString());
            }



        }
    }
}
