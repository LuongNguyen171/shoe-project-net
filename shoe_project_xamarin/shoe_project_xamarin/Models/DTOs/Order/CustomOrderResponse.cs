using System;
using System.Collections.Generic;
using System.Text;

namespace shoe_project_xamarin.Models.DTOs.Order
{
    class CustomOrderResponse
    {
        public int orderId { get; set; }
        public string orderStatus { get; set; }
        public string orderDate { get; set; }
        public string deliveryDate { get; set; }
        public string customerPhone { get; set; }
        public string customerId { get; set; }
    }
}
