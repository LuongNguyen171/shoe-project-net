using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoe_project_server.Data;

namespace shoe_project_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductImageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getImagesByProductId/{productId}")]
        public async Task<IActionResult> GetImagesByProductId(int productId)
        {
            var images = await _context.productImages
                .Where(img => img.productId == productId)
                .ToListAsync();

            if (images == null || !images.Any())
            {
                return NotFound($"No images found for product with ID {productId}");
            }

            return Ok(images);
        }
    }
}
