﻿using Entities.Dtos.UserDtos;
using Entities.Models;

namespace WebApi.Services.AuthotizationService
{
    public interface IAuthorizationService
    {
        public Task<ServiceResponse<GetUserDto>> GetUserByAuthAsync(string username, string passwordHash);
        public Task<ServiceResponse<GetUserDto>> ClearTokenAsync(int id);
        public Task<ServiceResponse<GetUserDto>> RefreshTokenAsync(TokenUserDto user);
    }
}
