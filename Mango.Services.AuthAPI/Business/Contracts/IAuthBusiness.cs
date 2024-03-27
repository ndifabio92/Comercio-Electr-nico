using Mango.Services.AuthAPI.Entities.Dtos;

namespace Mango.Services.AuthAPI.Business.Contracts
{
    public interface IAuthBusiness
    {
        Task<UserDto> Register(RegistrationDto registrationDto);
        Task<LoginResponseDto> Login(LoginDto loginDto);
        Task<bool> AssingRole(string email, string roleName);
    }
}
