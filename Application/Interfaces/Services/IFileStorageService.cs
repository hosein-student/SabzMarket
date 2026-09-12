using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabzMarket.Application.Common.Enums;

namespace SabzMarket.Application.Interfaces.Services
{
    public interface IFileStorageService
    {
        public Task<string> SaveAsync(Stream fileStream, string fileName, FileFolder fileFolder, long entityId,
            CancellationToken token);

        Task DeleteAsync(
            string fileUrl,
            CancellationToken token);
    }
}