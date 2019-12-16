using ECommerceSite.Application.Cart;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private ApplicationDbContext _ctx;

        public CartViewComponent(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            return View(view, new GetCart(HttpContext.Session, _ctx).Do());
        }
    }
}
