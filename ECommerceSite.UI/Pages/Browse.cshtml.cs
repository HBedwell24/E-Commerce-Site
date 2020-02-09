using System.Collections.Generic;
using System.Linq;
using ECommerceSite.Application.Products;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.UI.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public ProductsModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public void OnGet()
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
