﻿using Mango.Services.EmailAPI.Entities.Dtos;

namespace Mango.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
    }
}
