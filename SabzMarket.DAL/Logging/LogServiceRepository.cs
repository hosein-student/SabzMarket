using Application.Interfaces.Repositories;
using Newtonsoft.Json;
using SabzMarket.Share.Mappers;
using SabzMarket.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SabzMarket.DAL.Logging
{
    public class LogServiceRepository : ILogServiceRepository
    {
        private static readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
        private static readonly string _filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logss", "failed_logs.txt");
        public async Task<OperationResult> SaveFailedLogAsync(Exception? ex)
        {
            
            try
            {
                var dir = Path.GetDirectoryName(_filePath)!;
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                var error = ex.ExceptionToErrorDTO(GetType().Name);
                var json = JsonConvert.SerializeObject(error) + Environment.NewLine;

                await _lock.WaitAsync();
                try
                {
                    await File.AppendAllTextAsync(_filePath, json, Encoding.UTF8);
                }
                finally
                {
                    _lock.Release();
                }
                return OperationResult.Failed(error.CreatedAt.ToString());

            }
            catch (Exception exception)
            {
                return OperationResult.Failed(exception.ToString());
            }
        }
    }
}
