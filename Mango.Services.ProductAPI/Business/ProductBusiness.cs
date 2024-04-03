using Mango.Services.ProductAPI.Business.Contracts;
using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Entities;
using Mango.Services.ProductAPI.Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly DataContext _dataContext;

        public ProductBusiness(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await _dataContext.Products.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
                CategoryName = x.CategoryName,
                Description = x.Description,
                ImageLocalPath = x.ImageLocalPath,
                ImageUrl = x.ImageUrl,
                Price = x.Price
            }).ToListAsync();
        }

        public async Task<ProductDto> GetProductsById(int id)
        {
            var product = await _dataContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();

            if(product != null)
            {
                return new ProductDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    CategoryName = product.CategoryName,
                    Description = product.Description,
                    ImageLocalPath = product.ImageLocalPath,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price
                };
            }

            return null;
        }

        public async Task<ProductDto> Create(ProductDto product)
        {
            var newProduct = new Product()
            {
                Name = product.Name,
                CategoryName = product.CategoryName,
                Description = product.Description,
                ImageLocalPath = product.ImageLocalPath,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Created = DateTime.Now,
            };

            _dataContext.Products.Add(newProduct);
            await _dataContext.SaveChangesAsync();

            return await GetProductsById(newProduct.Id);
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _dataContext.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (product != null)
            {
                _dataContext.Remove(product);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ProductDto> Update(ProductDto item)
        {
            var product = await _dataContext.Products.Where(x => x.Id == item.Id).FirstOrDefaultAsync();
            if (product != null)
            {
                product.Updated = DateTime.UtcNow;
                _dataContext.Entry(product).CurrentValues.SetValues(item);

                await _dataContext.SaveChangesAsync();

                return await GetProductsById(item.Id);
            }
            return null;
        }
    }
}
