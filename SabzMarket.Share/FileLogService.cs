using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public class FileLogService
    {
        private static readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);
        private static readonly string _filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "failed_logs.txt");

        public static async Task SaveFailedLogAsync( Exception? ex = null)
        {
            try
            {
                var dir = Path.GetDirectoryName(_filePath)!;
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var json = JsonConvert.SerializeObject(ex) + Environment.NewLine;

                await _lock.WaitAsync();
                try
                {
                    await File.AppendAllTextAsync(_filePath, json, Encoding.UTF8);
                }
                finally
                {
                    _lock.Release();
                }
            }
            catch (Exception exception)
            {
            }
        }

    }
}
