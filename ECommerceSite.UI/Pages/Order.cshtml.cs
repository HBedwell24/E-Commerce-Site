using ECommerceSite.Application.Orders;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceSite.UI.Pages
{
    public class OrderModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public OrderModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetOrder.Response Order { get; set; }

        public void OnGet(string reference)
        {
            Order = new GetOrder(_ctx).Do(reference);
        }
    }
}