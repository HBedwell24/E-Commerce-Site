using ECommerceSite.Application.Cart;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.UI.Pages
{
    public class CartModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public CartModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetCart.Response Cart { get; set; }

        public IActionResult OnGet()
        {
            Cart = new GetCart(HttpContext.Session, _ctx).Do();
            return Page();
        }
    }
}