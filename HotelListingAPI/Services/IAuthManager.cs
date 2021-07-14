﻿using HotelListingAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO loginUserDTO);
        Task<string> CreateToken();
    }
}
