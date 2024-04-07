using Mango.Services.ShoppingCartAPI.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mango.Services.ShoppingCartAPI.Entities
{
    public class CartHeader: EntityBase
    {
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }
        [NotMapped]
        public double Discount { get; set; }
        [NotMapped]
        public double Total { get; set; }
    }
}