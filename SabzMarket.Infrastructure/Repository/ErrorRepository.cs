using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using SabzMarket.Application.Interfaces.Logging;
using SabzMarket.DAL.Entities;
using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Infrastructure
{
    public class ErrorRepository:IErrorRepository
    {
        private readonly IDbContextFactory<SabzMarketDbContext> _contextFactory;
        private readonly ILogService _logServiceRepository;

        public ErrorRepository
            (IDbContextFactory<SabzMarketDbContext> contextFactory,
            ILogService logServiceRepository) 
        {
            _contextFactory = contextFactory;
            _logServiceRepository = logServiceRepository;
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
               
                return OperationResult.Failed(errorLog.Id.ToString());
            }
            catch (Exception ex2)
            {
               var result= await _logServiceRepository.SaveFailedLogAsync(ex2);
                return OperationResult.Failed(result.Message!);
            }



        }
    }
}
