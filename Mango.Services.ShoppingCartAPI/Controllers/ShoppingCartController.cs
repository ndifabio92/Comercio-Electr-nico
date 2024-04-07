using Mango.Services.ShoppingCartAPI.Business.Contracts;
using Mango.Services.ShoppingCartAPI.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartBusiness _shoppingCartBusiness;

        public ShoppingCartController(IShoppingCartBusiness shoppingCartBusiness)
        {
            _shoppingCartBusiness = shoppingCartBusiness;
        }

        [HttpGet("GetCart/{userId}")]
        [ProducesResponseType(typeof(CartDto), 200)]
        public async Task<ActionResult> GetCart(string userId)
        {
            var result = await _shoppingCartBusiness.GetCart(userId);
            return Ok(result);
        }

        [HttpPost("CartUpsert")]
        [ProducesResponseType(typeof(CartDto), 200)]
        public async Task<ActionResult> CartUpsert(CartDto cart)
        {
            var result = await _shoppingCartBusiness.CartUpsert(cart);
            return Ok(result);
        }

        [HttpDelete("RemoveCart/{id:int}")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<ActionResult> RemoveCart(int id)
        {
            var result = await _shoppingCartBusiness.RemoveCart(id);
            return Ok(result);
        }

        [HttpPost("ApplyCoupon")]
        public async Task<ActionResult> ApplyCoupon(CartDto cart)
        {
            var result = await _shoppingCartBusiness.ApplyCoupon(cart);
            return Ok(result);
        }

        [HttpPost("RemoveCoupon")]
        public async Task<ActionResult> RemoveCoupon(CartDto cart)
        {
            var result = await _shoppingCartBusiness.RemoveCoupon(cart);
            return Ok(result);
        }
    }
}
