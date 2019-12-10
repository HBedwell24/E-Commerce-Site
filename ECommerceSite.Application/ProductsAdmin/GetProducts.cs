using ECommerceSite.Database;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceSite.Application.ProductsAdmin
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
            Id = x.Id,
            Name = x.Name,
            Value = x.Value,
        });
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Value { get; set; }
        }
    }
    
}
