using Mango.Services.ProductAPI.Entities.Dtos;

namespace Mango.Services.ProductAPI.Business.Contracts
{
    public interface IProductBusiness
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductsById(int id);
        Task<ProductDto> Create(ProductDto product);
        Task<ProductDto> Update(ProductDto product);
        Task<bool> Delete(int id);
    }
}
