using Mango.Services.CouponAPI.Business.Contracts;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Business
{
    public class CouponBusiness: ICouponBusinnes
    {
        private readonly DataContext _dataContext;

        public CouponBusiness(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<CouponDto>> GetCoupons()
        {
            var coupons = await _dataContext.Coupones.ToListAsync();
            return coupons.Select(x => new CouponDto()
            {
                Id = x.Id,
                CouponCode = x.CouponCode,
                DiscountAmount = x.DiscountAmount,
                MinAmount = x.MinAmount
            });
        }

        public async Task<CouponDto> GetCouponById(int id)
        {
            var coupon = await _dataContext.Coupones.Where(x => x.Id == id).FirstOrDefaultAsync();
            if(coupon != null)
            {
                return new CouponDto()
                {
                    Id = coupon.Id,
                    CouponCode = coupon.CouponCode,
                    DiscountAmount = coupon.DiscountAmount,
                    MinAmount = coupon.MinAmount
                };
            }
            return null;
        }

        public async Task<CouponDto> GetCouponByCode(string code)
        {
            var coupon = await _dataContext.Coupones.Where(x => x.CouponCode.ToLower() == code.ToLower()).FirstOrDefaultAsync();
            if (coupon != null)
            {
                return new CouponDto()
                {
                    Id = coupon.Id,
                    CouponCode = coupon.CouponCode,
                    DiscountAmount = coupon.DiscountAmount,
                    MinAmount = coupon.MinAmount
                };
            }
            return null;
        }

        public async Task<CouponDto> Create(CouponDto coupon)
        {
            var newCoupon = new Coupon()
            {
                CouponCode = coupon.CouponCode,
                DiscountAmount = coupon.DiscountAmount,
                MinAmount = coupon.MinAmount,
                Created = DateTime.Now,
            };

            _dataContext.Coupones.Add(newCoupon);
            await _dataContext.SaveChangesAsync();

            return await GetCouponById(newCoupon.Id);
        }

        public async Task<CouponDto> Update(CouponDto item)
        {
            var coupon = await _dataContext.Coupones.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            if (coupon != null)
            {
                coupon.Updated = DateTime.UtcNow;
                _dataContext.Entry(coupon).CurrentValues.SetValues(item);

                await _dataContext.SaveChangesAsync();

                return await GetCouponById(item.Id);
            }
            return null;
        }

        public async Task<bool> Delete(int id)
        {
            var coupon = await _dataContext.Coupones.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (coupon != null)
            {
                _dataContext.Remove(coupon);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
