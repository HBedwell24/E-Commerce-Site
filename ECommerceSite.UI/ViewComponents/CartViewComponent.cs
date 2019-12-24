using ECommerceSite.Application.Cart;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            if (view == "Small")
            {
                var totalValue = new GetCart(HttpContext.Session, _ctx).Do().Sum(x => x.RealValue * x.Quantity);
                return View(view, $"${totalValue}");
            }
            return View(view, new GetCart(HttpContext.Session, _ctx).Do());
        }
    }
}
