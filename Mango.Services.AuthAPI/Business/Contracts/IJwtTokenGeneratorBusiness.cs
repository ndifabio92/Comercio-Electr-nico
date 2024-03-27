using Mango.Services.AuthAPI.Entities;

namespace Mango.Services.AuthAPI.Business.Contracts
{
    public interface IJwtTokenGeneratorBusiness
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
