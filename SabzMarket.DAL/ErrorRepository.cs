using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        private readonly IDbContextFactory<SabzMarketDbContext> _contextFactory;

        public ErrorRepository(IDbContextFactory<SabzMarketDbContext> contextFactory) 
        {
            _contextFactory = contextFactory;
        }

        public async Task<OperationResult> LogErrorAsync(ErrorLogDTO error)
        {
            ErrorLog errorLog = new ErrorLog
            {
                CreatedAt = error.CreatedAt,
                Message = error.Message,
                Source = error.Source,
                StackTrace = error.StackTrace,
                Layer= error.Layer,
                Curl= error.Curl,
                Route= error.Route
            };
            try
            {
                await using var context = await _contextFactory.CreateDbContextAsync();

                context.ErrorLogs.Add(errorLog);
                await context.SaveChangesAsync();
               
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
