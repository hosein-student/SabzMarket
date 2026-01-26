using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Application.Interfaces.Repositories.Services
{
    public interface IFileStorageService
    {
        public Task<string> SaveAsync(string filePath);
    }
}
