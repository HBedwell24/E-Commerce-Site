using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSite.Application.CreateProducts;
using ECommerceSite.Application.Products;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public CreateProduct.ProductViewModel Product { get; set; }

        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var products = new GetProducts(_ctx).Do();
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.ToLower().Contains(SearchString.ToLower()));
            }
            Products = products;
        }   
    }
}
