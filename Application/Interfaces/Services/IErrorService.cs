using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IErrorService
    {
        Task<OperationResult> LogErrorAsync(ErrorLogDTO error);
    }
}
