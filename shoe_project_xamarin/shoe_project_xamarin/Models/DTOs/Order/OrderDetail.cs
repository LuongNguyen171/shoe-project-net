using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Order
{
    public class OrderDetail
    {
        public int orderId { get; set; }
        public string orderStatus { get; set; }
        public string orderDate { get; set; }
        public string deliveryDate { get; set; }
        public string customerPhone { get; set; }
        public string customerId { get; set; }
        public double paymentInvoice { get; set; }
        public List<ProductOrderDetail> productDetails { get; set; }
    }

    public class ProductOrderDetail
    {
        public string productImage { get; set; }
        public int productQuantity { get; set; }
        public double productPrice { get; set; }
        public double totalPrice { get; set; }
    }

}
