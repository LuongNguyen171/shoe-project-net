using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoe_project_server.Data;
using shoe_project_server.Models;

namespace shoe_project_server.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getOrderByCustomer/{customerId}")]
        public async Task<IActionResult> GetImagesByProductId(string customerId)
        {
            var orders = await _context.orders
                .Where(o => o.customerId == customerId)
                .ToListAsync();

            if (orders == null || !orders.Any())
            {
                return NotFound($"No orders found for user with ID {customerId}");
            }

            return Ok(orders);
        }
    }
}
