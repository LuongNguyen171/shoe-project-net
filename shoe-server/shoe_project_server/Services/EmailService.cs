using MimeKit;
using shoe_project_server.Models.DTOs;
using System.Net.Mail;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using shoe_project_server.Data;

namespace shoe_project_server.Services
{
    public class EmailService
    {
        public static async Task SendOrderConfirmationEmail(ApplicationUser user, OrderDetailsViewModel orderDetail)
        {
          
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("SHOE STORE", "shoestore@gmail.com"));
                emailMessage.To.Add(new MailboxAddress(user.UserName, user.Email));
                emailMessage.Subject = "Order Confirmation";

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody += $"<p>Hi {user.UserName},</p>";
                bodyBuilder.HtmlBody += $"<p>Thank you for your order with SHOE STORE! Here are the details of your purchase:</p>";
                bodyBuilder.HtmlBody += $"<p>Order Status: {orderDetail.orderStatus}</p>";
                bodyBuilder.HtmlBody += $"<p>Order Date: {orderDetail.orderDate}</p>";
                bodyBuilder.HtmlBody += $"<p>Delivery Date: {orderDetail.deliveryDate}</p>";
                bodyBuilder.HtmlBody += $"<p>Customer Phone: {orderDetail.customerPhone}</p>";
                bodyBuilder.HtmlBody += $"<p>Customer ID: {orderDetail.customerId}</p>";
                bodyBuilder.HtmlBody += $"<p>Payment Invoice: {orderDetail.paymentInvoice:C}</p><br/>";

                bodyBuilder.HtmlBody += "<p>Product Details:</p><ul>";
                foreach (var item in orderDetail.productDetails)
                {
                    bodyBuilder.HtmlBody += $"<ul><li>Quantity: {item.productQuantity}</li>";
                    bodyBuilder.HtmlBody += $"<li>Price: {item.productPrice:C}</li>";
                    bodyBuilder.HtmlBody += $"<li>Total Price: {item.totalPrice:C}</li>";
                    bodyBuilder.HtmlBody += $"<li>Image: {item.productImage}</li></ul></li>";
                }
                bodyBuilder.HtmlBody += "</ul>";

                bodyBuilder.HtmlBody += "<p>If you have any questions or concerns, please feel free to contact us.</p>";
                bodyBuilder.HtmlBody += "<p>Thank you for shopping with us!</p>";
                bodyBuilder.HtmlBody += "<p>Best regards,<br/>[SHOE STORE]</p>";

                emailMessage.Body = bodyBuilder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, false);
                    await client.AuthenticateAsync("luongnguyen170102@gmail.com", "lnmeuvzvpdzypgta");
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
            
           
        }
    }
}
