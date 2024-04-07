using Mango.Services.ShoppingCartAPI.Entities.Dtos;

namespace Mango.Services.ShoppingCartAPI.Business.Contracts
{
    public interface IShoppingCartBusiness
    {
        public Task<CartDto> GetCart(string userId);
        public Task<CartDto> CartUpsert(CartDto cart);
        public Task<bool> RemoveCart(int cartDetailsId);
        public Task<bool> ApplyCoupon(CartDto cart);
        public Task<bool> RemoveCoupon(CartDto cart);
    }
}
