﻿using ECommerceSite.Database;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceSite.Application.Products
{
    public class GetProducts
    {
        public ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do() => _ctx.Products.ToList().Select(x => new ProductViewModel
        {
            Name = x.Name,
            Description = x.Description,
            Value = $"${x.Value.ToString("N2")}",
        });
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
        }
    }
    
}
