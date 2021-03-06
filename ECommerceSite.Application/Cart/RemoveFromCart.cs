﻿using ECommerceSite.Database;
using ECommerceSite.Domain.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSite.Application.Cart
{
    public class RemoveFromCart
    {
        private ISession _session;
        private ApplicationDbContext _ctx;

        public RemoveFromCart(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Quantity { get; set; }
            public bool All { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            if (string.IsNullOrEmpty(stringObject))
            {
                return true;
            }
            cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            if (!cartList.Any(x => x.StockId == request.StockId))
            {
                return true;
            }
            cartList.Find(x => x.StockId == request.StockId).Quantity -= request.Quantity;

            var stockOnHold = _ctx.StocksOnHold
                .FirstOrDefault(x => x.StockId == request.StockId && x.SessionId == _session.Id);

            var stock = _ctx.Stock.FirstOrDefault(x => x.Id == request.StockId);

            if (request.All)
            {
                stock.Quantity += stockOnHold.Quantity;
                stockOnHold.Quantity = 0;

                var itemToRemove = cartList.SingleOrDefault(x => x.StockId == request.StockId);
                cartList.Remove(itemToRemove);
            }
            else
            {
                stock.Quantity += request.Quantity;
                stockOnHold.Quantity -= request.Quantity;
            }

            stringObject = JsonConvert.SerializeObject(cartList);
            _session.SetString("cart", stringObject);

            if (stockOnHold.Quantity <= 0)
            {
                _ctx.Remove(stockOnHold);
            }
            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
