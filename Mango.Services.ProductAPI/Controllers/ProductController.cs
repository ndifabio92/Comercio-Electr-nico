using Mango.Services.ProductAPI.Business.Contracts;
using Mango.Services.ProductAPI.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDto>), 200)]
        public async Task<ActionResult> GetProducts()
        {
            var result = await _productBusiness.GetProducts();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        public async Task<ActionResult> GetProductById(int id)
        {
            var result = await _productBusiness.GetProductsById(id);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        public async Task<ActionResult> Save(ProductDto product)
        {
            var result = await _productBusiness.Create(product);
            return Ok(result);
        }

        [HttpPut]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        public async Task<ActionResult> Updated(ProductDto product)
        {
            var result = await _productBusiness.Update(product);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        [ProducesResponseType(typeof(ProductDto), 200)]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _productBusiness.Delete(id);
            return Ok(result);
        }
    }
}
