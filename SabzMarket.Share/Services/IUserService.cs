﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share.Services
{
    public interface IUserService
    {
        Task<OperationResult> SignUp(UserDTO userDTO);


    }
}
