﻿namespace Mango.Services.AuthAPI.Entities.Dtos
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
