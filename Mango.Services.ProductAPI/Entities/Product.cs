﻿using Mango.Services.ProductAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Entities
{
    public class Product: EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageLocalPath { get; set; }
    }
}
