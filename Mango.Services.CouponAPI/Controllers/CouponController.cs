using Mango.Services.CouponAPI.Business.Contracts;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CouponController : ControllerBase
    {
        private readonly ICouponBusinnes _couponBusinees;

        public CouponController(ICouponBusinnes couponBusinnes)
        {
            _couponBusinees = couponBusinnes;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CouponDto>), 200)]
        public async Task<ActionResult> GetCoupons()
        {
            var result = await _couponBusinees.GetCoupons();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(CouponDto), 200)]
        public async Task<ActionResult> GetCouponById(int id)
        {
            var result = await _couponBusinees.GetCouponById(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        [ProducesResponseType(typeof(CouponDto), 200)]
        public async Task<ActionResult> GetCouponByCode(string code)
        {
            var result = await _couponBusinees.GetCouponByCode(code);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(CouponDto), 200)]
        public async Task<ActionResult> Save(CouponDto coupon)
        {
            var result = await _couponBusinees.Create(coupon);
            return Ok(result);
        }

        [HttpPut]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(CouponDto), 200)]
        public async Task<ActionResult> Updated(CouponDto coupon)
        {
            var result = await _couponBusinees.Update(coupon);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(CouponDto), 200)]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _couponBusinees.Delete(id);
            return Ok(result);
        }
    }
}
