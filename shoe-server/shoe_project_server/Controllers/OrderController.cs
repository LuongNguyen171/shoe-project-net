using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoe_project_server.Data;
using shoe_project_server.Models;
using shoe_project_server.Models.DTOs;
using shoe_project_server.Services;

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

     /*   public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }*/
        // get order by user

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

        //get order detail

        [HttpGet("orderDetail/{orderId}")]
        public async Task<ActionResult<OrderDetailsViewModel>> GetOrderDetails(int orderId)
        {
            var order = await _context.orders.FindAsync(orderId);

            if (order == null)
            {
                return NotFound();
            }

            var orderDetails = new OrderDetailsViewModel
            {
                orderId = order.orderId,
                orderStatus = order.orderStatus,
                orderDate = order.orderDate,
                deliveryDate = order.deliveryDate,
                customerPhone = order.customerPhone,
                customerId = order.customerId
            };

            var purchaseHistory = await _context.purchaseHistories
                .Where(p => p.orderId == orderId)
                .Include(p => p.Product)
                .ToListAsync();

            foreach (var item in purchaseHistory)
            {
                var productDetails = new ProductDetailsViewModel
                {
                    productImage = item.Product.productImage,
                    productQuantity = item.productQuantity,
                    productPrice = item.Product.productPrice,
                    totalPrice = item.productQuantity * item.Product.productPrice
                };

                orderDetails.productDetails.Add(productDetails);
                orderDetails.paymentInvoice = orderDetails.productDetails.Sum(p => p.totalPrice);
            }

            return orderDetails;
        }
        //add invoice
        [HttpPost("addOrder")]
        public async Task<IActionResult> AddOrderAndPurchaseHistory([FromBody] OrderAndPurchaseHistoryViewModel orderAndPurchaseHistory)
        {
            try
            {
                var userExists = await _context.Users.AnyAsync(u => u.Id == orderAndPurchaseHistory.userId);
                if (!userExists)
                {
                    return BadRequest("User not found");
                }

                var order = new Order
                {
                    orderStatus = orderAndPurchaseHistory.orderStatus,
                    orderDate = DateTime.Now,
                    deliveryDate = DateTime.Now.AddDays(7), 
                    customerPhone = orderAndPurchaseHistory.customerPhone,
                    customerId = orderAndPurchaseHistory.userId
                };

                _context.orders.Add(order);
                await _context.SaveChangesAsync();

                foreach (var item in orderAndPurchaseHistory.purchaseHistoryItems)
                {
                    var purchaseHistory = new PurchaseHistory
                    {
                        orderId = order.orderId,
                        userId = orderAndPurchaseHistory.userId,
                        productId = item.productId,
                        productQuantity = item.productQuantity
                    };

                    _context.purchaseHistories.Add(purchaseHistory);
                }

                await _context.SaveChangesAsync();

                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == orderAndPurchaseHistory.userId);
                var orderDetail = await GetOrderDetails(order.orderId);

                //send mail
                  await EmailService.SendOrderConfirmationEmail(user, orderDetail.Value);
                

                return Ok(orderDetail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
         }

    }
}
