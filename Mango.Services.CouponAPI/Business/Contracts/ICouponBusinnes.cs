using Mango.Services.CouponAPI.Models.Dtos;

namespace Mango.Services.CouponAPI.Business.Contracts
{
    public interface ICouponBusinnes
    {
        Task<IEnumerable<CouponDto>> GetCoupons();
        Task<CouponDto> GetCouponById(int id);
        Task<CouponDto> GetCouponByCode(string code);
        Task<CouponDto> Create(CouponDto coupon);
        Task<CouponDto> Update(CouponDto coupon);
        Task<bool> Delete(int id);
    }
}
