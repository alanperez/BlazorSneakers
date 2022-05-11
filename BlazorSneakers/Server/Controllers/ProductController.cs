using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorSneakers.Server.Data;
namespace BlazorSneakers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase {

        private readonly DataContext _context;
        public ProductController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                // Assign Data with our products
                Data = products
            };
            return Ok(products);
        }
    }
}
