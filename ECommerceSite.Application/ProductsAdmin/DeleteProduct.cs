﻿using ECommerceSite.Database;
using ECommerceSite.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSite.Application.ProductsAdmin
{
    public class DeleteProduct
    {
        private ApplicationDbContext _context;
        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
        }
    }  
}
