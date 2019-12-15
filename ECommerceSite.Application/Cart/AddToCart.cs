using ECommerceSite.Domain.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ECommerceSite.Application.Cart
{
    public class AddToCart
    {
        private ISession _session;

        public AddToCart(ISession session)
        {
            _session = session;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Quantity { get; set; }
        }

        public void Do(Request request)
        {
            var cartProduct = new CartProduct
            {
                StockId = request.StockId,
                Quantity = request.Quantity
            };

            var stringObject = JsonConvert.SerializeObject(cartProduct);
            _session.SetString("cart", stringObject);
        }
    }
}
