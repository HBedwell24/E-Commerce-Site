﻿using System;

namespace ECommerceSite.Domain.Models
{
    public class StockOnHold
    {
        public int Id { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}