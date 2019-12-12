using ECommerceSite.Application.Products;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.UI.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDbContext _ctx;
        public ProductModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public GetProduct.ProductViewModel Product { get; set; }
        public IActionResult OnGet(string name)
        {
            Product = new GetProduct(_ctx).Do(name.Replace("-", " "));
            if (Product == null)
                return RedirectToPage("Index");
            else
                return Page();
        }
    }
}