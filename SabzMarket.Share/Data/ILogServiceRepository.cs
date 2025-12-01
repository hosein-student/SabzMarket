using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Data
{
    public interface ILogServiceRepository 
    {
        public Task<OperationResult> SaveFailedLogAsync(Exception? ex );
    }
}
