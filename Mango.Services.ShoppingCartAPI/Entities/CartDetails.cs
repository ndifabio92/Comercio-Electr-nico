using Mango.Services.ShoppingCartAPI.Entities.Dtos;
using Mango.Services.ShoppingCartAPI.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mango.Services.ShoppingCartAPI.Entities
{
    public class CartDetails: EntityBase
    {
        public int CartHeaderId { get; set; }
        [ForeignKey("CartHeaderId")]
        public CartHeader CartHeader { get; set; }
        public int ProductId { get; set; }
        [NotMapped]
        public ProductDto Product { get; set; }
        public int Count { get; set; }
    }
}
