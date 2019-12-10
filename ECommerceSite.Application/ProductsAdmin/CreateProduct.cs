using ECommerceSite.Database;
using ECommerceSite.Domain.Models;
using System.Threading.Tasks;

namespace ECommerceSite.Application.ProductsAdmin
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel productViewModel)
        {
            _context.Products.Add(new Product
            {
                Name = productViewModel.Name,
                Description = productViewModel.Description,
                Value = productViewModel.Value
            });
            await _context.SaveChangesAsync();
        }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }  
}
