﻿namespace Entities.Dtos.UserDtos
{
    public class AuthUserDto
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}