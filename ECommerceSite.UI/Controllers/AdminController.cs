using ECommerceSite.Application.ProductsAdmin;
using ECommerceSite.Database;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _ctx;
        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Do());

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_ctx).Do(id));

        [HttpPost("products")]
        public IActionResult CreateProduct(CreateProduct.ProductViewModel productViewModel) => Ok(new CreateProduct(_ctx).Do(productViewModel));

        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_ctx).Do(id));

        [HttpPut("products")]
        public IActionResult UpdateProduct(UpdateProduct.ProductViewModel productViewModel) => Ok(new UpdateProduct(_ctx).Do(productViewModel));
    }
}
