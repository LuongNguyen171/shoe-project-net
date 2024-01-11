using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoe_project_server.Data;
using shoe_project_server.Models;

namespace shoe_project_server.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("getProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _context.products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


        [HttpGet("getProductImagesByProductId/{productId}")]
        public async Task<IActionResult> GetProductImagesByProductId(int productId)
        {
            var productImages = await _context.productImages
                .Where(pi => pi.productId == productId)
                .Select(pi => new ProductImage
                {
                    productImageId = pi.productImageId,
                    productId = pi.productId,
                    productImage = pi.productImage
                })
                .ToListAsync();

            if (productImages == null || !productImages.Any())
            {
                return NotFound("No product images found for the given productId.");
            }

            return Ok(productImages);
        }
    }
}
