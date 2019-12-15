using ECommerceSite.Database;
using ECommerceSite.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;

namespace ECommerceSite.Application.Cart
{
    public class GetCart
    {
        private ISession _session;
        private ApplicationDbContext _ctx;

        public GetCart(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public int Quantity { get; set; }
            public int StockId { get; set; }
        }

        public Response Do()
        {
            var stringObject = _session.GetString("cart");
            var cartProduct = JsonConvert.DeserializeObject<CartProduct>(stringObject);

            var response = _ctx.Stock
                .Include(x => x.Product)
                .Where(x => x.Id == cartProduct.StockId)
                .Select(x => new Response
                {
                    Name = x.Product.Name,
                    Value = $"${x.Product.Value.ToString("N2")}",
                    StockId = x.Id,
                    Quantity = cartProduct.Quantity
                })
                .FirstOrDefault();

            return response;
        }
    }
}
